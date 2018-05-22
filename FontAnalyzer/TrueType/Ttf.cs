// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Ttf : KaitaiStruct
    {
        public static Ttf FromFile(string fileName)
        {
            return new Ttf(new KaitaiStream(fileName));
        }

        public Ttf(KaitaiStream p__io, KaitaiStruct p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            this._offsetTable = new OffsetTable(this.m_io, this, this.m_root);
            this._directoryTable = new List<DirTableEntry>(this.OffsetTable.NumTables);
            for (var i = 0; i < this.OffsetTable.NumTables; i++)
            {
                this._directoryTable.Add(new DirTableEntry(this.m_io, this, this.m_root));
            }
        }
      

       
        private OffsetTable _offsetTable;
        private List<DirTableEntry> _directoryTable;
        private Ttf m_root;
        private KaitaiStruct m_parent;
        public OffsetTable OffsetTable => this._offsetTable;
        public List<DirTableEntry> DirectoryTable => this._directoryTable;
        public Ttf M_Root => this.m_root;
        public KaitaiStruct M_Parent => this.m_parent;
    }
}
