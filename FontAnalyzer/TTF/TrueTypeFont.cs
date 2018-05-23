using System;
using System.Collections.Generic;
using System.IO;
using FontAnalyzer.TTF.Cmap;

namespace FontAnalyzer.TTF
{
    public sealed class TrueTypeFont
    {

        public static TrueTypeFont FromFile(string path)
        {
            using (var reader = new FontReader(File.OpenRead(path)))
            {
                var offsetTable = OffsetTable.FromReader(reader);
                var entries = new Dictionary<string, TableRecordEntry>(offsetTable.Tables);
                for (var i = 0; i < offsetTable.Tables; i++)
                {
                    var entry = TableRecordEntry.FromReader(reader);
                    entries.Add(entry.Tag, entry);
                }
                
                var cmap = ReadCmapTable(path, reader, entries);

                return new TrueTypeFont(offsetTable, entries, cmap);
            }
        }

        private static CmapTable ReadCmapTable(string path, FontReader reader, Dictionary<string, TableRecordEntry> entries)
        {
            // Every True Type Font has a Cmap
            if (entries.TryGetValue("cmap", out TableRecordEntry cmapEntry))
            {
                reader.Seek(cmapEntry.Offset);
                return CmapTable.FromReader(reader);
            }

            throw new Exception(
                $"Font {path} does not contain a Character To Glyph Index Mapping Table (cmap)");

        }

        private TrueTypeFont(OffsetTable offsetTable, IReadOnlyDictionary<string, TableRecordEntry> entries, CmapTable cmapTable)
        {            
            this.OffsetTable = offsetTable;
            this.TableRecordEntries = entries;
            this.CmapTable = cmapTable;
        }

        public OffsetTable OffsetTable { get; }
        public IReadOnlyDictionary<string, TableRecordEntry> TableRecordEntries { get; }
        public CmapTable CmapTable { get; }
    }
}
