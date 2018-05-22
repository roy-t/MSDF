using System;
using System.Linq;
using FontAnalyzer.TrueType;

namespace FontAnalyzer
{
    public static class Analyzer
    {
        public static float Do(string fontPath, char left, char right)
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

                switch (subTable.Table.Format)
                {
                    case Cmap.Subtable.SubtableFormat.ByteEncodingTable:
                        var byteTable = (Cmap.Subtable.ByteEncodingTable)subTable.Table.Value;
                        
                        if (charCode < byteTable.GlyphIdArray.Length)
                        {
                            return byteTable.GlyphIdArray[charCode];
                        }

                        break;
                    case Cmap.Subtable.SubtableFormat.HighByteMappingThroughTable:
                        var highByteTable = (Cmap.Subtable.HighByteMappingThroughTable)subTable.Table.Value;


                        break;
                    case Cmap.Subtable.SubtableFormat.SegmentMappingToDeltaValues:
                        var segmentTable = (Cmap.Subtable.SegmentMappingToDeltaValues)subTable.Table.Value;
                        // TODO: https://developer.apple.com/fonts/TrueType-Reference-Manual/RM06/Chap6cmap.html
                        break;
                    case Cmap.Subtable.SubtableFormat.TrimmedTableMapping:
                        var trimmedTable = (Cmap.Subtable.TrimmedTableMapping)subTable.Table.Value;

                        var trimmedCode = (int)(charCode - trimmedTable.FirstCode);
                        if (trimmedCode < trimmedTable.GlyphIdArray.Count)
                        {
                            return trimmedTable.GlyphIdArray[trimmedCode];
                        }
                        
                        break;
                    default:
                        break;
                }
            }
            
            return 0;
        }
    }
}
