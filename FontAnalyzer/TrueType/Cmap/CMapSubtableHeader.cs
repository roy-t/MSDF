// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{

    public class CMapSubtableHeader : KaitaiStruct
    {
        public static CMapSubtableHeader FromFile(string fileName)
        {
            return new CMapSubtableHeader(new KaitaiStream(fileName));
        }

        public CMapSubtableHeader(KaitaiStream p__io, Cmap p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            this.f_table = false;
            _read();
        }

        private void _read()
        {
            this._platformId = this.m_io.ReadU2be();
            this._encodingId = this.m_io.ReadU2be();
            this._subtableOffset = this.m_io.ReadU4be();

            var t = Table;
        }

        private bool f_table;
        private CMapSubtable _table;

        public CMapSubtable Table
        {
            get
            {
                if (this.f_table)
                    return this._table;

                KaitaiStream io = this.M_Parent.M_Io;
                long _pos = io.Pos;
                io.Seek(this.SubtableOffset);
                this._table = new CMapSubtable(io, this, this.m_root);
                io.Seek(_pos);
                this.f_table = true;
                return this._table;
            }
        }

        private ushort _platformId;
        private ushort _encodingId;
        private uint _subtableOffset;
        private Ttf m_root;
        private Cmap m_parent;
        public ushort PlatformId => this._platformId;
        public ushort EncodingId => this._encodingId;
        public uint SubtableOffset => this._subtableOffset;
        public Ttf M_Root => this.m_root;
        public Cmap M_Parent => this.m_parent;
    }
}

