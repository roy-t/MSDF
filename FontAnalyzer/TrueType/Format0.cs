// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using FontAnalyzer.TrueType.Kern;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Format0 : KaitaiStruct
    {
        public static Format0 FromFile(string fileName)
        {
            return new Format0(new KaitaiStream(fileName));
        }

        public Format0(KaitaiStream p__io, KernSubtable p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._pairCount = this.m_io.ReadU2be();
            this._searchRange = this.m_io.ReadU2be();
            this._entrySelector = this.m_io.ReadU2be();
            this._rangeShift = this.m_io.ReadU2be();
            this._kerningPairs = new List<KerningPair>(this.PairCount);
            for (var i = 0; i < this.PairCount; i++)
            {
                this._kerningPairs.Add(new KerningPair(this.m_io, this, this.m_root));
            }
        }
        public class KerningPair : KaitaiStruct
        {
            public static KerningPair FromFile(string fileName)
            {
                return new KerningPair(new KaitaiStream(fileName));
            }

            public KerningPair(KaitaiStream p__io, Format0 p__parent = null, Ttf p__root = null) : base(p__io)
            {
                this.m_parent = p__parent;
                this.m_root = p__root;
                _read();
            }
            private void _read()
            {
                this._left = this.m_io.ReadU2be();
                this._right = this.m_io.ReadU2be();
                this._value = this.m_io.ReadS2be();
            }
            private ushort _left;
            private ushort _right;
            private short _value;
            private Ttf m_root;
            private Format0 m_parent;
            public ushort Left => this._left;
            public ushort Right => this._right;
            public short Value => this._value;
            public Ttf M_Root => this.m_root;
            public Format0 M_Parent => this.m_parent;
        }
        private ushort _pairCount;
        private ushort _searchRange;
        private ushort _entrySelector;
        private ushort _rangeShift;
        private List<KerningPair> _kerningPairs;
        private Ttf m_root;
        private KernSubtable m_parent;
        public ushort PairCount => this._pairCount;
        public ushort SearchRange => this._searchRange;
        public ushort EntrySelector => this._entrySelector;
        public ushort RangeShift => this._rangeShift;
        public List<KerningPair> KerningPairs => this._kerningPairs;
        public Ttf M_Root => this.m_root;
        public KernSubtable M_Parent => this.m_parent;
    }
}
