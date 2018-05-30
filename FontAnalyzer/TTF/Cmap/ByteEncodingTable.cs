namespace FontAnalyzer.TTF.Cmap
{
    public sealed class ByteEncodingTable : ICmapSubtable
    {
        public static ByteEncodingTable FromReader(FontReader reader)
        {
            var format   = reader.ReadUInt16BigEndian();
            var length   = reader.ReadUInt16BigEndian();
            var language = reader.ReadUInt16BigEndian();
            var ids      = new byte[256];

            for (var i = 0; i < ids.Length; i++)
            {
                ids[i] = reader.ReadByte();
            }

            return new ByteEncodingTable(length, language, ids);
        }        
        
        private ByteEncodingTable(ushort length, ushort language, byte[] ids)
        {
            this.Length = length;
            this.Language = language;
            this.Ids = ids;
        }

        public ushort Length { get; }
        public ushort Language { get; }
        public byte[] Ids { get; }

        public uint GetGlyphIndex(char c)
        {            
            var charCode = (int) c;
            if (c >= 0 && c < this.Ids.Length)
            {
                return this.Ids[charCode];
            }

            return 0;
        }
    }
}
