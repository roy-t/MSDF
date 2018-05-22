// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Maxp : KaitaiStruct
    {
        public static Maxp FromFile(string fileName)
        {
            return new Maxp(new KaitaiStream(fileName));
        }

        public Maxp(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._tableVersionNumber = new Fixed(this.m_io, this, this.m_root);
            this._numGlyphs = this.m_io.ReadU2be();
            this._maxPoints = this.m_io.ReadU2be();
            this._maxContours = this.m_io.ReadU2be();
            this._maxCompositePoints = this.m_io.ReadU2be();
            this._maxCompositeContours = this.m_io.ReadU2be();
            this._maxZones = this.m_io.ReadU2be();
            this._maxTwilightPoints = this.m_io.ReadU2be();
            this._maxStorage = this.m_io.ReadU2be();
            this._maxFunctionDefs = this.m_io.ReadU2be();
            this._maxInstructionDefs = this.m_io.ReadU2be();
            this._maxStackElements = this.m_io.ReadU2be();
            this._maxSizeOfInstructions = this.m_io.ReadU2be();
            this._maxComponentElements = this.m_io.ReadU2be();
            this._maxComponentDepth = this.m_io.ReadU2be();
        }
        private Fixed _tableVersionNumber;
        private ushort _numGlyphs;
        private ushort _maxPoints;
        private ushort _maxContours;
        private ushort _maxCompositePoints;
        private ushort _maxCompositeContours;
        private ushort _maxZones;
        private ushort _maxTwilightPoints;
        private ushort _maxStorage;
        private ushort _maxFunctionDefs;
        private ushort _maxInstructionDefs;
        private ushort _maxStackElements;
        private ushort _maxSizeOfInstructions;
        private ushort _maxComponentElements;
        private ushort _maxComponentDepth;
        private Ttf m_root;
        private DirTableEntry m_parent;

        /// <summary>
        /// 0x00010000 for version 1.0.
        /// </summary>
        public Fixed TableVersionNumber => this._tableVersionNumber;

        /// <summary>
        /// The number of glyphs in the font.
        /// </summary>
        public ushort NumGlyphs => this._numGlyphs;

        /// <summary>
        /// Maximum points in a non-composite glyph.
        /// </summary>
        public ushort MaxPoints => this._maxPoints;

        /// <summary>
        /// Maximum contours in a non-composite glyph.
        /// </summary>
        public ushort MaxContours => this._maxContours;

        /// <summary>
        /// Maximum points in a composite glyph.
        /// </summary>
        public ushort MaxCompositePoints => this._maxCompositePoints;

        /// <summary>
        /// Maximum contours in a composite glyph.
        /// </summary>
        public ushort MaxCompositeContours => this._maxCompositeContours;

        /// <summary>
        /// 1 if instructions do not use the twilight zone (Z0), or 2 if instructions do use Z0; should be set to 2 in most cases.
        /// </summary>
        public ushort MaxZones => this._maxZones;

        /// <summary>
        /// Maximum points used in Z0.
        /// </summary>
        public ushort MaxTwilightPoints => this._maxTwilightPoints;

        /// <summary>
        /// Number of Storage Area locations.
        /// </summary>
        public ushort MaxStorage => this._maxStorage;

        /// <summary>
        /// Number of FDEFs.
        /// </summary>
        public ushort MaxFunctionDefs => this._maxFunctionDefs;

        /// <summary>
        /// Number of IDEFs.
        /// </summary>
        public ushort MaxInstructionDefs => this._maxInstructionDefs;

        /// <summary>
        /// Maximum stack depth.
        /// </summary>
        public ushort MaxStackElements => this._maxStackElements;

        /// <summary>
        /// Maximum byte count for glyph instructions.
        /// </summary>
        public ushort MaxSizeOfInstructions => this._maxSizeOfInstructions;

        /// <summary>
        /// Maximum number of components referenced at &quot;top level&quot; for any composite glyph.
        /// </summary>
        public ushort MaxComponentElements => this._maxComponentElements;

        /// <summary>
        /// Maximum levels of recursion; 1 for simple components.
        /// </summary>
        public ushort MaxComponentDepth => this._maxComponentDepth;

        public Ttf M_Root => this.m_root;
        public DirTableEntry M_Parent => this.m_parent;
    }
}
