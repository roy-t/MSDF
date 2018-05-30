namespace FontAnalyzer.TTF.Cmap
{
    public sealed class TrimmedTableMappingTable : ICmapSubtable
    {        
        public static TrimmedTableMappingTable FromReader(FontReader reader)
        {
            var format     = reader.ReadUInt16BigEndian();
            var length     = reader.ReadUInt16BigEndian();
            var language   = reader.ReadUInt16BigEndian();
            var firstCode  = reader.ReadUInt16BigEndian();
            var entryCount = reader.ReadUInt16BigEndian();

            var glyphIdArray = new ushort[entryCount];
            for (var i = 0; i < glyphIdArray.Length; i++)
            {
                glyphIdArray[i] = reader.ReadUInt16BigEndian();
            }

            return new TrimmedTableMappingTable(length, language, firstCode, entryCount, glyphIdArray);
        }

        public TrimmedTableMappingTable(ushort length, ushort language, ushort firstCode, ushort entryCount, ushort[] glyphIdArray)
        {
            this.Length = length;
            this.Language = language;
            this.FirstCode = firstCode;
            this.EntryCount = entryCount;
            this.GlyphIdArray = glyphIdArray;
        }


        public ushort Length { get; }
        public ushort Language { get; }
        public ushort FirstCode { get; }
        public ushort EntryCount { get; }
        public ushort[] GlyphIdArray { get; }


        public uint GetGlyphIndex(char c)
        {
            var charCode = (ushort) c;

            if (this.FirstCode <= charCode && charCode < this.FirstCode + this.EntryCount)
            {
                return this.GlyphIdArray[charCode - this.FirstCode];
            }

            return 0;
        }
    }
}
