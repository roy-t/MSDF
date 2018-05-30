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
            var subTable = ReadSubtable(reader, out var format);
            reader.Seek(lastPosition);

            return new EncodingRecord(platformId, encodingId, offset, subTable, format);
        }

        private static ICmapSubtable ReadSubtable(FontReader reader, out CMapSubtableFormat format)
        {
            var start = reader.Position;
            format = (CMapSubtableFormat) reader.ReadUInt16BigEndian();
            reader.Seek(start);
            switch (format)
            {
                // Ordered from most to least used, on the Windows platform                
                case CMapSubtableFormat.SegmentMappingToDeltaValues: // Format 4
                    return SegmentMappingToDeltaValuesTable.FromReader(reader);

                case CMapSubtableFormat.TrimmedTableMapping: // Format 6
                    return TrimmedTableMappingTable.FromReader(reader);


                case CMapSubtableFormat.SegmentedCoverage:  // Format 12
                    return SegmentedCoverageTable.FromReader(reader);

                case CMapSubtableFormat.ByteEncodingTable: // Format 0
                    return ByteEncodingTable.FromReader(reader);

                // Used for specifying variations of the same glyph in a single font
                case CMapSubtableFormat.UnicodeVariationSequences: // Format 14
                    return null;

                // The following formats are not used by any of the default fonts in Windows 10
                case CMapSubtableFormat.HighByteMappingThroughTable:
                    return null;

                case CMapSubtableFormat.MixedCoverage:
                    return null;

                case CMapSubtableFormat.TrimmedArray:
                    return null;

                case CMapSubtableFormat.ManyToOneRangeMappings:
                    return null;

                default:
                    return null;
            }
        }

        private EncodingRecord(Platform platformId, WindowsEncoding encodingId, uint offset, ICmapSubtable subtable, CMapSubtableFormat format)
        {
            this.PlatformId = platformId;
            this.WindowsEncodingId = encodingId;
            this.Offset = offset;
            this.Subtable = subtable;
            this.Format = format;
        }

        public Platform PlatformId { get; }          
        /// <summary>
        /// Encoding, only valid if platform is Windows
        /// </summary>
        public WindowsEncoding WindowsEncodingId { get; }
        public uint Offset { get; }
        public ICmapSubtable Subtable { get; }
        public CMapSubtableFormat Format { get; }
    }
}
