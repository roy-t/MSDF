// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using System.Text;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class DirTableEntry : KaitaiStruct
    {
        public static DirTableEntry FromFile(string fileName)
        {
            return new DirTableEntry(new KaitaiStream(fileName));
        }

        public DirTableEntry(KaitaiStream p__io, Ttf p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            this.f_value = false;
            _read();
        }
        private void _read()
        {
            this._tag = Encoding.GetEncoding("ascii").GetString(this.m_io.ReadBytes(4));
            this._checksum = this.m_io.ReadU4be();
            this._offset = this.m_io.ReadU4be();
            this._length = this.m_io.ReadU4be();
        }
        private bool f_value;
        private object _value;
        public object Value
        {
            get
            {
                if (this.f_value)
                    return this._value;
                KaitaiStream io = this.M_Root.M_Io;
                long _pos = io.Pos;
                io.Seek(this.Offset);
                switch (this.Tag)
                {
                    case "head":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Head(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "cvt ":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Cvt(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "prep":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Prep(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "kern":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Kern.Kern(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "hhea":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Hhea(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "post":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Post(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "OS/2":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Os2(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "name":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Name(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "maxp":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Maxp(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "glyf":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Glyf(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "fpgm":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Fpgm(io___raw_value, this, this.m_root);
                        break;
                    }
                    case "cmap":
                    {
                        this.__raw_value = io.ReadBytes(this.Length);
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new Cmap.Cmap(io___raw_value, this, this.m_root);
                        break;
                    }
                    default:
                    {
                        this._value = io.ReadBytes(this.Length);
                        break;
                    }
                }
                io.Seek(_pos);
                this.f_value = true;
                return this._value;
            }
        }
        private string _tag;
        private uint _checksum;
        private uint _offset;
        private uint _length;
        private Ttf m_root;
        private Ttf m_parent;
        private byte[] __raw_value;
        public string Tag => this._tag;
        public uint Checksum => this._checksum;
        public uint Offset => this._offset;
        public uint Length => this._length;
        public Ttf M_Root => this.m_root;
        public Ttf M_Parent => this.m_parent;
        public byte[] M_RawValue => this.__raw_value;
    }
}
