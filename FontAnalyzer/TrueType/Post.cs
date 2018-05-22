// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Post : KaitaiStruct
    {
        public static Post FromFile(string fileName)
        {
            return new Post(new KaitaiStream(fileName));
        }

        public Post(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._format = new Fixed(this.m_io, this, this.m_root);
            this._italicAngle = new Fixed(this.m_io, this, this.m_root);
            this._underlinePosition = this.m_io.ReadS2be();
            this._underlineThichness = this.m_io.ReadS2be();
            this._isFixedPitch = this.m_io.ReadU4be();
            this._minMemType42 = this.m_io.ReadU4be();
            this._maxMemType42 = this.m_io.ReadU4be();
            this._minMemType1 = this.m_io.ReadU4be();
            this._maxMemType1 = this.m_io.ReadU4be();
            if (((this.Format.Major == 2) && (this.Format.Minor == 0)))
            {
                this._format20 = new Format20(this.m_io, this, this.m_root);
            }
        }
        
        private Fixed _format;
        private Fixed _italicAngle;
        private short _underlinePosition;
        private short _underlineThichness;
        private uint _isFixedPitch;
        private uint _minMemType42;
        private uint _maxMemType42;
        private uint _minMemType1;
        private uint _maxMemType1;
        private Format20 _format20;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public Fixed Format => this._format;
        public Fixed ItalicAngle => this._italicAngle;
        public short UnderlinePosition => this._underlinePosition;
        public short UnderlineThichness => this._underlineThichness;
        public uint IsFixedPitch => this._isFixedPitch;
        public uint MinMemType42 => this._minMemType42;
        public uint MaxMemType42 => this._maxMemType42;
        public uint MinMemType1 => this._minMemType1;
        public uint MaxMemType1 => this._maxMemType1;
        public Format20 Format20 => this._format20;
        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
