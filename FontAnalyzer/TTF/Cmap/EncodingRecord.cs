using System.IO;

namespace FontAnalyzer.TTF.Cmap
{
    public sealed class EncodingRecord
    {        
        public static EncodingRecord FromReader(FontReader reader, long cmapOffset)
        {
            var platformId = (Platform)reader.ReadUInt16BigEndian();            
            var encodingId = (WindowsEncoding)reader.ReadUInt16BigEndian();
            var offset = reader.ReadUInt32BigEndian();

            var lastPosition = reader.Position;
            reader.Seek(cmapOffset + offset);
            var subTable = ReadSubtable(reader);
            reader.Seek(lastPosition);

            return new EncodingRecord(platformId, encodingId, offset, subTable);
        }

        private static ICmapSubtable ReadSubtable(FontReader reader)
        {
            var format = (CMapSubtableFormat) reader.ReadUInt16BigEndian();
            switch (format)
            {
                case CMapSubtableFormat.ByteEncodingTable:
                    return ByteEncodingTable.FromReader(reader);
                default:
                    return null;
            }
        }

        private EncodingRecord(Platform platformId, WindowsEncoding encodingId, uint offset, ICmapSubtable subtable = null)
        {
            this.PlatformId = platformId;
            this.WindowsEncodingId = encodingId;
            this.Offset = offset;
            this.Subtable = subtable;
        }

        public Platform PlatformId { get; }  
        
        /// <summary>
        /// Encoding, only valid if platform is Windows
        /// </summary>
        public WindowsEncoding WindowsEncodingId { get; }


        public uint Offset { get; }
        public ICmapSubtable Subtable { get; }
    }
}
