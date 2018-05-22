// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{
    public class ByteEncodingTable : KaitaiStruct
    {
        public static ByteEncodingTable FromFile(string fileName)
        {
            return new ByteEncodingTable(new KaitaiStream(fileName));
        }

        public ByteEncodingTable(KaitaiStream p__io, CMapSubtable p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }

        private void _read()
        {
            this._glyphIdArray = this.m_io.ReadBytes(256);
        }

        private byte[] _glyphIdArray;
        private Ttf m_root;
        private CMapSubtable m_parent;
        public byte[] GlyphIdArray => this._glyphIdArray;
        public Ttf M_Root => this.m_root;
        public CMapSubtable M_Parent => this.m_parent;
    }
}

