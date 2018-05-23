namespace FontAnalyzer.TTF
{
    public sealed class TableRecordEntry
    {       
        public static TableRecordEntry FromReader(FontReader reader)
        {
            var tag = reader.ReadAscii(4);
            var checksum = reader.ReadUInt32BigEndian();
            var offset = reader.ReadUInt32BigEndian();
            var length = reader.ReadUInt32BigEndian();

            return new TableRecordEntry(tag, checksum, offset, length);
        }


        private TableRecordEntry(string tag, uint checksum, uint offset, uint length)
        {
            this.Tag = tag;
            this.Checksum = checksum;
            this.Offset = offset;
            this.Length = length;
        }

        public string Tag { get; }
        public uint Checksum { get; }
        public uint Offset { get; }
        public uint Length { get; }


        public override string ToString() => this.Tag;
    }
}
