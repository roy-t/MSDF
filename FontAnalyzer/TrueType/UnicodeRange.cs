// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class UnicodeRange : KaitaiStruct
    {
        public static UnicodeRange FromFile(string fileName)
        {
            return new UnicodeRange(new KaitaiStream(fileName));
        }

        public UnicodeRange(KaitaiStream p__io, Os2 p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._basicLatin = this.m_io.ReadBitsInt(1) != 0;
            this._latin1Supplement = this.m_io.ReadBitsInt(1) != 0;
            this._latinExtendedA = this.m_io.ReadBitsInt(1) != 0;
            this._latinExtendedB = this.m_io.ReadBitsInt(1) != 0;
            this._ipaExtensions = this.m_io.ReadBitsInt(1) != 0;
            this._spacingModifierLetters = this.m_io.ReadBitsInt(1) != 0;
            this._combiningDiacriticalMarks = this.m_io.ReadBitsInt(1) != 0;
            this._basicGreek = this.m_io.ReadBitsInt(1) != 0;
            this._greekSymbolsAndCoptic = this.m_io.ReadBitsInt(1) != 0;
            this._cyrillic = this.m_io.ReadBitsInt(1) != 0;
            this._armenian = this.m_io.ReadBitsInt(1) != 0;
            this._basicHebrew = this.m_io.ReadBitsInt(1) != 0;
            this._hebrewExtended = this.m_io.ReadBitsInt(1) != 0;
            this._basicArabic = this.m_io.ReadBitsInt(1) != 0;
            this._arabicExtended = this.m_io.ReadBitsInt(1) != 0;
            this._devanagari = this.m_io.ReadBitsInt(1) != 0;
            this._bengali = this.m_io.ReadBitsInt(1) != 0;
            this._gurmukhi = this.m_io.ReadBitsInt(1) != 0;
            this._gujarati = this.m_io.ReadBitsInt(1) != 0;
            this._oriya = this.m_io.ReadBitsInt(1) != 0;
            this._tamil = this.m_io.ReadBitsInt(1) != 0;
            this._telugu = this.m_io.ReadBitsInt(1) != 0;
            this._kannada = this.m_io.ReadBitsInt(1) != 0;
            this._malayalam = this.m_io.ReadBitsInt(1) != 0;
            this._thai = this.m_io.ReadBitsInt(1) != 0;
            this._lao = this.m_io.ReadBitsInt(1) != 0;
            this._basicGeorgian = this.m_io.ReadBitsInt(1) != 0;
            this._georgianExtended = this.m_io.ReadBitsInt(1) != 0;
            this._hangulJamo = this.m_io.ReadBitsInt(1) != 0;
            this._latinExtendedAdditional = this.m_io.ReadBitsInt(1) != 0;
            this._greekExtended = this.m_io.ReadBitsInt(1) != 0;
            this._generalPunctuation = this.m_io.ReadBitsInt(1) != 0;
            this._superscriptsAndSubscripts = this.m_io.ReadBitsInt(1) != 0;
            this._currencySymbols = this.m_io.ReadBitsInt(1) != 0;
            this._combiningDiacriticalMarksForSymbols = this.m_io.ReadBitsInt(1) != 0;
            this._letterlikeSymbols = this.m_io.ReadBitsInt(1) != 0;
            this._numberForms = this.m_io.ReadBitsInt(1) != 0;
            this._arrows = this.m_io.ReadBitsInt(1) != 0;
            this._mathematicalOperators = this.m_io.ReadBitsInt(1) != 0;
            this._miscellaneousTechnical = this.m_io.ReadBitsInt(1) != 0;
            this._controlPictures = this.m_io.ReadBitsInt(1) != 0;
            this._opticalCharacterRecognition = this.m_io.ReadBitsInt(1) != 0;
            this._enclosedAlphanumerics = this.m_io.ReadBitsInt(1) != 0;
            this._boxDrawing = this.m_io.ReadBitsInt(1) != 0;
            this._blockElements = this.m_io.ReadBitsInt(1) != 0;
            this._geometricShapes = this.m_io.ReadBitsInt(1) != 0;
            this._miscellaneousSymbols = this.m_io.ReadBitsInt(1) != 0;
            this._dingbats = this.m_io.ReadBitsInt(1) != 0;
            this._cjkSymbolsAndPunctuation = this.m_io.ReadBitsInt(1) != 0;
            this._hiragana = this.m_io.ReadBitsInt(1) != 0;
            this._katakana = this.m_io.ReadBitsInt(1) != 0;
            this._bopomofo = this.m_io.ReadBitsInt(1) != 0;
            this._hangulCompatibilityJamo = this.m_io.ReadBitsInt(1) != 0;
            this._cjkMiscellaneous = this.m_io.ReadBitsInt(1) != 0;
            this._enclosedCjkLettersAndMonths = this.m_io.ReadBitsInt(1) != 0;
            this._cjkCompatibility = this.m_io.ReadBitsInt(1) != 0;
            this._hangul = this.m_io.ReadBitsInt(1) != 0;
            this._reservedForUnicodeSubranges1 = this.m_io.ReadBitsInt(1) != 0;
            this._reservedForUnicodeSubranges2 = this.m_io.ReadBitsInt(1) != 0;
            this._cjkUnifiedIdeographs = this.m_io.ReadBitsInt(1) != 0;
            this._privateUseArea = this.m_io.ReadBitsInt(1) != 0;
            this._cjkCompatibilityIdeographs = this.m_io.ReadBitsInt(1) != 0;
            this._alphabeticPresentationForms = this.m_io.ReadBitsInt(1) != 0;
            this._arabicPresentationFormsA = this.m_io.ReadBitsInt(1) != 0;
            this._combiningHalfMarks = this.m_io.ReadBitsInt(1) != 0;
            this._cjkCompatibilityForms = this.m_io.ReadBitsInt(1) != 0;
            this._smallFormVariants = this.m_io.ReadBitsInt(1) != 0;
            this._arabicPresentationFormsB = this.m_io.ReadBitsInt(1) != 0;
            this._halfwidthAndFullwidthForms = this.m_io.ReadBitsInt(1) != 0;
            this._specials = this.m_io.ReadBitsInt(1) != 0;
            this.m_io.AlignToByte();
            this._reserved = this.m_io.ReadBytes(7);
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
        public bool BasicLatin { get { return this._basicLatin; } }
        public bool Latin1Supplement { get { return this._latin1Supplement; } }
        public bool LatinExtendedA { get { return this._latinExtendedA; } }
        public bool LatinExtendedB { get { return this._latinExtendedB; } }
        public bool IpaExtensions { get { return this._ipaExtensions; } }
        public bool SpacingModifierLetters { get { return this._spacingModifierLetters; } }
        public bool CombiningDiacriticalMarks { get { return this._combiningDiacriticalMarks; } }
        public bool BasicGreek { get { return this._basicGreek; } }
        public bool GreekSymbolsAndCoptic { get { return this._greekSymbolsAndCoptic; } }
        public bool Cyrillic { get { return this._cyrillic; } }
        public bool Armenian { get { return this._armenian; } }
        public bool BasicHebrew { get { return this._basicHebrew; } }
        public bool HebrewExtended { get { return this._hebrewExtended; } }
        public bool BasicArabic { get { return this._basicArabic; } }
        public bool ArabicExtended { get { return this._arabicExtended; } }
        public bool Devanagari { get { return this._devanagari; } }
        public bool Bengali { get { return this._bengali; } }
        public bool Gurmukhi { get { return this._gurmukhi; } }
        public bool Gujarati { get { return this._gujarati; } }
        public bool Oriya { get { return this._oriya; } }
        public bool Tamil { get { return this._tamil; } }
        public bool Telugu { get { return this._telugu; } }
        public bool Kannada { get { return this._kannada; } }
        public bool Malayalam { get { return this._malayalam; } }
        public bool Thai { get { return this._thai; } }
        public bool Lao { get { return this._lao; } }
        public bool BasicGeorgian { get { return this._basicGeorgian; } }
        public bool GeorgianExtended { get { return this._georgianExtended; } }
        public bool HangulJamo { get { return this._hangulJamo; } }
        public bool LatinExtendedAdditional { get { return this._latinExtendedAdditional; } }
        public bool GreekExtended { get { return this._greekExtended; } }
        public bool GeneralPunctuation { get { return this._generalPunctuation; } }
        public bool SuperscriptsAndSubscripts { get { return this._superscriptsAndSubscripts; } }
        public bool CurrencySymbols { get { return this._currencySymbols; } }
        public bool CombiningDiacriticalMarksForSymbols { get { return this._combiningDiacriticalMarksForSymbols; } }
        public bool LetterlikeSymbols { get { return this._letterlikeSymbols; } }
        public bool NumberForms { get { return this._numberForms; } }
        public bool Arrows { get { return this._arrows; } }
        public bool MathematicalOperators { get { return this._mathematicalOperators; } }
        public bool MiscellaneousTechnical { get { return this._miscellaneousTechnical; } }
        public bool ControlPictures { get { return this._controlPictures; } }
        public bool OpticalCharacterRecognition { get { return this._opticalCharacterRecognition; } }
        public bool EnclosedAlphanumerics { get { return this._enclosedAlphanumerics; } }
        public bool BoxDrawing { get { return this._boxDrawing; } }
        public bool BlockElements { get { return this._blockElements; } }
        public bool GeometricShapes { get { return this._geometricShapes; } }
        public bool MiscellaneousSymbols { get { return this._miscellaneousSymbols; } }
        public bool Dingbats { get { return this._dingbats; } }
        public bool CjkSymbolsAndPunctuation { get { return this._cjkSymbolsAndPunctuation; } }
        public bool Hiragana { get { return this._hiragana; } }
        public bool Katakana { get { return this._katakana; } }
        public bool Bopomofo { get { return this._bopomofo; } }
        public bool HangulCompatibilityJamo { get { return this._hangulCompatibilityJamo; } }
        public bool CjkMiscellaneous { get { return this._cjkMiscellaneous; } }
        public bool EnclosedCjkLettersAndMonths { get { return this._enclosedCjkLettersAndMonths; } }
        public bool CjkCompatibility { get { return this._cjkCompatibility; } }
        public bool Hangul { get { return this._hangul; } }
        public bool ReservedForUnicodeSubranges1 { get { return this._reservedForUnicodeSubranges1; } }
        public bool ReservedForUnicodeSubranges2 { get { return this._reservedForUnicodeSubranges2; } }
        public bool CjkUnifiedIdeographs { get { return this._cjkUnifiedIdeographs; } }
        public bool PrivateUseArea { get { return this._privateUseArea; } }
        public bool CjkCompatibilityIdeographs { get { return this._cjkCompatibilityIdeographs; } }
        public bool AlphabeticPresentationForms { get { return this._alphabeticPresentationForms; } }
        public bool ArabicPresentationFormsA { get { return this._arabicPresentationFormsA; } }
        public bool CombiningHalfMarks { get { return this._combiningHalfMarks; } }
        public bool CjkCompatibilityForms { get { return this._cjkCompatibilityForms; } }
        public bool SmallFormVariants { get { return this._smallFormVariants; } }
        public bool ArabicPresentationFormsB { get { return this._arabicPresentationFormsB; } }
        public bool HalfwidthAndFullwidthForms { get { return this._halfwidthAndFullwidthForms; } }
        public bool Specials { get { return this._specials; } }
        public byte[] Reserved { get { return this._reserved; } }
        public Ttf M_Root { get { return this.m_root; } }
        public Os2 M_Parent { get { return this.m_parent; } }
    }
}
