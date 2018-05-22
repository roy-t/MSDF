// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using System.Linq;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Glyf : KaitaiStruct
    {
        public static Glyf FromFile(string fileName)
        {
            return new Glyf(new KaitaiStream(fileName));
        }

        public Glyf(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._numberOfContours = this.m_io.ReadS2be();
            this._xMin = this.m_io.ReadS2be();
            this._yMin = this.m_io.ReadS2be();
            this._xMax = this.m_io.ReadS2be();
            this._yMax = this.m_io.ReadS2be();
            if (this.NumberOfContours > 0)
            {
                this._value = new SimpleGlyph(this.m_io, this, this.m_root);
            }
        }
        public class SimpleGlyph : KaitaiStruct
        {
            public static SimpleGlyph FromFile(string fileName)
            {
                return new SimpleGlyph(new KaitaiStream(fileName));
            }

            public SimpleGlyph(KaitaiStream p__io, Glyf p__parent = null, Ttf p__root = null) : base(p__io)
            {
                this.m_parent = p__parent;
                this.m_root = p__root;
                this.f_pointCount = false;
                _read();
            }
            private void _read()
            {
                this._endPtsOfContours = new List<ushort>(this.M_Parent.NumberOfContours);
                for (var i = 0; i < this.M_Parent.NumberOfContours; i++)
                {
                    this._endPtsOfContours.Add(this.m_io.ReadU2be());
                }
                this._instructionLength = this.m_io.ReadU2be();
                this._instructions = this.m_io.ReadBytes(this.InstructionLength);
                this._flags = new List<Flag>(this.PointCount);
                for (var i = 0; i < this.PointCount; i++)
                {
                    this._flags.Add(new Flag(this.m_io, this, this.m_root));
                }
            }
            public class Flag : KaitaiStruct
            {
                public static Flag FromFile(string fileName)
                {
                    return new Flag(new KaitaiStream(fileName));
                }

                public Flag(KaitaiStream p__io, SimpleGlyph p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    this.m_parent = p__parent;
                    this.m_root = p__root;
                    _read();
                }
                private void _read()
                {
                    this._reserved = this.m_io.ReadBitsInt(2);
                    this._yIsSame = this.m_io.ReadBitsInt(1) != 0;
                    this._xIsSame = this.m_io.ReadBitsInt(1) != 0;
                    this._repeat = this.m_io.ReadBitsInt(1) != 0;
                    this._yShortVector = this.m_io.ReadBitsInt(1) != 0;
                    this._xShortVector = this.m_io.ReadBitsInt(1) != 0;
                    this._onCurve = this.m_io.ReadBitsInt(1) != 0;
                    this.m_io.AlignToByte();
                    if (this.Repeat)
                    {
                        this._repeatValue = this.m_io.ReadU1();
                    }
                }
                private ulong _reserved;
                private bool _yIsSame;
                private bool _xIsSame;
                private bool _repeat;
                private bool _yShortVector;
                private bool _xShortVector;
                private bool _onCurve;
                private byte? _repeatValue;
                private Ttf m_root;
                private SimpleGlyph m_parent;
                public ulong Reserved { get { return this._reserved; } }
                public bool YIsSame { get { return this._yIsSame; } }
                public bool XIsSame { get { return this._xIsSame; } }
                public bool Repeat { get { return this._repeat; } }
                public bool YShortVector { get { return this._yShortVector; } }
                public bool XShortVector { get { return this._xShortVector; } }
                public bool OnCurve { get { return this._onCurve; } }
                public byte? RepeatValue { get { return this._repeatValue; } }
                public Ttf M_Root { get { return this.m_root; } }
                public SimpleGlyph M_Parent { get { return this.m_parent; } }
            }
            private bool f_pointCount;
            private int _pointCount;
            public int PointCount
            {
                get
                {
                    if (this.f_pointCount)
                        return this._pointCount;
                    this._pointCount = this.EndPtsOfContours.Max() + 1;
                    this.f_pointCount = true;
                    return this._pointCount;
                }
            }
            private List<ushort> _endPtsOfContours;
            private ushort _instructionLength;
            private byte[] _instructions;
            private List<Flag> _flags;
            private Ttf m_root;
            private Glyf m_parent;
            public List<ushort> EndPtsOfContours { get { return this._endPtsOfContours; } }
            public ushort InstructionLength { get { return this._instructionLength; } }
            public byte[] Instructions { get { return this._instructions; } }
            public List<Flag> Flags { get { return this._flags; } }
            public Ttf M_Root { get { return this.m_root; } }
            public Glyf M_Parent { get { return this.m_parent; } }
        }
        private short _numberOfContours;
        private short _xMin;
        private short _yMin;
        private short _xMax;
        private short _yMax;
        private SimpleGlyph _value;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public short NumberOfContours { get { return this._numberOfContours; } }
        public short XMin { get { return this._xMin; } }
        public short YMin { get { return this._yMin; } }
        public short XMax { get { return this._xMax; } }
        public short YMax { get { return this._yMax; } }
        public SimpleGlyph Value { get { return this._value; } }
        public Ttf M_Root { get { return this.m_root; } }
        public DirTableEntry M_Parent { get { return this.m_parent; } }
    }
}
