namespace FontAnalyzer.TTF.Cmap
{
    public sealed class SegmentMappingToDeltaValuesTable : ICmapSubtable
    {        
        public static SegmentMappingToDeltaValuesTable FromReader(FontReader reader)
        {
            var start = reader.Position;

            var format = reader.ReadUInt16BigEndian();
            var length = reader.ReadUInt16BigEndian();
            var language = reader.ReadUInt16BigEndian();

            var segCountX2 = reader.ReadUInt16BigEndian();
            var searchRange = reader.ReadUInt16BigEndian();
            var entrySelector = reader.ReadUInt16BigEndian();
            var rangeShift = reader.ReadUInt16BigEndian();


            var segCount = segCountX2 / 2;
            var endCount = new ushort[segCount];
            for (var i = 0; i < endCount.Length; i++)
            {
                endCount[i] = reader.ReadUInt16BigEndian();
            }

            var reservedPad = reader.ReadUInt16BigEndian();

            var startCount = new ushort[segCount];
            for (var i = 0; i < startCount.Length; i++)
            {
                startCount[i] = reader.ReadUInt16BigEndian();
            }

            var idDelta = new short[segCount];
            for (var i = 0; i < idDelta.Length; i++)
            {
                idDelta[i] = reader.ReadInt16BigEndian();
            }

            var idRangeOffset = new ushort[segCount];
            for (var i = 0; i < idRangeOffset.Length; i++)
            {
                idRangeOffset[i] = reader.ReadUInt16BigEndian();
            }
            
            var read = start - reader.Position;
            var glyphCount = (length - read) / sizeof (ushort);
            var glyphIdArray = new ushort[glyphCount];
            for (var i = 0; i < glyphIdArray.Length; i++)
            {
                glyphIdArray[i] = reader.ReadUInt16BigEndian();
            }

            return new SegmentMappingToDeltaValuesTable(length, language, segCount, searchRange, entrySelector, rangeShift, 
                endCount, startCount, idDelta, idRangeOffset, glyphCount, glyphIdArray);
        }

        public ushort Length { get; }
        public ushort Language { get; }
        public int SegCount { get; }
        public ushort SearchRange { get; }
        public ushort EntrySelector { get; }
        public ushort RangeShift { get; }
        public ushort[] EndCount { get; }
        public ushort[] StartCount { get; }
        public short[] IdDelta { get; }
        public ushort[] IdRangeOffset { get; }
        public long GlyphCount { get; }
        public ushort[] GlyphIdArray { get; }

        public SegmentMappingToDeltaValuesTable(ushort length, ushort language, int segCount, ushort searchRange, ushort entrySelector, ushort rangeShift, ushort[] endCount, ushort[] startCount, short[] idDelta, ushort[] idRangeOffset, long glyphCount, ushort[] glyphIdArray)
        {
            this.Length = length;
            this.Language = language;
            this.SegCount = segCount;
            this.SearchRange = searchRange;
            this.EntrySelector = entrySelector;
            this.RangeShift = rangeShift;
            this.EndCount = endCount;
            this.StartCount = startCount;
            this.IdDelta = idDelta;
            this.IdRangeOffset = idRangeOffset;
            this.GlyphCount = glyphCount;
            this.GlyphIdArray = glyphIdArray;
        }

        public uint GetGlyphIndex(char c)
        {
            var charCode = (ushort) c;

            // Find the first segment that fits the charcode
            for (var i = 0; i < this.SegCount; i++)
            {
                var start = this.StartCount[i];
                var end = this.EndCount[i];

                if (start <= charCode && end >= charCode)
                {
                    var delta = this.IdDelta[i];
                    var rangeOffset = this.IdRangeOffset[i];

                    if (rangeOffset == 0)
                    {                        
                        return (ushort) ((delta + c) % 65536);
                    }
                    
                    // Index depends on the position of rangeOffset in the IdRangeOffset array
                    var index = rangeOffset + (c - start) + i;
                    var glyphId = this.GlyphIdArray[index];

                    if (glyphId != 0)
                    {
                        return (ushort) ((glyphId + c) % 65536);
                    }
                }
            }

            return 0;      
        }
    }
}
