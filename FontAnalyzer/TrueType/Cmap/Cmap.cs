// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{
    /// <summary>
    /// cmap - Character To Glyph Index Mapping Table This table defines the mapping of character codes to the glyph index values used in the font.
    /// </summary>
    public class Cmap : KaitaiStruct
    {
        public static Cmap FromFile(string fileName)
        {
            return new Cmap(new KaitaiStream(fileName));
        }

        public Cmap(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }

        private void _read()
        {
            this._versionNumber = this.m_io.ReadU2be();
            this._numberOfEncodingTables = this.m_io.ReadU2be();
            this._tables = new List<CMapSubtableHeader>(this.NumberOfEncodingTables);
            for (var i = 0; i < this.NumberOfEncodingTables; i++)
            {
                this._tables.Add(new CMapSubtableHeader(this.m_io, this, this.m_root));
            }
        }

        private ushort _versionNumber;
        private ushort _numberOfEncodingTables;
        private List<CMapSubtableHeader> _tables;
        private Ttf m_root;
        private DirTableEntry m_parent;

        public ushort VersionNumber => this._versionNumber;

        public ushort NumberOfEncodingTables => this._numberOfEncodingTables;

        public List<CMapSubtableHeader> Tables => this._tables;

        public Ttf M_Root => this.m_root;

        public DirTableEntry M_Parent => this.m_parent;
    }
}
