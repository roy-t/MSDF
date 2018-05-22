using Kaitai;

namespace FontAnalyzer.TrueType.Kern
{
    public class KernSubtable : KaitaiStruct
    {
        public static KernSubtable FromFile(string fileName)
        {
            return new KernSubtable(new KaitaiStream(fileName));
        }

        public KernSubtable(KaitaiStream p__io, Kern p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._version = this.m_io.ReadU2be();
            this._length = this.m_io.ReadU2be();
            this._format = this.m_io.ReadU1();
            this._reserved = this.m_io.ReadBitsInt(4);
            this._isOverride = this.m_io.ReadBitsInt(1) != 0;
            this._isCrossStream = this.m_io.ReadBitsInt(1) != 0;
            this._isMinimum = this.m_io.ReadBitsInt(1) != 0;
            this._isHorizontal = this.m_io.ReadBitsInt(1) != 0;
            this.m_io.AlignToByte();
            if (this.Format == 0)
            {
                this._format0 = new Format0(this.m_io, this, this.m_root);
            }
        }

        private ushort _version;
        private ushort _length;
        private byte _format;
        private ulong _reserved;
        private bool _isOverride;
        private bool _isCrossStream;
        private bool _isMinimum;
        private bool _isHorizontal;
        private Format0 _format0;
        private Ttf m_root;
        private Kern m_parent;
        public ushort Version => this._version;
        public ushort Length => this._length;
        public byte Format => this._format;
        public ulong Reserved => this._reserved;
        public bool IsOverride => this._isOverride;
        public bool IsCrossStream => this._isCrossStream;
        public bool IsMinimum => this._isMinimum;
        public bool IsHorizontal => this._isHorizontal;
        public Format0 Format0 => this._format0;
        public Ttf M_Root => this.m_root;
        public Kern M_Parent => this.m_parent;
    }
}