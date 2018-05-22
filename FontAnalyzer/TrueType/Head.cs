// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Head : KaitaiStruct
    {
        public static Head FromFile(string fileName)
        {
            return new Head(new KaitaiStream(fileName));
        }


      
        public Head(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._version = new Fixed(this.m_io, this, this.m_root);
            this._fontRevision = new Fixed(this.m_io, this, this.m_root);
            this._checksumAdjustment = this.m_io.ReadU4be();
            this._magicNumber = this.m_io.EnsureFixedContents(new byte[] { 95, 15, 60, 245 });
            this._flags = ((Flags)this.m_io.ReadU2be());
            this._unitsPerEm = this.m_io.ReadU2be();
            this._created = this.m_io.ReadU8be();
            this._modified = this.m_io.ReadU8be();
            this._xMin = this.m_io.ReadS2be();
            this._yMin = this.m_io.ReadS2be();
            this._xMax = this.m_io.ReadS2be();
            this._yMax = this.m_io.ReadS2be();
            this._macStyle = this.m_io.ReadU2be();
            this._lowestRecPpem = this.m_io.ReadU2be();
            this._fontDirectionHint = ((FontDirectionHint)this.m_io.ReadS2be());
            this._indexToLocFormat = this.m_io.ReadS2be();
            this._glyphDataFormat = this.m_io.ReadS2be();
        }
        private Fixed _version;
        private Fixed _fontRevision;
        private uint _checksumAdjustment;
        private byte[] _magicNumber;
        private Flags _flags;
        private ushort _unitsPerEm;
        private ulong _created;
        private ulong _modified;
        private short _xMin;
        private short _yMin;
        private short _xMax;
        private short _yMax;
        private ushort _macStyle;
        private ushort _lowestRecPpem;
        private FontDirectionHint _fontDirectionHint;
        private short _indexToLocFormat;
        private short _glyphDataFormat;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public Fixed Version => this._version;
        public Fixed FontRevision => this._fontRevision;
        public uint ChecksumAdjustment => this._checksumAdjustment;
        public byte[] MagicNumber => this._magicNumber;
        public Flags Flags => this._flags;
        public ushort UnitsPerEm => this._unitsPerEm;
        public ulong Created => this._created;
        public ulong Modified => this._modified;
        public short XMin => this._xMin;
        public short YMin => this._yMin;
        public short XMax => this._xMax;
        public short YMax => this._yMax;
        public ushort MacStyle => this._macStyle;
        public ushort LowestRecPpem => this._lowestRecPpem;
        public FontDirectionHint FontDirectionHint => this._fontDirectionHint;
        public short IndexToLocFormat => this._indexToLocFormat;
        public short GlyphDataFormat => this._glyphDataFormat;
        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
