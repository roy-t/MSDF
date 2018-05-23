namespace FontAnalyzer.TTF.Cmap
{
    public enum CMapSubtableFormat : ushort
    {
        ByteEncodingTable = 0,
        HighByteMappingThroughTable = 2,
        SegmentMappingToDeltaValues = 4,
        TrimmedTableMapping = 6,
        MixedCoverage = 8,
        TrimmedArray = 10,
        SegmentedCoverage = 12,
        ManyToOneRangeMappings = 13,
        UnicodeVariationSequences = 14
    }
}
