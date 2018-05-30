using System;
using System.Collections.Generic;
using System.IO;
using FontAnalyzer.TTF.Cmap;
using FontAnalyzer.TTF.Name;

namespace FontAnalyzer.TTF
{
    public sealed class TrueTypeFont
    {

        public static TrueTypeFont FromFile(string path)
        {
            using (var reader = new FontReader(File.OpenRead(path)))
            {
                var offsetTable = OffsetTable.FromReader(reader);
                var entries = ReadTableRecords(reader, offsetTable);

                var cmap = ReadCmapTable(path, reader, entries);
                var name = ReadNameTable(path, reader, entries);

                return new TrueTypeFont(path, offsetTable, entries, cmap, name);
            }
        }
      
        public static bool TryGetTablePosition(FontReader reader, string tableName, out long offset)
        {
            reader.Seek(0);
            var offsetTable = OffsetTable.FromReader(reader);
            var entries = ReadTableRecords(reader, offsetTable);

            if (entries.TryGetValue(tableName, out var cmapEntry))
            {
                offset = cmapEntry.Offset;
                return true;
            }

            offset = 0;
            return false;
        }

        private static Dictionary<string, TableRecordEntry> ReadTableRecords(FontReader reader, OffsetTable offsetTable)
        {
            var entries = new Dictionary<string, TableRecordEntry>(offsetTable.Tables);
            for (var i = 0; i < offsetTable.Tables; i++)
            {
                var entry = TableRecordEntry.FromReader(reader);
                entries.Add(entry.Tag, entry);
            }

            return entries;
        }

        private static CmapTable ReadCmapTable(string path, FontReader reader, Dictionary<string, TableRecordEntry> entries)
        {
            if (entries.TryGetValue("cmap", out TableRecordEntry cmapEntry))
            {
                reader.Seek(cmapEntry.Offset);
                return CmapTable.FromReader(reader);
            }

            throw new Exception(
                $"Font {path} does not contain a Character To Glyph Index Mapping Table (cmap)");

        }

        private static NameTable ReadNameTable(string path, FontReader reader, Dictionary<string, TableRecordEntry> entries)
        {            
            if (entries.TryGetValue("name", out TableRecordEntry cmapEntry))
            {
                reader.Seek(cmapEntry.Offset);
                return NameTable.FromReader(reader);
            }

            throw new Exception(
                $"Font {path} does not contain a Name Table (name)");

        }

        private TrueTypeFont(string source, OffsetTable offsetTable, IReadOnlyDictionary<string, TableRecordEntry> entries, CmapTable cmapTable, NameTable nameTable)
        {
            this.Source = source;
            this.OffsetTable = offsetTable;
            this.TableRecordEntries = entries;
            this.CmapTable = cmapTable;
            this.NameTable = nameTable;
        }

        public string Source { get; }
        public OffsetTable OffsetTable { get; }
        public IReadOnlyDictionary<string, TableRecordEntry> TableRecordEntries { get; }
        public CmapTable CmapTable { get; }
        public NameTable NameTable { get; }

        public override string ToString() => this.Source;
    }
}
