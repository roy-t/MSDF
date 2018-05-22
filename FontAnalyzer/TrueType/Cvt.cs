// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    /// <summary>
    /// cvt  - Control Value Table This table contains a list of values that can be referenced by instructions. They can be used, among other things, to control characteristics for different glyphs.
    /// </summary>
    public class Cvt : KaitaiStruct
    {
        public static Cvt FromFile(string fileName)
        {
            return new Cvt(new KaitaiStream(fileName));
        }

        public Cvt(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._fwords = new List<short>();
            {
                var i = 0;
                while (!this.m_io.IsEof)
                {
                    this._fwords.Add(this.m_io.ReadS2be());
                    i++;
                }
            }
        }
        private List<short> _fwords;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public List<short> Fwords => this._fwords;
        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
