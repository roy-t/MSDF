using System;
using System.IO;
using FontAnalyzer.TTF;
using FontAnalyzer.TTF.Cmap;
using Xunit;

namespace FontAnalyzer.Tests.Cmap
{
    public class TrimmedTableMappingTableTests
    {
        [Fact]
        public void ShouldGetCorrectGlyphIndex()
        {
            using (var reader = new FontReader(File.OpenRead(@"C:\Windows\Fonts\Calibri.ttf")))
            {
                var subTable = LoadSubTable(reader);
                Assert.Equal(4u, subTable.GetGlyphIndex('A'));
                Assert.Equal(460u, subTable.GetGlyphIndex('z'));
            }
        }

        private static TrimmedTableMappingTable LoadSubTable(FontReader reader)
        {
            if (TrueTypeFont.TryGetTablePosition(reader, "cmap", out var cmapOffset))
            {
                reader.Seek(cmapOffset);
                if (CmapTable.TryGetSubTablePosition(reader, CMapSubtableFormat.TrimmedTableMapping, out var subOffset))
                {
                    reader.Seek(cmapOffset + subOffset);
                    return TrimmedTableMappingTable.FromReader(reader);
                }
            }

            throw new Exception("No TrimmedTableMappingTable found");
        }
    }
}
