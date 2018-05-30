namespace FontAnalyzer.TTF.Cmap
{
    public sealed class SequentialMapGroup
    {        
        public static SequentialMapGroup FromReader(FontReader reader)
        {
            var startCharCode = reader.ReadUInt32BigEndian();
            var endCharCode = reader.ReadUInt32BigEndian();
            var startGlyphId = reader.ReadUInt32BigEndian();

            return new SequentialMapGroup(startCharCode, endCharCode, startGlyphId);
        }        

        public SequentialMapGroup(uint startCharCode, uint endCharCode, uint startGlyphId)
        {
            this.StartCharCode = startCharCode;
            this.EndCharCode = endCharCode;
            this.StartGlyphId = startGlyphId;
        }

        public uint StartCharCode { get; }
        public uint EndCharCode { get; }
        public uint StartGlyphId { get; }
    }
}
