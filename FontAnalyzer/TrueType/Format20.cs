// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using System.Text;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Format20 : KaitaiStruct
    {
        public static Format20 FromFile(string fileName)
        {
            return new Format20(new KaitaiStream(fileName));
        }

        public Format20(KaitaiStream p__io, Post p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._numberOfGlyphs = this.m_io.ReadU2be();
            this._glyphNameIndex = new List<ushort>(this.NumberOfGlyphs);
            for (var i = 0; i < this.NumberOfGlyphs; i++)
            {
                this._glyphNameIndex.Add(this.m_io.ReadU2be());
            }
            this._glyphNames = new List<PascalString>();
            {
                var i = 0;
                PascalString M_;
                do
                {
                    M_ = new PascalString(this.m_io, this, this.m_root);
                    this._glyphNames.Add(M_);
                    i++;
                } while (!(M_.Length == 0));
            }
        }
        public class PascalString : KaitaiStruct
        {
            public static PascalString FromFile(string fileName)
            {
                return new PascalString(new KaitaiStream(fileName));
            }

            public PascalString(KaitaiStream p__io, Format20 p__parent = null, Ttf p__root = null) : base(p__io)
            {
                this.m_parent = p__parent;
                this.m_root = p__root;
                _read();
            }
            private void _read()
            {
                this._length = this.m_io.ReadU1();
                if (this.Length != 0)
                {
                    this._value = Encoding.GetEncoding("ascii").GetString(this.m_io.ReadBytes(this.Length));
                }
            }
            private byte _length;
            private string _value;
            private Ttf m_root;
            private Format20 m_parent;
            public byte Length { get { return this._length; } }
            public string Value { get { return this._value; } }
            public Ttf M_Root { get { return this.m_root; } }
            public Format20 M_Parent { get { return this.m_parent; } }
        }
        private ushort _numberOfGlyphs;
        private List<ushort> _glyphNameIndex;
        private List<PascalString> _glyphNames;
        private Ttf m_root;
        private Post m_parent;
        public ushort NumberOfGlyphs { get { return this._numberOfGlyphs; } }
        public List<ushort> GlyphNameIndex { get { return this._glyphNameIndex; } }
        public List<PascalString> GlyphNames { get { return this._glyphNames; } }
        public Ttf M_Root { get { return this.m_root; } }
        public Post M_Parent { get { return this.m_parent; } }
    }
}
