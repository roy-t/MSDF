// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{
    public class HighByteMappingThroughTable : KaitaiStruct
    {
        public static HighByteMappingThroughTable FromFile(string fileName)
        {
            return new HighByteMappingThroughTable(new KaitaiStream(fileName));
        }

        public HighByteMappingThroughTable(
            KaitaiStream p__io,
            CMapSubtable p__parent = null,
            Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }

        private void _read()
        {
            this._subHeaderKeys = new List<ushort>(256);
            for (var i = 0; i < 256; i++)
            {
                this._subHeaderKeys.Add(this.m_io.ReadU2be());
            }
        }

        private List<ushort> _subHeaderKeys;
        private Ttf m_root;
        private CMapSubtable m_parent;
        public List<ushort> SubHeaderKeys => this._subHeaderKeys;
        public Ttf M_Root => this.m_root;
        public CMapSubtable M_Parent => this.m_parent;
    }
}

