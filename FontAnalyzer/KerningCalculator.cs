using System;
using System.Linq;
using FontAnalyzer.TrueType;
using FontAnalyzer.TrueType.Cmap;
using FontAnalyzer.TrueType.Kern;

namespace FontAnalyzer
{
    public static class KerningCalculator
    {
        public static float GetKerning(string fontPath, char left, char right)
        {           
            var ttf = Ttf.FromFile(fontPath);

            var cmapDir = ttf.DirectoryTable.First(x => string.Equals(
                x.Tag,
                "cmap",
                StringComparison.InvariantCultureIgnoreCase));

            var cmapTable = (Cmap) cmapDir.Value;

            var kernDir = ttf.DirectoryTable.First(x => string.Equals(
                x.Tag,
                "kern",
                StringComparison.InvariantCultureIgnoreCase));

            var kernTable = (Kern) kernDir.Value;

            var leftCode = GetGlyphId(cmapTable, left);
            var rightCode = GetGlyphId(cmapTable, right);

            if (leftCode != 0 && rightCode != 0)
            {
                var kerning = GetKerningPair(kernTable, leftCode, rightCode);         
                
                // Divided by 64.0f because that is what MSDFGEN does so the advance and kerning are in the same unit
                return kerning / 64.0f;
            }

            return 0.0f;
        }

        private static int GetKerningPair(Kern kernTable, int leftCode, int rightCode)
        {
            foreach (var subTable in kernTable.Subtables)
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

        private static ushort GetGlyphId(Cmap cmapTable, char c)
        {
            var charCode = (uint)c;
            foreach (var subTable in cmapTable.Tables)
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
