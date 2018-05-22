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
        public FamilyKind FamilyType => this._familyType;
        public SerifStyle SerifStyle => this._serifStyle;
        public Weight Weight => this._weight;
        public Proportion Proportion => this._proportion;
        public Contrast Contrast => this._contrast;
        public StrokeVariation StrokeVariation => this._strokeVariation;
        public ArmStyle ArmStyle => this._armStyle;
        public LetterForm LetterForm => this._letterForm;
        public Midline Midline => this._midline;
        public XHeight XHeight => this._xHeight;
        public Ttf M_Root => this.m_root;
        public Os2 M_Parent => this.m_parent;
    }
}
