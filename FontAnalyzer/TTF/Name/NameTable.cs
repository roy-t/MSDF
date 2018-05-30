namespace FontAnalyzer.TTF.Name
{
    public sealed class NameTable
    {
        public static NameTable FromReader(FontReader reader)
        {
            var start = reader.Position;

            var format = reader.ReadUInt16BigEndian();
            var count = reader.ReadUInt16BigEndian();
            var stringOffset = reader.ReadUInt16BigEndian();

            var nameRecords = new NameRecord[count];
            for (var i = 0; i < nameRecords.Length; i++)
                nameRecords[i] = NameRecord.FromReader(reader, start + stringOffset);

            return new NameTable(format, count, stringOffset, nameRecords);
        }

        public NameTable(ushort format, ushort count, ushort stringOffset, NameRecord[] nameRecords)
        {
            this.Format = format;
            this.Count = count;
            this.StringOffset = stringOffset;
            this.NameRecords = nameRecords;
        }

        public ushort Format { get; }
        public ushort Count { get; }
        public ushort StringOffset { get; }
        public NameRecord[] NameRecords { get; }        
    }
}