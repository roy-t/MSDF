// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using System.Collections.Generic;
using System.Linq;

namespace Kaitai
{

    public enum Weight
    {
        Any = 0,
        NoFit = 1,
        VeryLight = 2,
        Light = 3,
        Thin = 4,
        Book = 5,
        Medium = 6,
        Demi = 7,
        Bold = 8,
        Heavy = 9,
        Black = 10,
        Nord = 11,
    }

    public enum Proportion
    {
        Any = 0,
        NoFit = 1,
        OldStyle = 2,
        Modern = 3,
        EvenWidth = 4,
        Expanded = 5,
        Condensed = 6,
        VeryExpanded = 7,
        VeryCondensed = 8,
        Monospaced = 9,
    }

    public enum FamilyKind
    {
        Any = 0,
        NoFit = 1,
        TextAndDisplay = 2,
        Script = 3,
        Decorative = 4,
        Pictorial = 5,
    }

    public enum LetterForm
    {
        Any = 0,
        NoFit = 1,
        NormalContact = 2,
        NormalWeighted = 3,
        NormalBoxed = 4,
        NormalFlattened = 5,
        NormalRounded = 6,
        NormalOffCenter = 7,
        NormalSquare = 8,
        ObliqueContact = 9,
        ObliqueWeighted = 10,
        ObliqueBoxed = 11,
        ObliqueFlattened = 12,
        ObliqueRounded = 13,
        ObliqueOffCenter = 14,
        ObliqueSquare = 15,
    }

    public enum SerifStyle
    {
        Any = 0,
        NoFit = 1,
        Cove = 2,
        ObtuseCove = 3,
        SquareCove = 4,
        ObtuseSquareCove = 5,
        Square = 6,
        Thin = 7,
        Bone = 8,
        Exaggerated = 9,
        Triangle = 10,
        NormalSans = 11,
        ObtuseSans = 12,
        PerpSans = 13,
        Flared = 14,
        Rounded = 15,
    }

    public enum XHeight
    {
        Any = 0,
        NoFit = 1,
        ConstantSmall = 2,
        ConstantStandard = 3,
        ConstantLarge = 4,
        DuckingSmall = 5,
        DuckingStandard = 6,
        DuckingLarge = 7,
    }

    public enum ArmStyle
    {
        Any = 0,
        NoFit = 1,
        StraightArmsHorizontal = 2,
        StraightArmsWedge = 3,
        StraightArmsVertical = 4,
        StraightArmsSingleSerif = 5,
        StraightArmsDoubleSerif = 6,
        NonStraightArmsHorizontal = 7,
        NonStraightArmsWedge = 8,
        NonStraightArmsVertical = 9,
        NonStraightArmsSingleSerif = 10,
        NonStraightArmsDoubleSerif = 11,
    }

    public enum StrokeVariation
    {
        Any = 0,
        NoFit = 1,
        GradualDiagonal = 2,
        GradualTransitional = 3,
        GradualVertical = 4,
        GradualHorizontal = 5,
        RapidVertical = 6,
        RapidHorizontal = 7,
        InstantVertical = 8,
    }

    public enum Contrast
    {
        Any = 0,
        NoFit = 1,
        None = 2,
        VeryLow = 3,
        Low = 4,
        MediumLow = 5,
        Medium = 6,
        MediumHigh = 7,
        High = 8,
        VeryHigh = 9,
    }

    public enum Midline
    {
        Any = 0,
        NoFit = 1,
        StandardTrimmed = 2,
        StandardPointed = 3,
        StandardSerifed = 4,
        HighTrimmed = 5,
        HighPointed = 6,
        HighSerifed = 7,
        ConstantTrimmed = 8,
        ConstantPointed = 9,
        ConstantSerifed = 10,
        LowTrimmed = 11,
        LowPointed = 12,
        LowSerifed = 13,
    }

    public partial class Panose : KaitaiStruct
    {
        public static Panose FromFile(string fileName)
        {
            return new Panose(new KaitaiStream(fileName));
        }


      
        public Panose(KaitaiStream p__io, Os2 p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _familyType = ((FamilyKind)m_io.ReadU1());
            _serifStyle = ((SerifStyle)m_io.ReadU1());
            _weight = ((Weight)m_io.ReadU1());
            _proportion = ((Proportion)m_io.ReadU1());
            _contrast = ((Contrast)m_io.ReadU1());
            _strokeVariation = ((StrokeVariation)m_io.ReadU1());
            _armStyle = ((ArmStyle)m_io.ReadU1());
            _letterForm = ((LetterForm)m_io.ReadU1());
            _midline = ((Midline)m_io.ReadU1());
            _xHeight = ((XHeight)m_io.ReadU1());
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
        public FamilyKind FamilyType { get { return _familyType; } }
        public SerifStyle SerifStyle { get { return _serifStyle; } }
        public Weight Weight { get { return _weight; } }
        public Proportion Proportion { get { return _proportion; } }
        public Contrast Contrast { get { return _contrast; } }
        public StrokeVariation StrokeVariation { get { return _strokeVariation; } }
        public ArmStyle ArmStyle { get { return _armStyle; } }
        public LetterForm LetterForm { get { return _letterForm; } }
        public Midline Midline { get { return _midline; } }
        public XHeight XHeight { get { return _xHeight; } }
        public Ttf M_Root { get { return m_root; } }
        public Os2 M_Parent { get { return m_parent; } }
    }
    public partial class UnicodeRange : KaitaiStruct
    {
        public static UnicodeRange FromFile(string fileName)
        {
            return new UnicodeRange(new KaitaiStream(fileName));
        }

        public UnicodeRange(KaitaiStream p__io, Os2 p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _basicLatin = m_io.ReadBitsInt(1) != 0;
            _latin1Supplement = m_io.ReadBitsInt(1) != 0;
            _latinExtendedA = m_io.ReadBitsInt(1) != 0;
            _latinExtendedB = m_io.ReadBitsInt(1) != 0;
            _ipaExtensions = m_io.ReadBitsInt(1) != 0;
            _spacingModifierLetters = m_io.ReadBitsInt(1) != 0;
            _combiningDiacriticalMarks = m_io.ReadBitsInt(1) != 0;
            _basicGreek = m_io.ReadBitsInt(1) != 0;
            _greekSymbolsAndCoptic = m_io.ReadBitsInt(1) != 0;
            _cyrillic = m_io.ReadBitsInt(1) != 0;
            _armenian = m_io.ReadBitsInt(1) != 0;
            _basicHebrew = m_io.ReadBitsInt(1) != 0;
            _hebrewExtended = m_io.ReadBitsInt(1) != 0;
            _basicArabic = m_io.ReadBitsInt(1) != 0;
            _arabicExtended = m_io.ReadBitsInt(1) != 0;
            _devanagari = m_io.ReadBitsInt(1) != 0;
            _bengali = m_io.ReadBitsInt(1) != 0;
            _gurmukhi = m_io.ReadBitsInt(1) != 0;
            _gujarati = m_io.ReadBitsInt(1) != 0;
            _oriya = m_io.ReadBitsInt(1) != 0;
            _tamil = m_io.ReadBitsInt(1) != 0;
            _telugu = m_io.ReadBitsInt(1) != 0;
            _kannada = m_io.ReadBitsInt(1) != 0;
            _malayalam = m_io.ReadBitsInt(1) != 0;
            _thai = m_io.ReadBitsInt(1) != 0;
            _lao = m_io.ReadBitsInt(1) != 0;
            _basicGeorgian = m_io.ReadBitsInt(1) != 0;
            _georgianExtended = m_io.ReadBitsInt(1) != 0;
            _hangulJamo = m_io.ReadBitsInt(1) != 0;
            _latinExtendedAdditional = m_io.ReadBitsInt(1) != 0;
            _greekExtended = m_io.ReadBitsInt(1) != 0;
            _generalPunctuation = m_io.ReadBitsInt(1) != 0;
            _superscriptsAndSubscripts = m_io.ReadBitsInt(1) != 0;
            _currencySymbols = m_io.ReadBitsInt(1) != 0;
            _combiningDiacriticalMarksForSymbols = m_io.ReadBitsInt(1) != 0;
            _letterlikeSymbols = m_io.ReadBitsInt(1) != 0;
            _numberForms = m_io.ReadBitsInt(1) != 0;
            _arrows = m_io.ReadBitsInt(1) != 0;
            _mathematicalOperators = m_io.ReadBitsInt(1) != 0;
            _miscellaneousTechnical = m_io.ReadBitsInt(1) != 0;
            _controlPictures = m_io.ReadBitsInt(1) != 0;
            _opticalCharacterRecognition = m_io.ReadBitsInt(1) != 0;
            _enclosedAlphanumerics = m_io.ReadBitsInt(1) != 0;
            _boxDrawing = m_io.ReadBitsInt(1) != 0;
            _blockElements = m_io.ReadBitsInt(1) != 0;
            _geometricShapes = m_io.ReadBitsInt(1) != 0;
            _miscellaneousSymbols = m_io.ReadBitsInt(1) != 0;
            _dingbats = m_io.ReadBitsInt(1) != 0;
            _cjkSymbolsAndPunctuation = m_io.ReadBitsInt(1) != 0;
            _hiragana = m_io.ReadBitsInt(1) != 0;
            _katakana = m_io.ReadBitsInt(1) != 0;
            _bopomofo = m_io.ReadBitsInt(1) != 0;
            _hangulCompatibilityJamo = m_io.ReadBitsInt(1) != 0;
            _cjkMiscellaneous = m_io.ReadBitsInt(1) != 0;
            _enclosedCjkLettersAndMonths = m_io.ReadBitsInt(1) != 0;
            _cjkCompatibility = m_io.ReadBitsInt(1) != 0;
            _hangul = m_io.ReadBitsInt(1) != 0;
            _reservedForUnicodeSubranges1 = m_io.ReadBitsInt(1) != 0;
            _reservedForUnicodeSubranges2 = m_io.ReadBitsInt(1) != 0;
            _cjkUnifiedIdeographs = m_io.ReadBitsInt(1) != 0;
            _privateUseArea = m_io.ReadBitsInt(1) != 0;
            _cjkCompatibilityIdeographs = m_io.ReadBitsInt(1) != 0;
            _alphabeticPresentationForms = m_io.ReadBitsInt(1) != 0;
            _arabicPresentationFormsA = m_io.ReadBitsInt(1) != 0;
            _combiningHalfMarks = m_io.ReadBitsInt(1) != 0;
            _cjkCompatibilityForms = m_io.ReadBitsInt(1) != 0;
            _smallFormVariants = m_io.ReadBitsInt(1) != 0;
            _arabicPresentationFormsB = m_io.ReadBitsInt(1) != 0;
            _halfwidthAndFullwidthForms = m_io.ReadBitsInt(1) != 0;
            _specials = m_io.ReadBitsInt(1) != 0;
            m_io.AlignToByte();
            _reserved = m_io.ReadBytes(7);
        }
        private bool _basicLatin;
        private bool _latin1Supplement;
        private bool _latinExtendedA;
        private bool _latinExtendedB;
        private bool _ipaExtensions;
        private bool _spacingModifierLetters;
        private bool _combiningDiacriticalMarks;
        private bool _basicGreek;
        private bool _greekSymbolsAndCoptic;
        private bool _cyrillic;
        private bool _armenian;
        private bool _basicHebrew;
        private bool _hebrewExtended;
        private bool _basicArabic;
        private bool _arabicExtended;
        private bool _devanagari;
        private bool _bengali;
        private bool _gurmukhi;
        private bool _gujarati;
        private bool _oriya;
        private bool _tamil;
        private bool _telugu;
        private bool _kannada;
        private bool _malayalam;
        private bool _thai;
        private bool _lao;
        private bool _basicGeorgian;
        private bool _georgianExtended;
        private bool _hangulJamo;
        private bool _latinExtendedAdditional;
        private bool _greekExtended;
        private bool _generalPunctuation;
        private bool _superscriptsAndSubscripts;
        private bool _currencySymbols;
        private bool _combiningDiacriticalMarksForSymbols;
        private bool _letterlikeSymbols;
        private bool _numberForms;
        private bool _arrows;
        private bool _mathematicalOperators;
        private bool _miscellaneousTechnical;
        private bool _controlPictures;
        private bool _opticalCharacterRecognition;
        private bool _enclosedAlphanumerics;
        private bool _boxDrawing;
        private bool _blockElements;
        private bool _geometricShapes;
        private bool _miscellaneousSymbols;
        private bool _dingbats;
        private bool _cjkSymbolsAndPunctuation;
        private bool _hiragana;
        private bool _katakana;
        private bool _bopomofo;
        private bool _hangulCompatibilityJamo;
        private bool _cjkMiscellaneous;
        private bool _enclosedCjkLettersAndMonths;
        private bool _cjkCompatibility;
        private bool _hangul;
        private bool _reservedForUnicodeSubranges1;
        private bool _reservedForUnicodeSubranges2;
        private bool _cjkUnifiedIdeographs;
        private bool _privateUseArea;
        private bool _cjkCompatibilityIdeographs;
        private bool _alphabeticPresentationForms;
        private bool _arabicPresentationFormsA;
        private bool _combiningHalfMarks;
        private bool _cjkCompatibilityForms;
        private bool _smallFormVariants;
        private bool _arabicPresentationFormsB;
        private bool _halfwidthAndFullwidthForms;
        private bool _specials;
        private byte[] _reserved;
        private Ttf m_root;
        private Os2 m_parent;
        public bool BasicLatin { get { return _basicLatin; } }
        public bool Latin1Supplement { get { return _latin1Supplement; } }
        public bool LatinExtendedA { get { return _latinExtendedA; } }
        public bool LatinExtendedB { get { return _latinExtendedB; } }
        public bool IpaExtensions { get { return _ipaExtensions; } }
        public bool SpacingModifierLetters { get { return _spacingModifierLetters; } }
        public bool CombiningDiacriticalMarks { get { return _combiningDiacriticalMarks; } }
        public bool BasicGreek { get { return _basicGreek; } }
        public bool GreekSymbolsAndCoptic { get { return _greekSymbolsAndCoptic; } }
        public bool Cyrillic { get { return _cyrillic; } }
        public bool Armenian { get { return _armenian; } }
        public bool BasicHebrew { get { return _basicHebrew; } }
        public bool HebrewExtended { get { return _hebrewExtended; } }
        public bool BasicArabic { get { return _basicArabic; } }
        public bool ArabicExtended { get { return _arabicExtended; } }
        public bool Devanagari { get { return _devanagari; } }
        public bool Bengali { get { return _bengali; } }
        public bool Gurmukhi { get { return _gurmukhi; } }
        public bool Gujarati { get { return _gujarati; } }
        public bool Oriya { get { return _oriya; } }
        public bool Tamil { get { return _tamil; } }
        public bool Telugu { get { return _telugu; } }
        public bool Kannada { get { return _kannada; } }
        public bool Malayalam { get { return _malayalam; } }
        public bool Thai { get { return _thai; } }
        public bool Lao { get { return _lao; } }
        public bool BasicGeorgian { get { return _basicGeorgian; } }
        public bool GeorgianExtended { get { return _georgianExtended; } }
        public bool HangulJamo { get { return _hangulJamo; } }
        public bool LatinExtendedAdditional { get { return _latinExtendedAdditional; } }
        public bool GreekExtended { get { return _greekExtended; } }
        public bool GeneralPunctuation { get { return _generalPunctuation; } }
        public bool SuperscriptsAndSubscripts { get { return _superscriptsAndSubscripts; } }
        public bool CurrencySymbols { get { return _currencySymbols; } }
        public bool CombiningDiacriticalMarksForSymbols { get { return _combiningDiacriticalMarksForSymbols; } }
        public bool LetterlikeSymbols { get { return _letterlikeSymbols; } }
        public bool NumberForms { get { return _numberForms; } }
        public bool Arrows { get { return _arrows; } }
        public bool MathematicalOperators { get { return _mathematicalOperators; } }
        public bool MiscellaneousTechnical { get { return _miscellaneousTechnical; } }
        public bool ControlPictures { get { return _controlPictures; } }
        public bool OpticalCharacterRecognition { get { return _opticalCharacterRecognition; } }
        public bool EnclosedAlphanumerics { get { return _enclosedAlphanumerics; } }
        public bool BoxDrawing { get { return _boxDrawing; } }
        public bool BlockElements { get { return _blockElements; } }
        public bool GeometricShapes { get { return _geometricShapes; } }
        public bool MiscellaneousSymbols { get { return _miscellaneousSymbols; } }
        public bool Dingbats { get { return _dingbats; } }
        public bool CjkSymbolsAndPunctuation { get { return _cjkSymbolsAndPunctuation; } }
        public bool Hiragana { get { return _hiragana; } }
        public bool Katakana { get { return _katakana; } }
        public bool Bopomofo { get { return _bopomofo; } }
        public bool HangulCompatibilityJamo { get { return _hangulCompatibilityJamo; } }
        public bool CjkMiscellaneous { get { return _cjkMiscellaneous; } }
        public bool EnclosedCjkLettersAndMonths { get { return _enclosedCjkLettersAndMonths; } }
        public bool CjkCompatibility { get { return _cjkCompatibility; } }
        public bool Hangul { get { return _hangul; } }
        public bool ReservedForUnicodeSubranges1 { get { return _reservedForUnicodeSubranges1; } }
        public bool ReservedForUnicodeSubranges2 { get { return _reservedForUnicodeSubranges2; } }
        public bool CjkUnifiedIdeographs { get { return _cjkUnifiedIdeographs; } }
        public bool PrivateUseArea { get { return _privateUseArea; } }
        public bool CjkCompatibilityIdeographs { get { return _cjkCompatibilityIdeographs; } }
        public bool AlphabeticPresentationForms { get { return _alphabeticPresentationForms; } }
        public bool ArabicPresentationFormsA { get { return _arabicPresentationFormsA; } }
        public bool CombiningHalfMarks { get { return _combiningHalfMarks; } }
        public bool CjkCompatibilityForms { get { return _cjkCompatibilityForms; } }
        public bool SmallFormVariants { get { return _smallFormVariants; } }
        public bool ArabicPresentationFormsB { get { return _arabicPresentationFormsB; } }
        public bool HalfwidthAndFullwidthForms { get { return _halfwidthAndFullwidthForms; } }
        public bool Specials { get { return _specials; } }
        public byte[] Reserved { get { return _reserved; } }
        public Ttf M_Root { get { return m_root; } }
        public Os2 M_Parent { get { return m_parent; } }
    }
    public partial class CodePageRange : KaitaiStruct
    {
        public static CodePageRange FromFile(string fileName)
        {
            return new CodePageRange(new KaitaiStream(fileName));
        }

        public CodePageRange(KaitaiStream p__io, Os2 p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _symbolCharacterSet = m_io.ReadBitsInt(1) != 0;
            _oemCharacterSet = m_io.ReadBitsInt(1) != 0;
            _macintoshCharacterSet = m_io.ReadBitsInt(1) != 0;
            _reservedForAlternateAnsiOem = m_io.ReadBitsInt(7);
            _cp1361KoreanJohab = m_io.ReadBitsInt(1) != 0;
            _cp950ChineseTraditionalCharsTaiwanAndHongKong = m_io.ReadBitsInt(1) != 0;
            _cp949KoreanWansung = m_io.ReadBitsInt(1) != 0;
            _cp936ChineseSimplifiedCharsPrcAndSingapore = m_io.ReadBitsInt(1) != 0;
            _cp932JisJapan = m_io.ReadBitsInt(1) != 0;
            _cp874Thai = m_io.ReadBitsInt(1) != 0;
            _reservedForAlternateAnsi = m_io.ReadBitsInt(8);
            _cp1257WindowsBaltic = m_io.ReadBitsInt(1) != 0;
            _cp1256Arabic = m_io.ReadBitsInt(1) != 0;
            _cp1255Hebrew = m_io.ReadBitsInt(1) != 0;
            _cp1254Turkish = m_io.ReadBitsInt(1) != 0;
            _cp1253Greek = m_io.ReadBitsInt(1) != 0;
            _cp1251Cyrillic = m_io.ReadBitsInt(1) != 0;
            _cp1250Latin2EasternEurope = m_io.ReadBitsInt(1) != 0;
            _cp1252Latin1 = m_io.ReadBitsInt(1) != 0;
            _cp437Us = m_io.ReadBitsInt(1) != 0;
            _cp850WeLatin1 = m_io.ReadBitsInt(1) != 0;
            _cp708ArabicAsmo708 = m_io.ReadBitsInt(1) != 0;
            _cp737GreekFormer437G = m_io.ReadBitsInt(1) != 0;
            _cp775MsDosBaltic = m_io.ReadBitsInt(1) != 0;
            _cp852Latin2 = m_io.ReadBitsInt(1) != 0;
            _cp855IbmCyrillicPrimarilyRussian = m_io.ReadBitsInt(1) != 0;
            _cp857IbmTurkish = m_io.ReadBitsInt(1) != 0;
            _cp860MsDosPortuguese = m_io.ReadBitsInt(1) != 0;
            _cp861MsDosIcelandic = m_io.ReadBitsInt(1) != 0;
            _cp862Hebrew = m_io.ReadBitsInt(1) != 0;
            _cp863MsDosCanadianFrench = m_io.ReadBitsInt(1) != 0;
            _cp864Arabic = m_io.ReadBitsInt(1) != 0;
            _cp865MsDosNordic = m_io.ReadBitsInt(1) != 0;
            _cp866MsDosRussian = m_io.ReadBitsInt(1) != 0;
            _cp869IbmGreek = m_io.ReadBitsInt(1) != 0;
            _reservedForOem = m_io.ReadBitsInt(16);
        }
        private bool _symbolCharacterSet;
        private bool _oemCharacterSet;
        private bool _macintoshCharacterSet;
        private ulong _reservedForAlternateAnsiOem;
        private bool _cp1361KoreanJohab;
        private bool _cp950ChineseTraditionalCharsTaiwanAndHongKong;
        private bool _cp949KoreanWansung;
        private bool _cp936ChineseSimplifiedCharsPrcAndSingapore;
        private bool _cp932JisJapan;
        private bool _cp874Thai;
        private ulong _reservedForAlternateAnsi;
        private bool _cp1257WindowsBaltic;
        private bool _cp1256Arabic;
        private bool _cp1255Hebrew;
        private bool _cp1254Turkish;
        private bool _cp1253Greek;
        private bool _cp1251Cyrillic;
        private bool _cp1250Latin2EasternEurope;
        private bool _cp1252Latin1;
        private bool _cp437Us;
        private bool _cp850WeLatin1;
        private bool _cp708ArabicAsmo708;
        private bool _cp737GreekFormer437G;
        private bool _cp775MsDosBaltic;
        private bool _cp852Latin2;
        private bool _cp855IbmCyrillicPrimarilyRussian;
        private bool _cp857IbmTurkish;
        private bool _cp860MsDosPortuguese;
        private bool _cp861MsDosIcelandic;
        private bool _cp862Hebrew;
        private bool _cp863MsDosCanadianFrench;
        private bool _cp864Arabic;
        private bool _cp865MsDosNordic;
        private bool _cp866MsDosRussian;
        private bool _cp869IbmGreek;
        private ulong _reservedForOem;
        private Ttf m_root;
        private Os2 m_parent;
        public bool SymbolCharacterSet { get { return _symbolCharacterSet; } }
        public bool OemCharacterSet { get { return _oemCharacterSet; } }
        public bool MacintoshCharacterSet { get { return _macintoshCharacterSet; } }
        public ulong ReservedForAlternateAnsiOem { get { return _reservedForAlternateAnsiOem; } }
        public bool Cp1361KoreanJohab { get { return _cp1361KoreanJohab; } }
        public bool Cp950ChineseTraditionalCharsTaiwanAndHongKong { get { return _cp950ChineseTraditionalCharsTaiwanAndHongKong; } }
        public bool Cp949KoreanWansung { get { return _cp949KoreanWansung; } }
        public bool Cp936ChineseSimplifiedCharsPrcAndSingapore { get { return _cp936ChineseSimplifiedCharsPrcAndSingapore; } }
        public bool Cp932JisJapan { get { return _cp932JisJapan; } }
        public bool Cp874Thai { get { return _cp874Thai; } }
        public ulong ReservedForAlternateAnsi { get { return _reservedForAlternateAnsi; } }
        public bool Cp1257WindowsBaltic { get { return _cp1257WindowsBaltic; } }
        public bool Cp1256Arabic { get { return _cp1256Arabic; } }
        public bool Cp1255Hebrew { get { return _cp1255Hebrew; } }
        public bool Cp1254Turkish { get { return _cp1254Turkish; } }
        public bool Cp1253Greek { get { return _cp1253Greek; } }
        public bool Cp1251Cyrillic { get { return _cp1251Cyrillic; } }
        public bool Cp1250Latin2EasternEurope { get { return _cp1250Latin2EasternEurope; } }
        public bool Cp1252Latin1 { get { return _cp1252Latin1; } }
        public bool Cp437Us { get { return _cp437Us; } }
        public bool Cp850WeLatin1 { get { return _cp850WeLatin1; } }
        public bool Cp708ArabicAsmo708 { get { return _cp708ArabicAsmo708; } }
        public bool Cp737GreekFormer437G { get { return _cp737GreekFormer437G; } }
        public bool Cp775MsDosBaltic { get { return _cp775MsDosBaltic; } }
        public bool Cp852Latin2 { get { return _cp852Latin2; } }
        public bool Cp855IbmCyrillicPrimarilyRussian { get { return _cp855IbmCyrillicPrimarilyRussian; } }
        public bool Cp857IbmTurkish { get { return _cp857IbmTurkish; } }
        public bool Cp860MsDosPortuguese { get { return _cp860MsDosPortuguese; } }
        public bool Cp861MsDosIcelandic { get { return _cp861MsDosIcelandic; } }
        public bool Cp862Hebrew { get { return _cp862Hebrew; } }
        public bool Cp863MsDosCanadianFrench { get { return _cp863MsDosCanadianFrench; } }
        public bool Cp864Arabic { get { return _cp864Arabic; } }
        public bool Cp865MsDosNordic { get { return _cp865MsDosNordic; } }
        public bool Cp866MsDosRussian { get { return _cp866MsDosRussian; } }
        public bool Cp869IbmGreek { get { return _cp869IbmGreek; } }
        public ulong ReservedForOem { get { return _reservedForOem; } }
        public Ttf M_Root { get { return m_root; } }
        public Os2 M_Parent { get { return m_parent; } }
    }

    public class Format0 : KaitaiStruct
    {
        public static Format0 FromFile(string fileName)
        {
            return new Format0(new KaitaiStream(fileName));
        }

        public Format0(KaitaiStream p__io, Kern.Subtable p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _pairCount = m_io.ReadU2be();
            _searchRange = m_io.ReadU2be();
            _entrySelector = m_io.ReadU2be();
            _rangeShift = m_io.ReadU2be();
            _kerningPairs = new List<KerningPair>((int)(PairCount));
            for (var i = 0; i < PairCount; i++)
            {
                _kerningPairs.Add(new KerningPair(m_io, this, m_root));
            }
        }
        public partial class KerningPair : KaitaiStruct
        {
            public static KerningPair FromFile(string fileName)
            {
                return new KerningPair(new KaitaiStream(fileName));
            }

            public KerningPair(KaitaiStream p__io, Format0 p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _left = m_io.ReadU2be();
                _right = m_io.ReadU2be();
                _value = m_io.ReadS2be();
            }
            private ushort _left;
            private ushort _right;
            private short _value;
            private Ttf m_root;
            private Format0 m_parent;
            public ushort Left { get { return _left; } }
            public ushort Right { get { return _right; } }
            public short Value { get { return _value; } }
            public Ttf M_Root { get { return m_root; } }
            public Format0 M_Parent { get { return m_parent; } }
        }
        private ushort _pairCount;
        private ushort _searchRange;
        private ushort _entrySelector;
        private ushort _rangeShift;
        private List<KerningPair> _kerningPairs;
        private Ttf m_root;
        private Kern.Subtable m_parent;
        public ushort PairCount { get { return _pairCount; } }
        public ushort SearchRange { get { return _searchRange; } }
        public ushort EntrySelector { get { return _entrySelector; } }
        public ushort RangeShift { get { return _rangeShift; } }
        public List<KerningPair> KerningPairs { get { return _kerningPairs; } }
        public Ttf M_Root { get { return m_root; } }
        public Kern.Subtable M_Parent { get { return m_parent; } }
    }

    public class Format20 : KaitaiStruct
    {
        public static Format20 FromFile(string fileName)
        {
            return new Format20(new KaitaiStream(fileName));
        }

        public Format20(KaitaiStream p__io, Post p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _numberOfGlyphs = m_io.ReadU2be();
            _glyphNameIndex = new List<ushort>((int)(NumberOfGlyphs));
            for (var i = 0; i < NumberOfGlyphs; i++)
            {
                _glyphNameIndex.Add(m_io.ReadU2be());
            }
            _glyphNames = new List<PascalString>();
            {
                var i = 0;
                PascalString M_;
                do
                {
                    M_ = new PascalString(m_io, this, m_root);
                    _glyphNames.Add(M_);
                    i++;
                } while (!(M_.Length == 0));
            }
        }
        public partial class PascalString : KaitaiStruct
        {
            public static PascalString FromFile(string fileName)
            {
                return new PascalString(new KaitaiStream(fileName));
            }

            public PascalString(KaitaiStream p__io, Format20 p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _length = m_io.ReadU1();
                if (Length != 0)
                {
                    _value = System.Text.Encoding.GetEncoding("ascii").GetString(m_io.ReadBytes(Length));
                }
            }
            private byte _length;
            private string _value;
            private Ttf m_root;
            private Format20 m_parent;
            public byte Length { get { return _length; } }
            public string Value { get { return _value; } }
            public Ttf M_Root { get { return m_root; } }
            public Format20 M_Parent { get { return m_parent; } }
        }
        private ushort _numberOfGlyphs;
        private List<ushort> _glyphNameIndex;
        private List<PascalString> _glyphNames;
        private Ttf m_root;
        private Post m_parent;
        public ushort NumberOfGlyphs { get { return _numberOfGlyphs; } }
        public List<ushort> GlyphNameIndex { get { return _glyphNameIndex; } }
        public List<PascalString> GlyphNames { get { return _glyphNames; } }
        public Ttf M_Root { get { return m_root; } }
        public Post M_Parent { get { return m_parent; } }
    }

    public class Post : KaitaiStruct
    {
        public static Post FromFile(string fileName)
        {
            return new Post(new KaitaiStream(fileName));
        }

        public Post(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _format = new Fixed(m_io, this, m_root);
            _italicAngle = new Fixed(m_io, this, m_root);
            _underlinePosition = m_io.ReadS2be();
            _underlineThichness = m_io.ReadS2be();
            _isFixedPitch = m_io.ReadU4be();
            _minMemType42 = m_io.ReadU4be();
            _maxMemType42 = m_io.ReadU4be();
            _minMemType1 = m_io.ReadU4be();
            _maxMemType1 = m_io.ReadU4be();
            if (((Format.Major == 2) && (Format.Minor == 0)))
            {
                _format20 = new Format20(m_io, this, m_root);
            }
        }
        
        private Fixed _format;
        private Fixed _italicAngle;
        private short _underlinePosition;
        private short _underlineThichness;
        private uint _isFixedPitch;
        private uint _minMemType42;
        private uint _maxMemType42;
        private uint _minMemType1;
        private uint _maxMemType1;
        private Format20 _format20;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public Fixed Format { get { return _format; } }
        public Fixed ItalicAngle { get { return _italicAngle; } }
        public short UnderlinePosition { get { return _underlinePosition; } }
        public short UnderlineThichness { get { return _underlineThichness; } }
        public uint IsFixedPitch { get { return _isFixedPitch; } }
        public uint MinMemType42 { get { return _minMemType42; } }
        public uint MaxMemType42 { get { return _maxMemType42; } }
        public uint MinMemType1 { get { return _minMemType1; } }
        public uint MaxMemType1 { get { return _maxMemType1; } }
        public Format20 Format20 { get { return _format20; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }

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
    public partial class Name : KaitaiStruct
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
            Microsoft = 3,
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
            SampleText = 19,
        }
        public Name(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _formatSelector = m_io.ReadU2be();
            _numNameRecords = m_io.ReadU2be();
            _ofsStrings = m_io.ReadU2be();
            _nameRecords = new List<NameRecord>((int)(NumNameRecords));
            for (var i = 0; i < NumNameRecords; i++)
            {
                _nameRecords.Add(new NameRecord(m_io, this, m_root));
            }
        }
        public partial class NameRecord : KaitaiStruct
        {
            public static NameRecord FromFile(string fileName)
            {
                return new NameRecord(new KaitaiStream(fileName));
            }

            public NameRecord(KaitaiStream p__io, Name p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_asciiValue = false;
                f_unicodeValue = false;
                _read();
            }
            private void _read()
            {
                _platformId = ((Name.Platforms)m_io.ReadU2be());
                _encodingId = m_io.ReadU2be();
                _languageId = m_io.ReadU2be();
                _nameId = ((Name.Names)m_io.ReadU2be());
                _lenStr = m_io.ReadU2be();
                _ofsStr = m_io.ReadU2be();
            }
            private bool f_asciiValue;
            private string _asciiValue;
            public string AsciiValue
            {
                get
                {
                    if (f_asciiValue)
                        return _asciiValue;
                    KaitaiStream io = M_Parent.M_Io;
                    long _pos = io.Pos;
                    io.Seek((M_Parent.OfsStrings + OfsStr));
                    _asciiValue = System.Text.Encoding.GetEncoding("ascii").GetString(io.ReadBytes(LenStr));
                    io.Seek(_pos);
                    f_asciiValue = true;
                    return _asciiValue;
                }
            }
            private bool f_unicodeValue;
            private string _unicodeValue;
            public string UnicodeValue
            {
                get
                {
                    if (f_unicodeValue)
                        return _unicodeValue;
                    KaitaiStream io = M_Parent.M_Io;
                    long _pos = io.Pos;
                    io.Seek((M_Parent.OfsStrings + OfsStr));
                    _unicodeValue = System.Text.Encoding.GetEncoding("utf-16be").GetString(io.ReadBytes(LenStr));
                    io.Seek(_pos);
                    f_unicodeValue = true;
                    return _unicodeValue;
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
            public Platforms PlatformId { get { return _platformId; } }
            public ushort EncodingId { get { return _encodingId; } }
            public ushort LanguageId { get { return _languageId; } }
            public Names NameId { get { return _nameId; } }
            public ushort LenStr { get { return _lenStr; } }
            public ushort OfsStr { get { return _ofsStr; } }
            public Ttf M_Root { get { return m_root; } }
            public Name M_Parent { get { return m_parent; } }
        }
        private ushort _formatSelector;
        private ushort _numNameRecords;
        private ushort _ofsStrings;
        private List<NameRecord> _nameRecords;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort FormatSelector { get { return _formatSelector; } }
        public ushort NumNameRecords { get { return _numNameRecords; } }
        public ushort OfsStrings { get { return _ofsStrings; } }
        public List<NameRecord> NameRecords { get { return _nameRecords; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }

    public enum Flags
    {
        BaselineAtY0 = 1,
        LeftSidebearingAtX0 = 2,
        FlagDependOnPointSize = 4,
        FlagForcePpem = 8,
        FlagMayAdvanceWidth = 16,
    }

    public enum FontDirectionHint
    {
        FullyMixedDirectionalGlyphs = 0,
        OnlyStronglyLeftToRight = 1,
        StronglyLeftToRightAndNeutrals = 2,
    }

    public partial class Head : KaitaiStruct
    {
        public static Head FromFile(string fileName)
        {
            return new Head(new KaitaiStream(fileName));
        }


      
        public Head(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _version = new Fixed(m_io, this, m_root);
            _fontRevision = new Fixed(m_io, this, m_root);
            _checksumAdjustment = m_io.ReadU4be();
            _magicNumber = m_io.EnsureFixedContents(new byte[] { 95, 15, 60, 245 });
            _flags = ((Flags)m_io.ReadU2be());
            _unitsPerEm = m_io.ReadU2be();
            _created = m_io.ReadU8be();
            _modified = m_io.ReadU8be();
            _xMin = m_io.ReadS2be();
            _yMin = m_io.ReadS2be();
            _xMax = m_io.ReadS2be();
            _yMax = m_io.ReadS2be();
            _macStyle = m_io.ReadU2be();
            _lowestRecPpem = m_io.ReadU2be();
            _fontDirectionHint = ((FontDirectionHint)m_io.ReadS2be());
            _indexToLocFormat = m_io.ReadS2be();
            _glyphDataFormat = m_io.ReadS2be();
        }
        private Fixed _version;
        private Fixed _fontRevision;
        private uint _checksumAdjustment;
        private byte[] _magicNumber;
        private Flags _flags;
        private ushort _unitsPerEm;
        private ulong _created;
        private ulong _modified;
        private short _xMin;
        private short _yMin;
        private short _xMax;
        private short _yMax;
        private ushort _macStyle;
        private ushort _lowestRecPpem;
        private FontDirectionHint _fontDirectionHint;
        private short _indexToLocFormat;
        private short _glyphDataFormat;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public Fixed Version { get { return _version; } }
        public Fixed FontRevision { get { return _fontRevision; } }
        public uint ChecksumAdjustment { get { return _checksumAdjustment; } }
        public byte[] MagicNumber { get { return _magicNumber; } }
        public Flags Flags { get { return _flags; } }
        public ushort UnitsPerEm { get { return _unitsPerEm; } }
        public ulong Created { get { return _created; } }
        public ulong Modified { get { return _modified; } }
        public short XMin { get { return _xMin; } }
        public short YMin { get { return _yMin; } }
        public short XMax { get { return _xMax; } }
        public short YMax { get { return _yMax; } }
        public ushort MacStyle { get { return _macStyle; } }
        public ushort LowestRecPpem { get { return _lowestRecPpem; } }
        public FontDirectionHint FontDirectionHint { get { return _fontDirectionHint; } }
        public short IndexToLocFormat { get { return _indexToLocFormat; } }
        public short GlyphDataFormat { get { return _glyphDataFormat; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class Prep : KaitaiStruct
    {
        public static Prep FromFile(string fileName)
        {
            return new Prep(new KaitaiStream(fileName));
        }

        public Prep(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _instructions = m_io.ReadBytesFull();
        }
        private byte[] _instructions;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public byte[] Instructions { get { return _instructions; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class Hhea : KaitaiStruct
    {
        public static Hhea FromFile(string fileName)
        {
            return new Hhea(new KaitaiStream(fileName));
        }

        public Hhea(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _version = new Fixed(m_io, this, m_root);
            _ascender = m_io.ReadS2be();
            _descender = m_io.ReadS2be();
            _lineGap = m_io.ReadS2be();
            _advanceWidthMax = m_io.ReadU2be();
            _minLeftSideBearing = m_io.ReadS2be();
            _minRightSideBearing = m_io.ReadS2be();
            _xMaxExtend = m_io.ReadS2be();
            _caretSlopeRise = m_io.ReadS2be();
            _caretSlopeRun = m_io.ReadS2be();
            _reserved = m_io.EnsureFixedContents(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            _metricDataFormat = m_io.ReadS2be();
            _numberOfHmetrics = m_io.ReadU2be();
        }
        private Fixed _version;
        private short _ascender;
        private short _descender;
        private short _lineGap;
        private ushort _advanceWidthMax;
        private short _minLeftSideBearing;
        private short _minRightSideBearing;
        private short _xMaxExtend;
        private short _caretSlopeRise;
        private short _caretSlopeRun;
        private byte[] _reserved;
        private short _metricDataFormat;
        private ushort _numberOfHmetrics;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public Fixed Version { get { return _version; } }

        /// <summary>
        /// Typographic ascent
        /// </summary>
        public short Ascender { get { return _ascender; } }

        /// <summary>
        /// Typographic descent
        /// </summary>
        public short Descender { get { return _descender; } }

        /// <summary>
        /// Typographic line gap. Negative LineGap values are treated as zero in Windows 3.1, System 6, and System 7.
        /// </summary>
        public short LineGap { get { return _lineGap; } }

        /// <summary>
        /// Maximum advance width value in `hmtx` table.
        /// </summary>
        public ushort AdvanceWidthMax { get { return _advanceWidthMax; } }

        /// <summary>
        /// Minimum left sidebearing value in `hmtx` table.
        /// </summary>
        public short MinLeftSideBearing { get { return _minLeftSideBearing; } }

        /// <summary>
        /// Minimum right sidebearing value; calculated as Min(aw - lsb - (xMax - xMin)).
        /// </summary>
        public short MinRightSideBearing { get { return _minRightSideBearing; } }

        /// <summary>
        /// Max(lsb + (xMax - xMin)).
        /// </summary>
        public short XMaxExtend { get { return _xMaxExtend; } }
        public short CaretSlopeRise { get { return _caretSlopeRise; } }
        public short CaretSlopeRun { get { return _caretSlopeRun; } }
        public byte[] Reserved { get { return _reserved; } }
        public short MetricDataFormat { get { return _metricDataFormat; } }
        public ushort NumberOfHmetrics { get { return _numberOfHmetrics; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class Fpgm : KaitaiStruct
    {
        public static Fpgm FromFile(string fileName)
        {
            return new Fpgm(new KaitaiStream(fileName));
        }

        public Fpgm(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _instructions = m_io.ReadBytesFull();
        }
        private byte[] _instructions;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public byte[] Instructions { get { return _instructions; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class Kern : KaitaiStruct
    {
        public static Kern FromFile(string fileName)
        {
            return new Kern(new KaitaiStream(fileName));
        }

        public Kern(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _version = m_io.ReadU2be();
            _subtableCount = m_io.ReadU2be();
            _subtables = new List<Subtable>((int)(SubtableCount));
            for (var i = 0; i < SubtableCount; i++)
            {
                _subtables.Add(new Subtable(m_io, this, m_root));
            }
        }
        public partial class Subtable : KaitaiStruct
        {
            public static Subtable FromFile(string fileName)
            {
                return new Subtable(new KaitaiStream(fileName));
            }

            public Subtable(KaitaiStream p__io, Kern p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _version = m_io.ReadU2be();
                _length = m_io.ReadU2be();
                _format = m_io.ReadU1();
                _reserved = m_io.ReadBitsInt(4);
                _isOverride = m_io.ReadBitsInt(1) != 0;
                _isCrossStream = m_io.ReadBitsInt(1) != 0;
                _isMinimum = m_io.ReadBitsInt(1) != 0;
                _isHorizontal = m_io.ReadBitsInt(1) != 0;
                m_io.AlignToByte();
                if (Format == 0)
                {
                    _format0 = new Format0(m_io, this, m_root);
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
            public ushort Version { get { return _version; } }
            public ushort Length { get { return _length; } }
            public byte Format { get { return _format; } }
            public ulong Reserved { get { return _reserved; } }
            public bool IsOverride { get { return _isOverride; } }
            public bool IsCrossStream { get { return _isCrossStream; } }
            public bool IsMinimum { get { return _isMinimum; } }
            public bool IsHorizontal { get { return _isHorizontal; } }
            public Format0 Format0 { get { return _format0; } }
            public Ttf M_Root { get { return m_root; } }
            public Kern M_Parent { get { return m_parent; } }
        }
        private ushort _version;
        private ushort _subtableCount;
        private List<Subtable> _subtables;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort Version { get { return _version; } }
        public ushort SubtableCount { get { return _subtableCount; } }
        public List<Subtable> Subtables { get { return _subtables; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class DirTableEntry : KaitaiStruct
    {
        public static DirTableEntry FromFile(string fileName)
        {
            return new DirTableEntry(new KaitaiStream(fileName));
        }

        public DirTableEntry(KaitaiStream p__io, Ttf p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            f_value = false;
            _read();
        }
        private void _read()
        {
            _tag = System.Text.Encoding.GetEncoding("ascii").GetString(m_io.ReadBytes(4));
            _checksum = m_io.ReadU4be();
            _offset = m_io.ReadU4be();
            _length = m_io.ReadU4be();
        }
        private bool f_value;
        private object _value;
        public object Value
        {
            get
            {
                if (f_value)
                    return _value;
                KaitaiStream io = M_Root.M_Io;
                long _pos = io.Pos;
                io.Seek(Offset);
                switch (Tag)
                {
                    case "head":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Head(io___raw_value, this, m_root);
                        break;
                    }
                    case "cvt ":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Cvt(io___raw_value, this, m_root);
                        break;
                    }
                    case "prep":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Prep(io___raw_value, this, m_root);
                        break;
                    }
                    case "kern":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Kern(io___raw_value, this, m_root);
                        break;
                    }
                    case "hhea":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Hhea(io___raw_value, this, m_root);
                        break;
                    }
                    case "post":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Post(io___raw_value, this, m_root);
                        break;
                    }
                    case "OS/2":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Os2(io___raw_value, this, m_root);
                        break;
                    }
                    case "name":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Name(io___raw_value, this, m_root);
                        break;
                    }
                    case "maxp":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Maxp(io___raw_value, this, m_root);
                        break;
                    }
                    case "glyf":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Glyf(io___raw_value, this, m_root);
                        break;
                    }
                    case "fpgm":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Fpgm(io___raw_value, this, m_root);
                        break;
                    }
                    case "cmap":
                    {
                        __raw_value = io.ReadBytes(Length);
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new Cmap(io___raw_value, this, m_root);
                        break;
                    }
                    default:
                    {
                        _value = io.ReadBytes(Length);
                        break;
                    }
                }
                io.Seek(_pos);
                f_value = true;
                return _value;
            }
        }
        private string _tag;
        private uint _checksum;
        private uint _offset;
        private uint _length;
        private Ttf m_root;
        private Ttf m_parent;
        private byte[] __raw_value;
        public string Tag { get { return _tag; } }
        public uint Checksum { get { return _checksum; } }
        public uint Offset { get { return _offset; } }
        public uint Length { get { return _length; } }
        public Ttf M_Root { get { return m_root; } }
        public Ttf M_Parent { get { return m_parent; } }
        public byte[] M_RawValue { get { return __raw_value; } }
    }

    public enum WeightClass
    {
        Thin = 100,
        ExtraLight = 200,
        Light = 300,
        Normal = 400,
        Medium = 500,
        SemiBold = 600,
        Bold = 700,
        ExtraBold = 800,
        Black = 900,
    }

    public enum WidthClass
    {
        UltraCondensed = 1,
        ExtraCondensed = 2,
        Condensed = 3,
        SemiCondensed = 4,
        Normal = 5,
        SemiExpanded = 6,
        Expanded = 7,
        ExtraExpanded = 8,
        UltraExpanded = 9,
    }

    public enum FsType
    {
        RestrictedLicenseEmbedding = 2,
        PreviewAndPrintEmbedding = 4,
        EditableEmbedding = 8,
    }

    public enum FsSelection
    {
        Italic = 1,
        Underscore = 2,
        Negative = 4,
        Outlined = 8,
        Strikeout = 16,
        Bold = 32,
        Regular = 64,
    }

    /// <summary>
    /// The OS/2 table consists of a set of metrics that are required by Windows and OS/2.
    /// </summary>
    public partial class Os2 : KaitaiStruct
    {
        public static Os2 FromFile(string fileName)
        {
            return new Os2(new KaitaiStream(fileName));
        }


       
        public Os2(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _version = m_io.ReadU2be();
            _xAvgCharWidth = m_io.ReadS2be();
            _weightClass = ((WeightClass)m_io.ReadU2be());
            _widthClass = ((WidthClass)m_io.ReadU2be());
            _fsType = ((FsType)m_io.ReadS2be());
            _ySubscriptXSize = m_io.ReadS2be();
            _ySubscriptYSize = m_io.ReadS2be();
            _ySubscriptXOffset = m_io.ReadS2be();
            _ySubscriptYOffset = m_io.ReadS2be();
            _ySuperscriptXSize = m_io.ReadS2be();
            _ySuperscriptYSize = m_io.ReadS2be();
            _ySuperscriptXOffset = m_io.ReadS2be();
            _ySuperscriptYOffset = m_io.ReadS2be();
            _yStrikeoutSize = m_io.ReadS2be();
            _yStrikeoutPosition = m_io.ReadS2be();
            _sFamilyClass = m_io.ReadS2be();
            _panose = new Panose(m_io, this, m_root);
            _unicodeRange = new UnicodeRange(m_io, this, m_root);
            _achVendId = System.Text.Encoding.GetEncoding("ascii").GetString(m_io.ReadBytes(4));
            _selection = ((FsSelection)m_io.ReadU2be());
            _firstCharIndex = m_io.ReadU2be();
            _lastCharIndex = m_io.ReadU2be();
            _typoAscender = m_io.ReadS2be();
            _typoDescender = m_io.ReadS2be();
            _typoLineGap = m_io.ReadS2be();
            _winAscent = m_io.ReadU2be();
            _winDescent = m_io.ReadU2be();
            _codePageRange = new CodePageRange(m_io, this, m_root);
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
        public ushort Version { get { return _version; } }

        /// <summary>
        /// The Average Character Width parameter specifies the arithmetic average of the escapement (width) of all of the 26 lowercase letters a through z of the Latin alphabet and the space character. If any of the 26 lowercase letters are not present, this parameter should equal the weighted average of all glyphs in the font. For non-UGL (platform 3, encoding 0) fonts, use the unweighted average.
        /// </summary>
        public short XAvgCharWidth { get { return _xAvgCharWidth; } }

        /// <summary>
        /// Indicates the visual weight (degree of blackness or thickness of strokes) of the characters in the font.
        /// </summary>
        public WeightClass WeightClass { get { return _weightClass; } }

        /// <summary>
        /// Indicates a relative change from the normal aspect ratio (width to height ratio) as specified by a font designer for the glyphs in a font.
        /// </summary>
        public WidthClass WidthClass { get { return _widthClass; } }

        /// <summary>
        /// Indicates font embedding licensing rights for the font. Embeddable fonts may be stored in a document. When a document with embedded fonts is opened on a system that does not have the font installed (the remote system), the embedded font may be loaded for temporary (and in some cases, permanent) use on that system by an embedding-aware application. Embedding licensing rights are granted by the vendor of the font.
        /// </summary>
        public FsType FsType { get { return _fsType; } }

        /// <summary>
        /// The recommended horizontal size in font design units for subscripts for this font.
        /// </summary>
        public short YSubscriptXSize { get { return _ySubscriptXSize; } }

        /// <summary>
        /// The recommended vertical size in font design units for subscripts for this font.
        /// </summary>
        public short YSubscriptYSize { get { return _ySubscriptYSize; } }

        /// <summary>
        /// The recommended horizontal offset in font design untis for subscripts for this font.
        /// </summary>
        public short YSubscriptXOffset { get { return _ySubscriptXOffset; } }

        /// <summary>
        /// The recommended vertical offset in font design units from the baseline for subscripts for this font.
        /// </summary>
        public short YSubscriptYOffset { get { return _ySubscriptYOffset; } }

        /// <summary>
        /// The recommended horizontal size in font design units for superscripts for this font.
        /// </summary>
        public short YSuperscriptXSize { get { return _ySuperscriptXSize; } }

        /// <summary>
        /// The recommended vertical size in font design units for superscripts for this font.
        /// </summary>
        public short YSuperscriptYSize { get { return _ySuperscriptYSize; } }

        /// <summary>
        /// The recommended horizontal offset in font design units for superscripts for this font.
        /// </summary>
        public short YSuperscriptXOffset { get { return _ySuperscriptXOffset; } }

        /// <summary>
        /// The recommended vertical offset in font design units from the baseline for superscripts for this font.
        /// </summary>
        public short YSuperscriptYOffset { get { return _ySuperscriptYOffset; } }

        /// <summary>
        /// Width of the strikeout stroke in font design units.
        /// </summary>
        public short YStrikeoutSize { get { return _yStrikeoutSize; } }

        /// <summary>
        /// The position of the strikeout stroke relative to the baseline in font design units.
        /// </summary>
        public short YStrikeoutPosition { get { return _yStrikeoutPosition; } }

        /// <summary>
        /// This parameter is a classification of font-family design.
        /// </summary>
        public short SFamilyClass { get { return _sFamilyClass; } }
        public Panose Panose { get { return _panose; } }
        public UnicodeRange UnicodeRange { get { return _unicodeRange; } }

        /// <summary>
        /// The four character identifier for the vendor of the given type face.
        /// </summary>
        public string AchVendId { get { return _achVendId; } }

        /// <summary>
        /// Contains information concerning the nature of the font patterns
        /// </summary>
        public FsSelection Selection { get { return _selection; } }

        /// <summary>
        /// The minimum Unicode index (character code) in this font, according to the cmap subtable for platform ID 3 and encoding ID 0 or 1.
        /// </summary>
        public ushort FirstCharIndex { get { return _firstCharIndex; } }

        /// <summary>
        /// The maximum Unicode index (character code) in this font, according to the cmap subtable for platform ID 3 and encoding ID 0 or 1.
        /// </summary>
        public ushort LastCharIndex { get { return _lastCharIndex; } }

        /// <summary>
        /// The typographic ascender for this font.
        /// </summary>
        public short TypoAscender { get { return _typoAscender; } }

        /// <summary>
        /// The typographic descender for this font.
        /// </summary>
        public short TypoDescender { get { return _typoDescender; } }

        /// <summary>
        /// The typographic line gap for this font.
        /// </summary>
        public short TypoLineGap { get { return _typoLineGap; } }

        /// <summary>
        /// The ascender metric for Windows.
        /// </summary>
        public ushort WinAscent { get { return _winAscent; } }

        /// <summary>
        /// The descender metric for Windows.
        /// </summary>
        public ushort WinDescent { get { return _winDescent; } }

        /// <summary>
        /// This field is used to specify the code pages encompassed by the font file in the `cmap` subtable for platform 3, encoding ID 1 (Microsoft platform).
        /// </summary>
        public CodePageRange CodePageRange { get { return _codePageRange; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class Fixed : KaitaiStruct
    {
        public static Fixed FromFile(string fileName)
        {
            return new Fixed(new KaitaiStream(fileName));
        }

        public Fixed(KaitaiStream p__io, KaitaiStruct p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _major = m_io.ReadU2be();
            _minor = m_io.ReadU2be();
        }
        private ushort _major;
        private ushort _minor;
        private Ttf m_root;
        private KaitaiStruct m_parent;
        public ushort Major { get { return _major; } }
        public ushort Minor { get { return _minor; } }
        public Ttf M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
    public partial class Glyf : KaitaiStruct
    {
        public static Glyf FromFile(string fileName)
        {
            return new Glyf(new KaitaiStream(fileName));
        }

        public Glyf(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _numberOfContours = m_io.ReadS2be();
            _xMin = m_io.ReadS2be();
            _yMin = m_io.ReadS2be();
            _xMax = m_io.ReadS2be();
            _yMax = m_io.ReadS2be();
            if (NumberOfContours > 0)
            {
                _value = new SimpleGlyph(m_io, this, m_root);
            }
        }
        public partial class SimpleGlyph : KaitaiStruct
        {
            public static SimpleGlyph FromFile(string fileName)
            {
                return new SimpleGlyph(new KaitaiStream(fileName));
            }

            public SimpleGlyph(KaitaiStream p__io, Glyf p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_pointCount = false;
                _read();
            }
            private void _read()
            {
                _endPtsOfContours = new List<ushort>((int)(M_Parent.NumberOfContours));
                for (var i = 0; i < M_Parent.NumberOfContours; i++)
                {
                    _endPtsOfContours.Add(m_io.ReadU2be());
                }
                _instructionLength = m_io.ReadU2be();
                _instructions = m_io.ReadBytes(InstructionLength);
                _flags = new List<Flag>((int)(PointCount));
                for (var i = 0; i < PointCount; i++)
                {
                    _flags.Add(new Flag(m_io, this, m_root));
                }
            }
            public partial class Flag : KaitaiStruct
            {
                public static Flag FromFile(string fileName)
                {
                    return new Flag(new KaitaiStream(fileName));
                }

                public Flag(KaitaiStream p__io, Glyf.SimpleGlyph p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    m_parent = p__parent;
                    m_root = p__root;
                    _read();
                }
                private void _read()
                {
                    _reserved = m_io.ReadBitsInt(2);
                    _yIsSame = m_io.ReadBitsInt(1) != 0;
                    _xIsSame = m_io.ReadBitsInt(1) != 0;
                    _repeat = m_io.ReadBitsInt(1) != 0;
                    _yShortVector = m_io.ReadBitsInt(1) != 0;
                    _xShortVector = m_io.ReadBitsInt(1) != 0;
                    _onCurve = m_io.ReadBitsInt(1) != 0;
                    m_io.AlignToByte();
                    if (Repeat)
                    {
                        _repeatValue = m_io.ReadU1();
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
                private Glyf.SimpleGlyph m_parent;
                public ulong Reserved { get { return _reserved; } }
                public bool YIsSame { get { return _yIsSame; } }
                public bool XIsSame { get { return _xIsSame; } }
                public bool Repeat { get { return _repeat; } }
                public bool YShortVector { get { return _yShortVector; } }
                public bool XShortVector { get { return _xShortVector; } }
                public bool OnCurve { get { return _onCurve; } }
                public byte? RepeatValue { get { return _repeatValue; } }
                public Ttf M_Root { get { return m_root; } }
                public Glyf.SimpleGlyph M_Parent { get { return m_parent; } }
            }
            private bool f_pointCount;
            private int _pointCount;
            public int PointCount
            {
                get
                {
                    if (f_pointCount)
                        return _pointCount;
                    _pointCount = (int)((EndPtsOfContours.Max() + 1));
                    f_pointCount = true;
                    return _pointCount;
                }
            }
            private List<ushort> _endPtsOfContours;
            private ushort _instructionLength;
            private byte[] _instructions;
            private List<Flag> _flags;
            private Ttf m_root;
            private Glyf m_parent;
            public List<ushort> EndPtsOfContours { get { return _endPtsOfContours; } }
            public ushort InstructionLength { get { return _instructionLength; } }
            public byte[] Instructions { get { return _instructions; } }
            public List<Flag> Flags { get { return _flags; } }
            public Ttf M_Root { get { return m_root; } }
            public Glyf M_Parent { get { return m_parent; } }
        }
        private short _numberOfContours;
        private short _xMin;
        private short _yMin;
        private short _xMax;
        private short _yMax;
        private SimpleGlyph _value;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public short NumberOfContours { get { return _numberOfContours; } }
        public short XMin { get { return _xMin; } }
        public short YMin { get { return _yMin; } }
        public short XMax { get { return _xMax; } }
        public short YMax { get { return _yMax; } }
        public SimpleGlyph Value { get { return _value; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }

    /// <summary>
    /// cvt  - Control Value Table This table contains a list of values that can be referenced by instructions. They can be used, among other things, to control characteristics for different glyphs.
    /// </summary>
    public partial class Cvt : KaitaiStruct
    {
        public static Cvt FromFile(string fileName)
        {
            return new Cvt(new KaitaiStream(fileName));
        }

        public Cvt(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _fwords = new List<short>();
            {
                var i = 0;
                while (!m_io.IsEof)
                {
                    _fwords.Add(m_io.ReadS2be());
                    i++;
                }
            }
        }
        private List<short> _fwords;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public List<short> Fwords { get { return _fwords; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class Maxp : KaitaiStruct
    {
        public static Maxp FromFile(string fileName)
        {
            return new Maxp(new KaitaiStream(fileName));
        }

        public Maxp(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _tableVersionNumber = new Fixed(m_io, this, m_root);
            _numGlyphs = m_io.ReadU2be();
            _maxPoints = m_io.ReadU2be();
            _maxContours = m_io.ReadU2be();
            _maxCompositePoints = m_io.ReadU2be();
            _maxCompositeContours = m_io.ReadU2be();
            _maxZones = m_io.ReadU2be();
            _maxTwilightPoints = m_io.ReadU2be();
            _maxStorage = m_io.ReadU2be();
            _maxFunctionDefs = m_io.ReadU2be();
            _maxInstructionDefs = m_io.ReadU2be();
            _maxStackElements = m_io.ReadU2be();
            _maxSizeOfInstructions = m_io.ReadU2be();
            _maxComponentElements = m_io.ReadU2be();
            _maxComponentDepth = m_io.ReadU2be();
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
        public Fixed TableVersionNumber { get { return _tableVersionNumber; } }

        /// <summary>
        /// The number of glyphs in the font.
        /// </summary>
        public ushort NumGlyphs { get { return _numGlyphs; } }

        /// <summary>
        /// Maximum points in a non-composite glyph.
        /// </summary>
        public ushort MaxPoints { get { return _maxPoints; } }

        /// <summary>
        /// Maximum contours in a non-composite glyph.
        /// </summary>
        public ushort MaxContours { get { return _maxContours; } }

        /// <summary>
        /// Maximum points in a composite glyph.
        /// </summary>
        public ushort MaxCompositePoints { get { return _maxCompositePoints; } }

        /// <summary>
        /// Maximum contours in a composite glyph.
        /// </summary>
        public ushort MaxCompositeContours { get { return _maxCompositeContours; } }

        /// <summary>
        /// 1 if instructions do not use the twilight zone (Z0), or 2 if instructions do use Z0; should be set to 2 in most cases.
        /// </summary>
        public ushort MaxZones { get { return _maxZones; } }

        /// <summary>
        /// Maximum points used in Z0.
        /// </summary>
        public ushort MaxTwilightPoints { get { return _maxTwilightPoints; } }

        /// <summary>
        /// Number of Storage Area locations.
        /// </summary>
        public ushort MaxStorage { get { return _maxStorage; } }

        /// <summary>
        /// Number of FDEFs.
        /// </summary>
        public ushort MaxFunctionDefs { get { return _maxFunctionDefs; } }

        /// <summary>
        /// Number of IDEFs.
        /// </summary>
        public ushort MaxInstructionDefs { get { return _maxInstructionDefs; } }

        /// <summary>
        /// Maximum stack depth.
        /// </summary>
        public ushort MaxStackElements { get { return _maxStackElements; } }

        /// <summary>
        /// Maximum byte count for glyph instructions.
        /// </summary>
        public ushort MaxSizeOfInstructions { get { return _maxSizeOfInstructions; } }

        /// <summary>
        /// Maximum number of components referenced at &quot;top level&quot; for any composite glyph.
        /// </summary>
        public ushort MaxComponentElements { get { return _maxComponentElements; } }

        /// <summary>
        /// Maximum levels of recursion; 1 for simple components.
        /// </summary>
        public ushort MaxComponentDepth { get { return _maxComponentDepth; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }
    public partial class OffsetTable : KaitaiStruct
    {
        public static OffsetTable FromFile(string fileName)
        {
            return new OffsetTable(new KaitaiStream(fileName));
        }

        public OffsetTable(KaitaiStream p__io, Ttf p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _sfntVersion = new Fixed(m_io, this, m_root);
            _numTables = m_io.ReadU2be();
            _searchRange = m_io.ReadU2be();
            _entrySelector = m_io.ReadU2be();
            _rangeShift = m_io.ReadU2be();
        }
        private Fixed _sfntVersion;
        private ushort _numTables;
        private ushort _searchRange;
        private ushort _entrySelector;
        private ushort _rangeShift;
        private Ttf m_root;
        private Ttf m_parent;
        public Fixed SfntVersion { get { return _sfntVersion; } }
        public ushort NumTables { get { return _numTables; } }
        public ushort SearchRange { get { return _searchRange; } }
        public ushort EntrySelector { get { return _entrySelector; } }
        public ushort RangeShift { get { return _rangeShift; } }
        public Ttf M_Root { get { return m_root; } }
        public Ttf M_Parent { get { return m_parent; } }
    }

    /// <summary>
    /// cmap - Character To Glyph Index Mapping Table This table defines the mapping of character codes to the glyph index values used in the font.
    /// </summary>
    public partial class Cmap : KaitaiStruct
    {
        public static Cmap FromFile(string fileName)
        {
            return new Cmap(new KaitaiStream(fileName));
        }

        public Cmap(KaitaiStream p__io, DirTableEntry p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root;
            _read();
        }
        private void _read()
        {
            _versionNumber = m_io.ReadU2be();
            _numberOfEncodingTables = m_io.ReadU2be();
            _tables = new List<SubtableHeader>((int)(NumberOfEncodingTables));
            for (var i = 0; i < NumberOfEncodingTables; i++)
            {
                _tables.Add(new SubtableHeader(m_io, this, m_root));
            }
        }
        public partial class SubtableHeader : KaitaiStruct
        {
            public static SubtableHeader FromFile(string fileName)
            {
                return new SubtableHeader(new KaitaiStream(fileName));
            }

            public SubtableHeader(KaitaiStream p__io, Cmap p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_table = false;
                _read();
            }
            private void _read()
            {
                _platformId = m_io.ReadU2be();
                _encodingId = m_io.ReadU2be();
                _subtableOffset = m_io.ReadU4be();
            }
            private bool f_table;
            private Subtable _table;
            public Subtable Table
            {
                get
                {
                    if (f_table)
                        return _table;
                    KaitaiStream io = M_Parent.M_Io;
                    long _pos = io.Pos;
                    io.Seek(SubtableOffset);
                    _table = new Subtable(io, this, m_root);
                    io.Seek(_pos);
                    f_table = true;
                    return _table;
                }
            }
            private ushort _platformId;
            private ushort _encodingId;
            private uint _subtableOffset;
            private Ttf m_root;
            private Cmap m_parent;
            public ushort PlatformId { get { return _platformId; } }
            public ushort EncodingId { get { return _encodingId; } }
            public uint SubtableOffset { get { return _subtableOffset; } }
            public Ttf M_Root { get { return m_root; } }
            public Cmap M_Parent { get { return m_parent; } }
        }
        public partial class Subtable : KaitaiStruct
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
                TrimmedTableMapping = 6,
            }
            public Subtable(KaitaiStream p__io, Cmap.SubtableHeader p__parent = null, Ttf p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _format = ((SubtableFormat)m_io.ReadU2be());
                _length = m_io.ReadU2be();
                _version = m_io.ReadU2be();
                switch (Format)
                {
                    case SubtableFormat.ByteEncodingTable:
                    {
                        __raw_value = m_io.ReadBytes((Length - 6));
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new ByteEncodingTable(io___raw_value, this, m_root);
                        break;
                    }
                    case SubtableFormat.HighByteMappingThroughTable:
                    {
                        __raw_value = m_io.ReadBytes((Length - 6));
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new HighByteMappingThroughTable(io___raw_value, this, m_root);
                        break;
                    }
                    case SubtableFormat.TrimmedTableMapping:
                    {
                        __raw_value = m_io.ReadBytes((Length - 6));
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new TrimmedTableMapping(io___raw_value, this, m_root);
                        break;
                    }
                    case SubtableFormat.SegmentMappingToDeltaValues:
                    {
                        __raw_value = m_io.ReadBytes((Length - 6));
                        var io___raw_value = new KaitaiStream(__raw_value);
                        _value = new SegmentMappingToDeltaValues(io___raw_value, this, m_root);
                        break;
                    }
                    default:
                    {
                        _value = m_io.ReadBytes((Length - 6));
                        break;
                    }
                }
            }
            public partial class ByteEncodingTable : KaitaiStruct
            {
                public static ByteEncodingTable FromFile(string fileName)
                {
                    return new ByteEncodingTable(new KaitaiStream(fileName));
                }

                public ByteEncodingTable(KaitaiStream p__io, Cmap.Subtable p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    m_parent = p__parent;
                    m_root = p__root;
                    _read();
                }
                private void _read()
                {
                    _glyphIdArray = m_io.ReadBytes(256);
                }
                private byte[] _glyphIdArray;
                private Ttf m_root;
                private Cmap.Subtable m_parent;
                public byte[] GlyphIdArray { get { return _glyphIdArray; } }
                public Ttf M_Root { get { return m_root; } }
                public Cmap.Subtable M_Parent { get { return m_parent; } }
            }
            public partial class HighByteMappingThroughTable : KaitaiStruct
            {
                public static HighByteMappingThroughTable FromFile(string fileName)
                {
                    return new HighByteMappingThroughTable(new KaitaiStream(fileName));
                }

                public HighByteMappingThroughTable(KaitaiStream p__io, Cmap.Subtable p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    m_parent = p__parent;
                    m_root = p__root;
                    _read();
                }
                private void _read()
                {
                    _subHeaderKeys = new List<ushort>((int)(256));
                    for (var i = 0; i < 256; i++)
                    {
                        _subHeaderKeys.Add(m_io.ReadU2be());
                    }
                }
                private List<ushort> _subHeaderKeys;
                private Ttf m_root;
                private Cmap.Subtable m_parent;
                public List<ushort> SubHeaderKeys { get { return _subHeaderKeys; } }
                public Ttf M_Root { get { return m_root; } }
                public Cmap.Subtable M_Parent { get { return m_parent; } }
            }
            public partial class SegmentMappingToDeltaValues : KaitaiStruct
            {
                public static SegmentMappingToDeltaValues FromFile(string fileName)
                {
                    return new SegmentMappingToDeltaValues(new KaitaiStream(fileName));
                }

                public SegmentMappingToDeltaValues(KaitaiStream p__io, Cmap.Subtable p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    m_parent = p__parent;
                    m_root = p__root;
                    f_segCount = false;
                    _read();
                }
                private void _read()
                {
                    _segCountX2 = m_io.ReadU2be();
                    _searchRange = m_io.ReadU2be();
                    _entrySelector = m_io.ReadU2be();
                    _rangeShift = m_io.ReadU2be();
                    _endCount = new List<ushort>((int)(SegCount));
                    for (var i = 0; i < SegCount; i++)
                    {
                        _endCount.Add(m_io.ReadU2be());
                    }
                    _reservedPad = m_io.ReadU2be();
                    _startCount = new List<ushort>((int)(SegCount));
                    for (var i = 0; i < SegCount; i++)
                    {
                        _startCount.Add(m_io.ReadU2be());
                    }
                    _idDelta = new List<ushort>((int)(SegCount));
                    for (var i = 0; i < SegCount; i++)
                    {
                        _idDelta.Add(m_io.ReadU2be());
                    }
                    _idRangeOffset = new List<ushort>((int)(SegCount));
                    for (var i = 0; i < SegCount; i++)
                    {
                        _idRangeOffset.Add(m_io.ReadU2be());
                    }
                    _glyphIdArray = new List<ushort>();
                    {
                        var i = 0;
                        while (!m_io.IsEof)
                        {
                            _glyphIdArray.Add(m_io.ReadU2be());
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
                        if (f_segCount)
                            return _segCount;
                        _segCount = (int)((SegCountX2 / 2));
                        f_segCount = true;
                        return _segCount;
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
                private Cmap.Subtable m_parent;
                public ushort SegCountX2 { get { return _segCountX2; } }
                public ushort SearchRange { get { return _searchRange; } }
                public ushort EntrySelector { get { return _entrySelector; } }
                public ushort RangeShift { get { return _rangeShift; } }
                public List<ushort> EndCount { get { return _endCount; } }
                public ushort ReservedPad { get { return _reservedPad; } }
                public List<ushort> StartCount { get { return _startCount; } }
                public List<ushort> IdDelta { get { return _idDelta; } }
                public List<ushort> IdRangeOffset { get { return _idRangeOffset; } }
                public List<ushort> GlyphIdArray { get { return _glyphIdArray; } }
                public Ttf M_Root { get { return m_root; } }
                public Cmap.Subtable M_Parent { get { return m_parent; } }
            }
            public partial class TrimmedTableMapping : KaitaiStruct
            {
                public static TrimmedTableMapping FromFile(string fileName)
                {
                    return new TrimmedTableMapping(new KaitaiStream(fileName));
                }

                public TrimmedTableMapping(KaitaiStream p__io, Cmap.Subtable p__parent = null, Ttf p__root = null) : base(p__io)
                {
                    m_parent = p__parent;
                    m_root = p__root;
                    _read();
                }
                private void _read()
                {
                    _firstCode = m_io.ReadU2be();
                    _entryCount = m_io.ReadU2be();
                    _glyphIdArray = new List<ushort>((int)(EntryCount));
                    for (var i = 0; i < EntryCount; i++)
                    {
                        _glyphIdArray.Add(m_io.ReadU2be());
                    }
                }
                private ushort _firstCode;
                private ushort _entryCount;
                private List<ushort> _glyphIdArray;
                private Ttf m_root;
                private Cmap.Subtable m_parent;
                public ushort FirstCode { get { return _firstCode; } }
                public ushort EntryCount { get { return _entryCount; } }
                public List<ushort> GlyphIdArray { get { return _glyphIdArray; } }
                public Ttf M_Root { get { return m_root; } }
                public Cmap.Subtable M_Parent { get { return m_parent; } }
            }
            private SubtableFormat _format;
            private ushort _length;
            private ushort _version;
            private object _value;
            private Ttf m_root;
            private Cmap.SubtableHeader m_parent;
            private byte[] __raw_value;
            public SubtableFormat Format { get { return _format; } }
            public ushort Length { get { return _length; } }
            public ushort Version { get { return _version; } }
            public object Value { get { return _value; } }
            public Ttf M_Root { get { return m_root; } }
            public Cmap.SubtableHeader M_Parent { get { return m_parent; } }
            public byte[] M_RawValue { get { return __raw_value; } }
        }
        private ushort _versionNumber;
        private ushort _numberOfEncodingTables;
        private List<SubtableHeader> _tables;
        private Ttf m_root;
        private DirTableEntry m_parent;
        public ushort VersionNumber { get { return _versionNumber; } }
        public ushort NumberOfEncodingTables { get { return _numberOfEncodingTables; } }
        public List<SubtableHeader> Tables { get { return _tables; } }
        public Ttf M_Root { get { return m_root; } }
        public DirTableEntry M_Parent { get { return m_parent; } }
    }

    public class Ttf : KaitaiStruct
    {
        public static Ttf FromFile(string fileName)
        {
            return new Ttf(new KaitaiStream(fileName));
        }

        public Ttf(KaitaiStream p__io, KaitaiStruct p__parent = null, Ttf p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _offsetTable = new OffsetTable(m_io, this, m_root);
            _directoryTable = new List<DirTableEntry>((int) (OffsetTable.NumTables));
            for (var i = 0; i < OffsetTable.NumTables; i++)
            {
                _directoryTable.Add(new DirTableEntry(m_io, this, m_root));
            }
        }
      

       
        private OffsetTable _offsetTable;
        private List<DirTableEntry> _directoryTable;
        private Ttf m_root;
        private KaitaiStruct m_parent;
        public OffsetTable OffsetTable { get { return _offsetTable; } }
        public List<DirTableEntry> DirectoryTable { get { return _directoryTable; } }
        public Ttf M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
