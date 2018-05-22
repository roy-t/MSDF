using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{
    public class TrimmedTableMapping : KaitaiStruct
    {
        public static TrimmedTableMapping FromFile(string fileName)
        {
            return new TrimmedTableMapping(new KaitaiStream(fileName));
        }

        public TrimmedTableMapping(KaitaiStream p__io, CMapSubtable p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }

        private void _read()
        {
            this._firstCode = this.m_io.ReadU2be();
            this._entryCount = this.m_io.ReadU2be();
            this._glyphIdArray = new List<ushort>(this.EntryCount);
            for (var i = 0; i < this.EntryCount; i++)
            {
                this._glyphIdArray.Add(this.m_io.ReadU2be());
            }
        }

        private ushort _firstCode;
        private ushort _entryCount;
        private List<ushort> _glyphIdArray;
        private Ttf m_root;
        private CMapSubtable m_parent;
        public ushort FirstCode => this._firstCode;
        public ushort EntryCount => this._entryCount;
        public List<ushort> GlyphIdArray => this._glyphIdArray;
        public Ttf M_Root => this.m_root;
        public CMapSubtable M_Parent => this.m_parent;
    }
}