// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace FontAnalyzer.TrueType.Cmap
{

    public class CMapSubtable : KaitaiStruct
    {
        public static CMapSubtable FromFile(string fileName)
        {
            return new CMapSubtable(new KaitaiStream(fileName));
        }

        public CMapSubtable(KaitaiStream p__io, CMapSubtableHeader p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }

        private void _read()
        {
            this._format = ((CMapSubtableFormat) this.m_io.ReadU2be());
            this._length = this.m_io.ReadU2be();
            this._version = this.m_io.ReadU2be();
            switch (this.Format)
            {
                case CMapSubtableFormat.ByteEncodingTable:
                {
                    this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                    var io___raw_value = new KaitaiStream(this.__raw_value);
                    this._value = new ByteEncodingTable(io___raw_value, this, this.m_root);
                    break;
                }
                case CMapSubtableFormat.HighByteMappingThroughTable:
                {
                    this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                    var io___raw_value = new KaitaiStream(this.__raw_value);
                    this._value = new HighByteMappingThroughTable(io___raw_value, this, this.m_root);
                    break;
                }
                case CMapSubtableFormat.TrimmedTableMapping:
                {
                    this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                    var io___raw_value = new KaitaiStream(this.__raw_value);
                    this._value = new TrimmedTableMapping(io___raw_value, this, this.m_root);
                    break;
                }
                case CMapSubtableFormat.SegmentMappingToDeltaValues:
                {
                    this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                    var io___raw_value = new KaitaiStream(this.__raw_value);
                    this._value = new SegmentMappingToDeltaValues(io___raw_value, this, this.m_root);
                    break;
                }
                default:
                {
                    this._value = this.m_io.ReadBytes((this.Length - 6));
                    break;
                }
            }
        }

        private CMapSubtableFormat _format;
        private ushort _length;
        private ushort _version;
        private object _value;
        private Ttf m_root;
        private CMapSubtableHeader m_parent;
        private byte[] __raw_value;
        public CMapSubtableFormat Format => this._format;
        public ushort Length => this._length;
        public ushort Version => this._version;
        public object Value => this._value;
        public Ttf M_Root => this.m_root;
        public CMapSubtableHeader M_Parent => this.m_parent;
        public byte[] M_RawValue => this.__raw_value;
    }
}

