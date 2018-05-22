// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class Panose : KaitaiStruct
    {
        public static Panose FromFile(string fileName)
        {
            return new Panose(new KaitaiStream(fileName));
        }


      
        public Panose(KaitaiStream p__io, Os2 p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._familyType = ((FamilyKind)this.m_io.ReadU1());
            this._serifStyle = ((SerifStyle)this.m_io.ReadU1());
            this._weight = ((Weight)this.m_io.ReadU1());
            this._proportion = ((Proportion)this.m_io.ReadU1());
            this._contrast = ((Contrast)this.m_io.ReadU1());
            this._strokeVariation = ((StrokeVariation)this.m_io.ReadU1());
            this._armStyle = ((ArmStyle)this.m_io.ReadU1());
            this._letterForm = ((LetterForm)this.m_io.ReadU1());
            this._midline = ((Midline)this.m_io.ReadU1());
            this._xHeight = ((XHeight)this.m_io.ReadU1());
        }
        private FamilyKind _familyType;
        private SerifStyle _serifStyle;
        private Weight _weight;
        private Proportion _proportion;
        private Contrast _contrast;
        private StrokeVariation _strokeVariation;
        private ArmStyle _armStyle;
        private LetterForm _letterForm;
        private Midline _midline;
        private XHeight _xHeight;
        private Ttf m_root;
        private Os2 m_parent;
        public FamilyKind FamilyType { get { return this._familyType; } }
        public SerifStyle SerifStyle { get { return this._serifStyle; } }
        public Weight Weight { get { return this._weight; } }
        public Proportion Proportion { get { return this._proportion; } }
        public Contrast Contrast { get { return this._contrast; } }
        public StrokeVariation StrokeVariation { get { return this._strokeVariation; } }
        public ArmStyle ArmStyle { get { return this._armStyle; } }
        public LetterForm LetterForm { get { return this._letterForm; } }
        public Midline Midline { get { return this._midline; } }
        public XHeight XHeight { get { return this._xHeight; } }
        public Ttf M_Root { get { return this.m_root; } }
        public Os2 M_Parent { get { return this.m_parent; } }
    }
}
