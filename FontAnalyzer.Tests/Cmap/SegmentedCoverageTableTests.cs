using System;
using System.IO;
using FontAnalyzer.TTF;
using FontAnalyzer.TTF.Cmap;
using Xunit;

namespace FontAnalyzer.Tests.Cmap
{
    public class SegmentedCoverageTableTests
    {
        [Fact]
        public void ShouldGetCorrectGlyphIndex()
        {
            using (var reader = new FontReader(File.OpenRead(@"C:\Windows\Fonts\Nirmala.ttf")))
            {
                var subTable = LoadSubTable(reader);
                Assert.Equal(4u, subTable.GetGlyphIndex('A'));
                Assert.Equal(89u, subTable.GetGlyphIndex('z'));
            }
        }

        private static SegmentedCoverageTable LoadSubTable(FontReader reader)
        {
            if (TrueTypeFont.TryGetTablePosition(reader, "cmap", out var cmapOffset))
            {
                reader.Seek(cmapOffset);
                if (CmapTable.TryGetSubTablePosition(reader, CMapSubtableFormat.SegmentedCoverage, out var subOffset))
                {
                    reader.Seek(cmapOffset + subOffset);
                    return SegmentedCoverageTable.FromReader(reader);
                }
            }

            throw new Exception("No SegmentedCoverageTable found");
        }
    }
}
