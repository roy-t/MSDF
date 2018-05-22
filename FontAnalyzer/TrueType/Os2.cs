// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using System.Text;
using Kaitai;

namespace FontAnalyzer.TrueType
{
    /// <summary>
    /// The OS/2 table consists of a set of metrics that are required by Windows and OS/2.
    /// </summary>
    public class Os2 : KaitaiStruct
    {
        public static Os2 FromFile(string fileName)
        {
            return new Os2(new KaitaiStream(fileName));
        }


       
        public Os2(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._version = this.m_io.ReadU2be();
            this._xAvgCharWidth = this.m_io.ReadS2be();
            this._weightClass = ((WeightClass)this.m_io.ReadU2be());
            this._widthClass = ((WidthClass)this.m_io.ReadU2be());
            this._fsType = ((FsType)this.m_io.ReadS2be());
            this._ySubscriptXSize = this.m_io.ReadS2be();
            this._ySubscriptYSize = this.m_io.ReadS2be();
            this._ySubscriptXOffset = this.m_io.ReadS2be();
            this._ySubscriptYOffset = this.m_io.ReadS2be();
            this._ySuperscriptXSize = this.m_io.ReadS2be();
            this._ySuperscriptYSize = this.m_io.ReadS2be();
            this._ySuperscriptXOffset = this.m_io.ReadS2be();
            this._ySuperscriptYOffset = this.m_io.ReadS2be();
            this._yStrikeoutSize = this.m_io.ReadS2be();
            this._yStrikeoutPosition = this.m_io.ReadS2be();
            this._sFamilyClass = this.m_io.ReadS2be();
            this._panose = new Panose(this.m_io, this, this.m_root);
            this._unicodeRange = new UnicodeRange(this.m_io, this, this.m_root);
            this._achVendId = Encoding.GetEncoding("ascii").GetString(this.m_io.ReadBytes(4));
            this._selection = ((FsSelection)this.m_io.ReadU2be());
            this._firstCharIndex = this.m_io.ReadU2be();
            this._lastCharIndex = this.m_io.ReadU2be();
            this._typoAscender = this.m_io.ReadS2be();
            this._typoDescender = this.m_io.ReadS2be();
            this._typoLineGap = this.m_io.ReadS2be();
            this._winAscent = this.m_io.ReadU2be();
            this._winDescent = this.m_io.ReadU2be();
            this._codePageRange = new CodePageRange(this.m_io, this, this.m_root);
        }
       
        private ushort _version;
        private short _xAvgCharWidth;
        private WeightClass _weightClass;
        private WidthClass _widthClass;
        private FsType _fsType;
        private short _ySubscriptXSize;
        private short _ySubscriptYSize;
        private short _ySubscriptXOffset;
        private short _ySubscriptYOffset;
        private short _ySuperscriptXSize;
        private short _ySuperscriptYSize;
        private short _ySuperscriptXOffset;
        private short _ySuperscriptYOffset;
        private short _yStrikeoutSize;
        private short _yStrikeoutPosition;
        private short _sFamilyClass;
        private Panose _panose;
        private UnicodeRange _unicodeRange;
        private string _achVendId;
        private FsSelection _selection;
        private ushort _firstCharIndex;
        private ushort _lastCharIndex;
        private short _typoAscender;
        private short _typoDescender;
        private short _typoLineGap;
        private ushort _winAscent;
        private ushort _winDescent;
        private CodePageRange _codePageRange;
        private Ttf m_root;
        private DirTableEntry m_parent;

        /// <summary>
        /// The version number for this OS/2 table.
        /// </summary>
        public ushort Version { get { return this._version; } }

        /// <summary>
        /// The Average Character Width parameter specifies the arithmetic average of the escapement (width) of all of the 26 lowercase letters a through z of the Latin alphabet and the space character. If any of the 26 lowercase letters are not present, this parameter should equal the weighted average of all glyphs in the font. For non-UGL (platform 3, encoding 0) fonts, use the unweighted average.
        /// </summary>
        public short XAvgCharWidth { get { return this._xAvgCharWidth; } }

        /// <summary>
        /// Indicates the visual weight (degree of blackness or thickness of strokes) of the characters in the font.
        /// </summary>
        public WeightClass WeightClass { get { return this._weightClass; } }

        /// <summary>
        /// Indicates a relative change from the normal aspect ratio (width to height ratio) as specified by a font designer for the glyphs in a font.
        /// </summary>
        public WidthClass WidthClass { get { return this._widthClass; } }

        /// <summary>
        /// Indicates font embedding licensing rights for the font. Embeddable fonts may be stored in a document. When a document with embedded fonts is opened on a system that does not have the font installed (the remote system), the embedded font may be loaded for temporary (and in some cases, permanent) use on that system by an embedding-aware application. Embedding licensing rights are granted by the vendor of the font.
        /// </summary>
        public FsType FsType { get { return this._fsType; } }

        /// <summary>
        /// The recommended horizontal size in font design units for subscripts for this font.
        /// </summary>
        public short YSubscriptXSize { get { return this._ySubscriptXSize; } }

        /// <summary>
        /// The recommended vertical size in font design units for subscripts for this font.
        /// </summary>
        public short YSubscriptYSize { get { return this._ySubscriptYSize; } }

        /// <summary>
        /// The recommended horizontal offset in font design untis for subscripts for this font.
        /// </summary>
        public short YSubscriptXOffset { get { return this._ySubscriptXOffset; } }

        /// <summary>
        /// The recommended vertical offset in font design units from the baseline for subscripts for this font.
        /// </summary>
        public short YSubscriptYOffset { get { return this._ySubscriptYOffset; } }

        /// <summary>
        /// The recommended horizontal size in font design units for superscripts for this font.
        /// </summary>
        public short YSuperscriptXSize { get { return this._ySuperscriptXSize; } }

        /// <summary>
        /// The recommended vertical size in font design units for superscripts for this font.
        /// </summary>
        public short YSuperscriptYSize { get { return this._ySuperscriptYSize; } }

        /// <summary>
        /// The recommended horizontal offset in font design units for superscripts for this font.
        /// </summary>
        public short YSuperscriptXOffset { get { return this._ySuperscriptXOffset; } }

        /// <summary>
        /// The recommended vertical offset in font design units from the baseline for superscripts for this font.
        /// </summary>
        public short YSuperscriptYOffset { get { return this._ySuperscriptYOffset; } }

        /// <summary>
        /// Width of the strikeout stroke in font design units.
        /// </summary>
        public short YStrikeoutSize { get { return this._yStrikeoutSize; } }

        /// <summary>
        /// The position of the strikeout stroke relative to the baseline in font design units.
        /// </summary>
        public short YStrikeoutPosition { get { return this._yStrikeoutPosition; } }

        /// <summary>
        /// This parameter is a classification of font-family design.
        /// </summary>
        public short SFamilyClass { get { return this._sFamilyClass; } }
        public Panose Panose { get { return this._panose; } }
        public UnicodeRange UnicodeRange { get { return this._unicodeRange; } }

        /// <summary>
        /// The four character identifier for the vendor of the given type face.
        /// </summary>
        public string AchVendId { get { return this._achVendId; } }

        /// <summary>
        /// Contains information concerning the nature of the font patterns
        /// </summary>
        public FsSelection Selection { get { return this._selection; } }

        /// <summary>
        /// The minimum Unicode index (character code) in this font, according to the cmap subtable for platform ID 3 and encoding ID 0 or 1.
        /// </summary>
        public ushort FirstCharIndex { get { return this._firstCharIndex; } }

        /// <summary>
        /// The maximum Unicode index (character code) in this font, according to the cmap subtable for platform ID 3 and encoding ID 0 or 1.
        /// </summary>
        public ushort LastCharIndex { get { return this._lastCharIndex; } }

        /// <summary>
        /// The typographic ascender for this font.
        /// </summary>
        public short TypoAscender { get { return this._typoAscender; } }

        /// <summary>
        /// The typographic descender for this font.
        /// </summary>
        public short TypoDescender { get { return this._typoDescender; } }

        /// <summary>
        /// The typographic line gap for this font.
        /// </summary>
        public short TypoLineGap { get { return this._typoLineGap; } }

        /// <summary>
        /// The ascender metric for Windows.
        /// </summary>
        public ushort WinAscent { get { return this._winAscent; } }

        /// <summary>
        /// The descender metric for Windows.
        /// </summary>
        public ushort WinDescent { get { return this._winDescent; } }

        /// <summary>
        /// This field is used to specify the code pages encompassed by the font file in the `cmap` subtable for platform 3, encoding ID 1 (Microsoft platform).
        /// </summary>
        public CodePageRange CodePageRange { get { return this._codePageRange; } }
        public Ttf M_Root { get { return this.m_root; } }
        public DirTableEntry M_Parent { get { return this.m_parent; } }
    }
}
