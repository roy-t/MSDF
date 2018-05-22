// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using System.Text;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    /// <summary>
    /// Name table is meant to include human-readable string metadata
    /// that describes font: name of the font, its styles, copyright &amp;
    /// trademark notices, vendor and designer info, etc.
    /// 
    /// The table includes a list of &quot;name records&quot;, each of which
    /// corresponds to a single metadata entry.
    /// </summary>
    /// <remarks>
    /// Reference: <a href="https://developer.apple.com/fonts/TrueType-Reference-Manual/RM06/Chap6name.html">Source</a>
    /// </remarks>
    public class Name : KaitaiStruct
    {
        public static Name FromFile(string fileName)
        {
            return new Name(new KaitaiStream(fileName));
        }


        public enum Platforms
        {
            Unicode = 0,
            Macintosh = 1,
            Reserved2 = 2,
            Microsoft = 3
        }

        public enum Names
        {
            Copyright = 0,
            FontFamily = 1,
            FontSubfamily = 2,
            UniqueSubfamilyId = 3,
            FullFontName = 4,
            NameTableVersion = 5,
            PostscriptFontName = 6,
            Trademark = 7,
            Manufacturer = 8,
            Designer = 9,
            Description = 10,
            UrlVendor = 11,
            UrlDesigner = 12,
            License = 13,
            UrlLicense = 14,
            Reserved15 = 15,
            PreferredFamily = 16,
            PreferredSubfamily = 17,
            CompatibleFullName = 18,
            SampleText = 19
        }
        public Name(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._formatSelector = this.m_io.ReadU2be();
            this._numNameRecords = this.m_io.ReadU2be();
            this._ofsStrings = this.m_io.ReadU2be();
            this._nameRecords = new List<NameRecord>(this.NumNameRecords);
            for (var i = 0; i < this.NumNameRecords; i++)
            {
                this._nameRecords.Add(new NameRecord(this.m_io, this, this.m_root));
            }
        }
        public class NameRecord : KaitaiStruct
        {
            public static NameRecord FromFile(string fileName)
            {
                return new NameRecord(new KaitaiStream(fileName));
            }

            public NameRecord(KaitaiStream p__io, Name p__parent = null, Ttf p__root = null) : base(p__io)
            {
                this.m_parent = p__parent;
                this.m_root = p__root;
                this.f_asciiValue = false;
                this.f_unicodeValue = false;
                _read();
            }
            private void _read()
            {
                this._platformId = ((Platforms)this.m_io.ReadU2be());
                this._encodingId = this.m_io.ReadU2be();
                this._languageId = this.m_io.ReadU2be();
                this._nameId = ((Names)this.m_io.ReadU2be());
                this._lenStr = this.m_io.ReadU2be();
                this._ofsStr = this.m_io.ReadU2be();
            }
            private bool f_asciiValue;
            private string _asciiValue;
            public string AsciiValue
            {
                get
                {
                    if (this.f_asciiValue)
                        return this._asciiValue;
                    KaitaiStream io = this.M_Parent.M_Io;
                    long _pos = io.Pos;
                    io.Seek((this.M_Parent.OfsStrings + this.OfsStr));
                    this._asciiValue = Encoding.GetEncoding("ascii").GetString(io.ReadBytes(this.LenStr));
                    io.Seek(_pos);
                    this.f_asciiValue = true;
                    return this._asciiValue;
                }
            }
            private bool f_unicodeValue;
            private string _unicodeValue;
            public string UnicodeValue
            {
                get
                {
                    if (this.f_unicodeValue)
                        return this._unicodeValue;
                    KaitaiStream io = this.M_Parent.M_Io;
                    long _pos = io.Pos;
                    io.Seek((this.M_Parent.OfsStrings + this.OfsStr));
                    this._unicodeValue = Encoding.GetEncoding("utf-16be").GetString(io.ReadBytes(this.LenStr));
                    io.Seek(_pos);
                    this.f_unicodeValue = true;
                    return this._unicodeValue;
                }
            }
            private Platforms _platformId;
            private ushort _encodingId;
            private ushort _languageId;
            private Names _nameId;
            private ushort _lenStr;
            private ushort _ofsStr;
            private Ttf m_root;
            private Name m_parent;
            public Platforms PlatformId => this._platformId;
            public ushort EncodingId => this._encodingId;
            public ushort LanguageId => this._languageId;
            public Names NameId => this._nameId;
            public ushort LenStr => this._lenStr;
            public ushort OfsStr => this._ofsStr;
            public Ttf M_Root => this.m_root;
            public Name M_Parent => this.m_parent;
        }
        private ushort _formatSelector;
        private ushort _numNameRecords;
        private ushort _ofsStrings;
        private List<NameRecord> _nameRecords;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort FormatSelector => this._formatSelector;
        public ushort NumNameRecords => this._numNameRecords;
        public ushort OfsStrings => this._ofsStrings;
        public List<NameRecord> NameRecords => this._nameRecords;
        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
