using System.Collections.Generic;

namespace FontAnalyzer.TTF.Cmap
{
    public sealed class SegmentedCoverageTable : ICmapSubtable
    {
        public static SegmentedCoverageTable FromReader(FontReader reader)
        {
            var format    = reader.ReadUInt16BigEndian();
            var reserved  = reader.ReadUInt16BigEndian();
            var length    = reader.ReadUInt32BigEndian();
            var language  = reader.ReadUInt32BigEndian();
            var numGroups = reader.ReadUInt32BigEndian();

            var groups = new SequentialMapGroup[numGroups];

            for (var i = 0; i < groups.Length; i++)
            {
                groups[i] = SequentialMapGroup.FromReader(reader);
            }

            return new SegmentedCoverageTable(length, language, numGroups, groups);
        }

        private SegmentedCoverageTable(uint length, uint language, uint numGroups, IReadOnlyList<SequentialMapGroup> groups)
        {
            this.Length = length;
            this.Language = language;
            this.NumGroups = numGroups;
            this.Groups = groups;
        }

        public uint Length { get; }
        public uint Language { get; }
        public uint NumGroups { get; }
        public IReadOnlyList<SequentialMapGroup> Groups { get; }


        public uint GetGlyphIndex(char c)
        {
            var charCode = (uint) c;

            foreach (var group in this.Groups)
            {
                if (group.StartCharCode <= charCode && charCode <= group.EndCharCode)
                {
                    return charCode - group.StartCharCode + group.StartGlyphId;
                }
            }

            return 0;
        }
    }
}
