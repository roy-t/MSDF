// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Prep : KaitaiStruct
    {
        public static Prep FromFile(string fileName)
        {
            return new Prep(new KaitaiStream(fileName));
        }

        public Prep(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._instructions = this.m_io.ReadBytesFull();
        }
        private byte[] _instructions;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public byte[] Instructions => this._instructions;
        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
