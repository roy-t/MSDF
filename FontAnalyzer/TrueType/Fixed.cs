// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Fixed : KaitaiStruct
    {
        public static Fixed FromFile(string fileName)
        {
            return new Fixed(new KaitaiStream(fileName));
        }

        public Fixed(KaitaiStream p__io, KaitaiStruct p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._major = this.m_io.ReadU2be();
            this._minor = this.m_io.ReadU2be();
        }
        private ushort _major;
        private ushort _minor;
        private Ttf m_root;
        private KaitaiStruct m_parent;
        public ushort Major { get { return this._major; } }
        public ushort Minor { get { return this._minor; } }
        public Ttf M_Root { get { return this.m_root; } }
        public KaitaiStruct M_Parent { get { return this.m_parent; } }
    }
}
