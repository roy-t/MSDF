// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType.Kern
{
    public class Kern : KaitaiStruct
    {
        public static Kern FromFile(string fileName)
        {
            return new Kern(new KaitaiStream(fileName));
        }

        public Kern(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._version = this.m_io.ReadU2be();
            this._subtableCount = this.m_io.ReadU2be();
            this._subtables = new List<KernSubtable>(this.SubtableCount);
            for (var i = 0; i < this.SubtableCount; i++)
            {
                this._subtables.Add(new KernSubtable(this.m_io, this, this.m_root));
            }
        }
        
        private ushort _version;
        private ushort _subtableCount;
        private List<KernSubtable> _subtables;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort Version => this._version;
        public ushort SubtableCount => this._subtableCount;
        public List<KernSubtable> Subtables => this._subtables;
        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
