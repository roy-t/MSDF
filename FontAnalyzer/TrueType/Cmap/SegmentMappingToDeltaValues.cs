// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{
    public class SegmentMappingToDeltaValues : KaitaiStruct
    {
        public static SegmentMappingToDeltaValues FromFile(string fileName)
        {
            return new SegmentMappingToDeltaValues(new KaitaiStream(fileName));
        }

        public SegmentMappingToDeltaValues(
            KaitaiStream p__io,
            CMapSubtable p__parent = null,
            Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            this.f_segCount = false;
            _read();
        }

        private void _read()
        {
            this._segCountX2 = this.m_io.ReadU2be();
            this._searchRange = this.m_io.ReadU2be();
            this._entrySelector = this.m_io.ReadU2be();
            this._rangeShift = this.m_io.ReadU2be();
            this._endCount = new List<ushort>(this.SegCount);
            for (var i = 0; i < this.SegCount; i++)
            {
                this._endCount.Add(this.m_io.ReadU2be());
            }

            this._reservedPad = this.m_io.ReadU2be();
            this._startCount = new List<ushort>(this.SegCount);
            for (var i = 0; i < this.SegCount; i++)
            {
                this._startCount.Add(this.m_io.ReadU2be());
            }

            this._idDelta = new List<ushort>(this.SegCount);
            for (var i = 0; i < this.SegCount; i++)
            {
                this._idDelta.Add(this.m_io.ReadU2be());
            }

            this._idRangeOffset = new List<ushort>(this.SegCount);
            for (var i = 0; i < this.SegCount; i++)
            {
                this._idRangeOffset.Add(this.m_io.ReadU2be());
            }

            this._glyphIdArray = new List<ushort>();
            {
                var i = 0;
                while (!this.m_io.IsEof)
                {
                    this._glyphIdArray.Add(this.m_io.ReadU2be());
                    i++;
                }
            }
        }

        private bool f_segCount;
        private int _segCount;

        public int SegCount
        {
            get
            {
                if (this.f_segCount)
                    return this._segCount;

                this._segCount = this.SegCountX2 / 2;
                this.f_segCount = true;
                return this._segCount;
            }
        }

        private ushort _segCountX2;
        private ushort _searchRange;
        private ushort _entrySelector;
        private ushort _rangeShift;
        private List<ushort> _endCount;
        private ushort _reservedPad;
        private List<ushort> _startCount;
        private List<ushort> _idDelta;
        private List<ushort> _idRangeOffset;
        private List<ushort> _glyphIdArray;
        private Ttf m_root;
        private CMapSubtable m_parent;
        public ushort SegCountX2 => this._segCountX2;
        public ushort SearchRange => this._searchRange;
        public ushort EntrySelector => this._entrySelector;
        public ushort RangeShift => this._rangeShift;
        public List<ushort> EndCount => this._endCount;
        public ushort ReservedPad => this._reservedPad;
        public List<ushort> StartCount => this._startCount;
        public List<ushort> IdDelta => this._idDelta;
        public List<ushort> IdRangeOffset => this._idRangeOffset;
        public List<ushort> GlyphIdArray => this._glyphIdArray;
        public Ttf M_Root => this.m_root;
        public CMapSubtable M_Parent => this.m_parent;
    }
}

