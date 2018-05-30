using System;
using System.Collections.Generic;
using System.Linq;

namespace FontAnalyzer.TTF.Cmap
{
    public sealed class CmapTable
    {        
        public static CmapTable FromReader(FontReader reader)
        {
            var cmapOffset = reader.Position;
            var version = reader.ReadUInt16BigEndian();
            if (version != 0)
            {
                throw new Exception($"Unexpected Cmap tab;e version. Expected: 0, actual: {version}");
            }

            var tables = reader.ReadUInt16BigEndian();

            var encodingRecords = new EncodingRecord[tables];
            for (var i = 0; i < tables; i++)
            {
                encodingRecords[i] = EncodingRecord.FromReader(reader, cmapOffset);
            }

            return new CmapTable(version, encodingRecords);
        }

        public static bool TryGetSubTablePosition(FontReader reader, CMapSubtableFormat format, out long offset)
        {
            var cmapTable = FromReader(reader);
            var entry = cmapTable.EncodingRecords.FirstOrDefault(
                e => e.Format == format);

            if (entry != null)
            {
                offset = entry.Offset;
                return true;
            }

            offset = 0;
            return false;
        }

        private CmapTable(ushort version, IReadOnlyList<EncodingRecord> encodingRecords)
        {
            this.Version = version;
            this.EncodingRecords = encodingRecords;
        }

        public ushort Version { get; }
        public IReadOnlyList<EncodingRecord> EncodingRecords { get; }
    }
}
