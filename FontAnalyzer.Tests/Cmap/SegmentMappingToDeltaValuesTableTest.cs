using System;
using System.IO;
using FontAnalyzer.TTF;
using FontAnalyzer.TTF.Cmap;
using Xunit;

namespace FontAnalyzer.Tests.Cmap
{
    public class SegmentMappingToDeltaValuesTableTest
    {
        [Fact]
        public void ShouldGetCorrectGlyphIndex()
        {
            using (var reader = new FontReader(File.OpenRead(@"C:\Windows\Fonts\Arial.ttf")))
            {
                var subTable = LoadSubTable(reader);
                Assert.Equal(36u, subTable.GetGlyphIndex('A'));
                Assert.Equal(93u, subTable.GetGlyphIndex('z'));
            }
        }

        private static SegmentMappingToDeltaValuesTable LoadSubTable(FontReader reader)
        {
            if (TrueTypeFont.TryGetTablePosition(reader, "cmap", out var cmapOffset))
            {
                reader.Seek(cmapOffset);
                if (CmapTable.TryGetSubTablePosition(reader, CMapSubtableFormat.SegmentMappingToDeltaValues, out var subOffset))
                {
                    reader.Seek(cmapOffset + subOffset);
                    return SegmentMappingToDeltaValuesTable.FromReader(reader);
                }
            }

            throw new Exception("No SegmentMappingToDeltaValuesTable found");
        }
    }
}
