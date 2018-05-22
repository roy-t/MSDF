// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class OffsetTable : KaitaiStruct
    {
        public static OffsetTable FromFile(string fileName)
        {
            return new OffsetTable(new KaitaiStream(fileName));
        }

        public OffsetTable(KaitaiStream p__io, Ttf p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._sfntVersion = new Fixed(this.m_io, this, this.m_root);
            this._numTables = this.m_io.ReadU2be();
            this._searchRange = this.m_io.ReadU2be();
            this._entrySelector = this.m_io.ReadU2be();
            this._rangeShift = this.m_io.ReadU2be();
        }
        private Fixed _sfntVersion;
        private ushort _numTables;
        private ushort _searchRange;
        private ushort _entrySelector;
        private ushort _rangeShift;
        private Ttf m_root;
        private Ttf m_parent;
        public Fixed SfntVersion { get { return this._sfntVersion; } }
        public ushort NumTables { get { return this._numTables; } }
        public ushort SearchRange { get { return this._searchRange; } }
        public ushort EntrySelector { get { return this._entrySelector; } }
        public ushort RangeShift { get { return this._rangeShift; } }
        public Ttf M_Root { get { return this.m_root; } }
        public Ttf M_Parent { get { return this.m_parent; } }
    }
}
