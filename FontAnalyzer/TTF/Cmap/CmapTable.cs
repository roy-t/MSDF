using System;
using System.Collections.Generic;

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

        private CmapTable(ushort version, IReadOnlyList<EncodingRecord> encodingRecords)
        {
            this.Version = version;
            this.EncodingRecords = encodingRecords;
        }

        public ushort Version { get; }
        public IReadOnlyList<EncodingRecord> EncodingRecords { get; }
    }
}
