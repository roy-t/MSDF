// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using Kaitai;

namespace FontAnalyzer.TrueType
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
            this._tables = new List<SubtableHeader>(this.NumberOfEncodingTables);
            for (var i = 0; i < this.NumberOfEncodingTables; i++)
            {
                this._tables.Add(new SubtableHeader(this.m_io, this, this.m_root));
            }
        }
        public class SubtableHeader : KaitaiStruct
        {
            public static SubtableHeader FromFile(string fileName)
            {
                return new SubtableHeader(new KaitaiStream(fileName));
            }

            public SubtableHeader(KaitaiStream p__io, Cmap p__parent = null, Ttf p__root = null) : base(p__io)
            {
                this.m_parent = p__parent;
                this.m_root = p__root;
                this.f_table = false;
                _read();
            }
            private void _read()
            {
                this._platformId = this.m_io.ReadU2be();
                this._encodingId = this.m_io.ReadU2be();
                this._subtableOffset = this.m_io.ReadU4be();
            }
            private bool f_table;
            private Subtable _table;
            public Subtable Table
            {
                get
                {
                    if (this.f_table)
                        return this._table;
                    KaitaiStream io = this.M_Parent.M_Io;
                    long _pos = io.Pos;
                    io.Seek(this.SubtableOffset);
                    this._table = new Subtable(io, this, this.m_root);
                    io.Seek(_pos);
                    this.f_table = true;
                    return this._table;
                }
            }
            private ushort _platformId;
            private ushort _encodingId;
            private uint _subtableOffset;
            private Ttf m_root;
            private Cmap m_parent;
            public ushort PlatformId { get { return this._platformId; } }
            public ushort EncodingId { get { return this._encodingId; } }
            public uint SubtableOffset { get { return this._subtableOffset; } }
            public Ttf M_Root { get { return this.m_root; } }
            public Cmap M_Parent { get { return this.m_parent; } }
        }
        public class Subtable : KaitaiStruct
        {
            public static Subtable FromFile(string fileName)
            {
                return new Subtable(new KaitaiStream(fileName));
            }


            public enum SubtableFormat
            {
                ByteEncodingTable = 0,
                HighByteMappingThroughTable = 2,
                SegmentMappingToDeltaValues = 4,
                TrimmedTableMapping = 6
            }
            public Subtable(KaitaiStream p__io, SubtableHeader p__parent = null, Ttf p__root = null) : base(p__io)
            {
                this.m_parent = p__parent;
                this.m_root = p__root;
                _read();
            }
            private void _read()
            {
                this._format = ((SubtableFormat)this.m_io.ReadU2be());
                this._length = this.m_io.ReadU2be();
                this._version = this.m_io.ReadU2be();
                switch (this.Format)
                {
                    case SubtableFormat.ByteEncodingTable:
                    {
                        this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new ByteEncodingTable(io___raw_value, this, this.m_root);
                        break;
                    }
                    case SubtableFormat.HighByteMappingThroughTable:
                    {
                        this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new HighByteMappingThroughTable(io___raw_value, this, this.m_root);
                        break;
                    }
                    case SubtableFormat.TrimmedTableMapping:
                    {
                        this.__raw_value = this.m_io.ReadBytes((this.Length - 6));
                        var io___raw_value = new KaitaiStream(this.__raw_value);
                        this._value = new TrimmedTableMapping(io___raw_value, this, this.m_root);
                        break;
                    }
                    case SubtableFormat.SegmentMappingToDeltaValues:
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
            public class ByteEncodingTable : KaitaiStruct
            {
                public static ByteEncodingTable FromFile(string fileName)
                {
                    return new ByteEncodingTable(new KaitaiStream(fileName));
                }

                public ByteEncodingTable(KaitaiStream p__io, Subtable p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    this.m_parent = p__parent;
                    this.m_root = p__root;
                    _read();
                }
                private void _read()
                {
                    this._glyphIdArray = this.m_io.ReadBytes(256);
                }
                private byte[] _glyphIdArray;
                private Ttf m_root;
                private Subtable m_parent;
                public byte[] GlyphIdArray { get { return this._glyphIdArray; } }
                public Ttf M_Root { get { return this.m_root; } }
                public Subtable M_Parent { get { return this.m_parent; } }
            }
            public class HighByteMappingThroughTable : KaitaiStruct
            {
                public static HighByteMappingThroughTable FromFile(string fileName)
                {
                    return new HighByteMappingThroughTable(new KaitaiStream(fileName));
                }

                public HighByteMappingThroughTable(KaitaiStream p__io, Subtable p__parent = null, Ttf p__root = null) : base(p__io)
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
                private Subtable m_parent;
                public List<ushort> SubHeaderKeys { get { return this._subHeaderKeys; } }
                public Ttf M_Root { get { return this.m_root; } }
                public Subtable M_Parent { get { return this.m_parent; } }
            }
            public class SegmentMappingToDeltaValues : KaitaiStruct
            {
                public static SegmentMappingToDeltaValues FromFile(string fileName)
                {
                    return new SegmentMappingToDeltaValues(new KaitaiStream(fileName));
                }

                public SegmentMappingToDeltaValues(KaitaiStream p__io, Subtable p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    this.m_parent = p__parent;
                    this.m_root = p__root;
                    this.f_segCount = false;
                    _read();
                }
                private void _read()
                {
                    this._segCountX2 = this.m_io.ReadU2be();
                    this._searchRange = this.m_io.ReadU2be();
                    this._entrySelector = this.m_io.ReadU2be();
                    this._rangeShift = this.m_io.ReadU2be();
                    this._endCount = new List<ushort>(this.SegCount);
                    for (var i = 0; i < this.SegCount; i++)
                    {
                        this._endCount.Add(this.m_io.ReadU2be());
                    }
                    this._reservedPad = this.m_io.ReadU2be();
                    this._startCount = new List<ushort>(this.SegCount);
                    for (var i = 0; i < this.SegCount; i++)
                    {
                        this._startCount.Add(this.m_io.ReadU2be());
                    }
                    this._idDelta = new List<ushort>(this.SegCount);
                    for (var i = 0; i < this.SegCount; i++)
                    {
                        this._idDelta.Add(this.m_io.ReadU2be());
                    }
                    this._idRangeOffset = new List<ushort>(this.SegCount);
                    for (var i = 0; i < this.SegCount; i++)
                    {
                        this._idRangeOffset.Add(this.m_io.ReadU2be());
                    }
                    this._glyphIdArray = new List<ushort>();
                    {
                        var i = 0;
                        while (!this.m_io.IsEof)
                        {
                            this._glyphIdArray.Add(this.m_io.ReadU2be());
                            i++;
                        }
                    }
                }
                private bool f_segCount;
                private int _segCount;
                public int SegCount
                {
                    get
                    {
                        if (this.f_segCount)
                            return this._segCount;
                        this._segCount = this.SegCountX2 / 2;
                        this.f_segCount = true;
                        return this._segCount;
                    }
                }
                private ushort _segCountX2;
                private ushort _searchRange;
                private ushort _entrySelector;
                private ushort _rangeShift;
                private List<ushort> _endCount;
                private ushort _reservedPad;
                private List<ushort> _startCount;
                private List<ushort> _idDelta;
                private List<ushort> _idRangeOffset;
                private List<ushort> _glyphIdArray;
                private Ttf m_root;
                private Subtable m_parent;
                public ushort SegCountX2 { get { return this._segCountX2; } }
                public ushort SearchRange { get { return this._searchRange; } }
                public ushort EntrySelector { get { return this._entrySelector; } }
                public ushort RangeShift { get { return this._rangeShift; } }
                public List<ushort> EndCount { get { return this._endCount; } }
                public ushort ReservedPad { get { return this._reservedPad; } }
                public List<ushort> StartCount { get { return this._startCount; } }
                public List<ushort> IdDelta { get { return this._idDelta; } }
                public List<ushort> IdRangeOffset { get { return this._idRangeOffset; } }
                public List<ushort> GlyphIdArray { get { return this._glyphIdArray; } }
                public Ttf M_Root { get { return this.m_root; } }
                public Subtable M_Parent { get { return this.m_parent; } }
            }
            public class TrimmedTableMapping : KaitaiStruct
            {
                public static TrimmedTableMapping FromFile(string fileName)
                {
                    return new TrimmedTableMapping(new KaitaiStream(fileName));
                }

                public TrimmedTableMapping(KaitaiStream p__io, Subtable p__parent = null, Ttf p__root = null) : base(p__io)
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
                private Subtable m_parent;
                public ushort FirstCode { get { return this._firstCode; } }
                public ushort EntryCount { get { return this._entryCount; } }
                public List<ushort> GlyphIdArray { get { return this._glyphIdArray; } }
                public Ttf M_Root { get { return this.m_root; } }
                public Subtable M_Parent { get { return this.m_parent; } }
            }
            private SubtableFormat _format;
            private ushort _length;
            private ushort _version;
            private object _value;
            private Ttf m_root;
            private SubtableHeader m_parent;
            private byte[] __raw_value;
            public SubtableFormat Format { get { return this._format; } }
            public ushort Length { get { return this._length; } }
            public ushort Version { get { return this._version; } }
            public object Value { get { return this._value; } }
            public Ttf M_Root { get { return this.m_root; } }
            public SubtableHeader M_Parent { get { return this.m_parent; } }
            public byte[] M_RawValue { get { return this.__raw_value; } }
        }
        private ushort _versionNumber;
        private ushort _numberOfEncodingTables;
        private List<SubtableHeader> _tables;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort VersionNumber { get { return this._versionNumber; } }
        public ushort NumberOfEncodingTables { get { return this._numberOfEncodingTables; } }
        public List<SubtableHeader> Tables { get { return this._tables; } }
        public Ttf M_Root { get { return this.m_root; } }
        public DirTableEntry M_Parent { get { return this.m_parent; } }
    }
}
