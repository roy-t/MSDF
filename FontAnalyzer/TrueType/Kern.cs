// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType
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
            this._subtables = new List<Subtable>(this.SubtableCount);
            for (var i = 0; i < this.SubtableCount; i++)
            {
                this._subtables.Add(new Subtable(this.m_io, this, this.m_root));
            }
        }
        public class Subtable : KaitaiStruct
        {
            public static Subtable FromFile(string fileName)
            {
                return new Subtable(new KaitaiStream(fileName));
            }

            public Subtable(KaitaiStream p__io, Kern p__parent = null, Ttf p__root = null) : base(p__io)
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
            public ushort Version { get { return this._version; } }
            public ushort Length { get { return this._length; } }
            public byte Format { get { return this._format; } }
            public ulong Reserved { get { return this._reserved; } }
            public bool IsOverride { get { return this._isOverride; } }
            public bool IsCrossStream { get { return this._isCrossStream; } }
            public bool IsMinimum { get { return this._isMinimum; } }
            public bool IsHorizontal { get { return this._isHorizontal; } }
            public Format0 Format0 { get { return this._format0; } }
            public Ttf M_Root { get { return this.m_root; } }
            public Kern M_Parent { get { return this.m_parent; } }
        }
        private ushort _version;
        private ushort _subtableCount;
        private List<Subtable> _subtables;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort Version { get { return this._version; } }
        public ushort SubtableCount { get { return this._subtableCount; } }
        public List<Subtable> Subtables { get { return this._subtables; } }
        public Ttf M_Root { get { return this.m_root; } }
        public DirTableEntry M_Parent { get { return this.m_parent; } }
    }
}
