using System;
using System.Linq;
using FontAnalyzer.TrueType;
using FontAnalyzer.TrueType.Cmap;
using FontAnalyzer.TrueType.Kern;
using FontAnalyzer.TTF;

namespace FontAnalyzer
{
    public class KerningCalculator
    {
        private readonly Cmap cmapTable;
        private readonly Kern kernTable;

        public KerningCalculator(string fontPath)
        {
            var ttf = Ttf.FromFile(fontPath);

            var ttf2 = TrueTypeFont.FromFile(fontPath);

            var cmapDir = ttf.DirectoryTable.First(x => string.Equals(
                x.Tag,
                "cmap",
                StringComparison.InvariantCultureIgnoreCase));

            // Every font has a cmap table, or there is something very seriously wrong
            this.cmapTable = (Cmap)cmapDir.Value;

            var kernDir = ttf.DirectoryTable.First(x => string.Equals(
                x.Tag,
                "kern",
                StringComparison.InvariantCultureIgnoreCase));

            // But some fonts might not have kerning information, for example: fixed width fonts
            if (kernDir.Value != null)
            {
                this.kernTable = (Kern)kernDir.Value;
            }            
        }

        public float GetKerning(char left, char right)
        {                     
            var leftCode = GetGlyphId(left);
            var rightCode = GetGlyphId(right);

            if (leftCode != 0 && rightCode != 0)
            {
                return GetKerning(leftCode, rightCode);
            }

            return 0.0f;
        }

        private int GetKerning(int leftCode, int rightCode)
        {
            foreach (var subTable in this.kernTable.Subtables)
            {
                if (subTable.IsHorizontal)
                {
                    var pairs = subTable.Format0.KerningPairs;
                    var match = pairs.FirstOrDefault(x => x.Left == leftCode && x.Right == rightCode);
                    if (match != null)
                    {
                        return match.Value;
                    }                                      
                }
            }

            return 0;
        }      

        private ushort GetGlyphId(char c)
        {
            var charCode = (uint)c;
            foreach (var subTable in this.cmapTable.Tables)
            {
                // Prefer subTable.PlatformId == PlatformIds.Windows?
                //https://docs.microsoft.com/en-us/typography/opentype/spec/cmap

                switch (subTable.Table.Format)
                {
                    // Format 0: Very simple cmap that supports a maximum of 256 characters (ASCII)
                    case CMapSubtableFormat.ByteEncodingTable:
                        var byteTable = (ByteEncodingTable)subTable.Table.Value;
                        
                        if (charCode < byteTable.GlyphIdArray.Length)
                        {
                            return byteTable.GlyphIdArray[charCode];
                        }
                
                        break;

                    // Format 4: Standard encoding for Windows Unicode BMP characters
                    case CMapSubtableFormat.SegmentMappingToDeltaValues:
                        var segmentTable = (SegmentMappingToDeltaValues)subTable.Table.Value;
                        // TODO: https://developer.apple.com/fonts/TrueType-Reference-Manual/RM06/Chap6cmap.html
                        break;

                    // Format 6: Simple cmap that supports one continuous subrange of characters, supports a maximum of 65535 characters
                    case CMapSubtableFormat.TrimmedTableMapping:
                        var trimmedTable = (TrimmedTableMapping)subTable.Table.Value;

                        var trimmedCode = (int)(charCode - trimmedTable.FirstCode);
                        if (trimmedCode < trimmedTable.GlyphIdArray.Count)
                        {
                            return trimmedTable.GlyphIdArray[trimmedCode];
                        }
                        
                        break;

                    // Format 2: legacy support for Japanese/Korean/Chinese fonts can be loaded but is not yet processed
                    case CMapSubtableFormat.HighByteMappingThroughTable:
                        return 0;
                    
                        // Format 8, 10, 12, 13, 14 have not yet been implement
                    default:
                        return 0;
                }
            }
            
            return 0;
        }
    }
}
