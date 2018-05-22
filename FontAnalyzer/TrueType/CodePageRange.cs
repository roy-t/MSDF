// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild


using Kaitai;

namespace FontAnalyzer.TrueType
{
    public class CodePageRange : KaitaiStruct
    {
        public static CodePageRange FromFile(string fileName)
        {
            return new CodePageRange(new KaitaiStream(fileName));
        }

        public CodePageRange(KaitaiStream p__io, Os2 p__parent = null, Ttf p__root = null) : base(p__io)
        {
            this.m_parent = p__parent;
            this.m_root = p__root;
            _read();
        }
        private void _read()
        {
            this._symbolCharacterSet = this.m_io.ReadBitsInt(1) != 0;
            this._oemCharacterSet = this.m_io.ReadBitsInt(1) != 0;
            this._macintoshCharacterSet = this.m_io.ReadBitsInt(1) != 0;
            this._reservedForAlternateAnsiOem = this.m_io.ReadBitsInt(7);
            this._cp1361KoreanJohab = this.m_io.ReadBitsInt(1) != 0;
            this._cp950ChineseTraditionalCharsTaiwanAndHongKong = this.m_io.ReadBitsInt(1) != 0;
            this._cp949KoreanWansung = this.m_io.ReadBitsInt(1) != 0;
            this._cp936ChineseSimplifiedCharsPrcAndSingapore = this.m_io.ReadBitsInt(1) != 0;
            this._cp932JisJapan = this.m_io.ReadBitsInt(1) != 0;
            this._cp874Thai = this.m_io.ReadBitsInt(1) != 0;
            this._reservedForAlternateAnsi = this.m_io.ReadBitsInt(8);
            this._cp1257WindowsBaltic = this.m_io.ReadBitsInt(1) != 0;
            this._cp1256Arabic = this.m_io.ReadBitsInt(1) != 0;
            this._cp1255Hebrew = this.m_io.ReadBitsInt(1) != 0;
            this._cp1254Turkish = this.m_io.ReadBitsInt(1) != 0;
            this._cp1253Greek = this.m_io.ReadBitsInt(1) != 0;
            this._cp1251Cyrillic = this.m_io.ReadBitsInt(1) != 0;
            this._cp1250Latin2EasternEurope = this.m_io.ReadBitsInt(1) != 0;
            this._cp1252Latin1 = this.m_io.ReadBitsInt(1) != 0;
            this._cp437Us = this.m_io.ReadBitsInt(1) != 0;
            this._cp850WeLatin1 = this.m_io.ReadBitsInt(1) != 0;
            this._cp708ArabicAsmo708 = this.m_io.ReadBitsInt(1) != 0;
            this._cp737GreekFormer437G = this.m_io.ReadBitsInt(1) != 0;
            this._cp775MsDosBaltic = this.m_io.ReadBitsInt(1) != 0;
            this._cp852Latin2 = this.m_io.ReadBitsInt(1) != 0;
            this._cp855IbmCyrillicPrimarilyRussian = this.m_io.ReadBitsInt(1) != 0;
            this._cp857IbmTurkish = this.m_io.ReadBitsInt(1) != 0;
            this._cp860MsDosPortuguese = this.m_io.ReadBitsInt(1) != 0;
            this._cp861MsDosIcelandic = this.m_io.ReadBitsInt(1) != 0;
            this._cp862Hebrew = this.m_io.ReadBitsInt(1) != 0;
            this._cp863MsDosCanadianFrench = this.m_io.ReadBitsInt(1) != 0;
            this._cp864Arabic = this.m_io.ReadBitsInt(1) != 0;
            this._cp865MsDosNordic = this.m_io.ReadBitsInt(1) != 0;
            this._cp866MsDosRussian = this.m_io.ReadBitsInt(1) != 0;
            this._cp869IbmGreek = this.m_io.ReadBitsInt(1) != 0;
            this._reservedForOem = this.m_io.ReadBitsInt(16);
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
        public bool SymbolCharacterSet { get { return this._symbolCharacterSet; } }
        public bool OemCharacterSet { get { return this._oemCharacterSet; } }
        public bool MacintoshCharacterSet { get { return this._macintoshCharacterSet; } }
        public ulong ReservedForAlternateAnsiOem { get { return this._reservedForAlternateAnsiOem; } }
        public bool Cp1361KoreanJohab { get { return this._cp1361KoreanJohab; } }
        public bool Cp950ChineseTraditionalCharsTaiwanAndHongKong { get { return this._cp950ChineseTraditionalCharsTaiwanAndHongKong; } }
        public bool Cp949KoreanWansung { get { return this._cp949KoreanWansung; } }
        public bool Cp936ChineseSimplifiedCharsPrcAndSingapore { get { return this._cp936ChineseSimplifiedCharsPrcAndSingapore; } }
        public bool Cp932JisJapan { get { return this._cp932JisJapan; } }
        public bool Cp874Thai { get { return this._cp874Thai; } }
        public ulong ReservedForAlternateAnsi { get { return this._reservedForAlternateAnsi; } }
        public bool Cp1257WindowsBaltic { get { return this._cp1257WindowsBaltic; } }
        public bool Cp1256Arabic { get { return this._cp1256Arabic; } }
        public bool Cp1255Hebrew { get { return this._cp1255Hebrew; } }
        public bool Cp1254Turkish { get { return this._cp1254Turkish; } }
        public bool Cp1253Greek { get { return this._cp1253Greek; } }
        public bool Cp1251Cyrillic { get { return this._cp1251Cyrillic; } }
        public bool Cp1250Latin2EasternEurope { get { return this._cp1250Latin2EasternEurope; } }
        public bool Cp1252Latin1 { get { return this._cp1252Latin1; } }
        public bool Cp437Us { get { return this._cp437Us; } }
        public bool Cp850WeLatin1 { get { return this._cp850WeLatin1; } }
        public bool Cp708ArabicAsmo708 { get { return this._cp708ArabicAsmo708; } }
        public bool Cp737GreekFormer437G { get { return this._cp737GreekFormer437G; } }
        public bool Cp775MsDosBaltic { get { return this._cp775MsDosBaltic; } }
        public bool Cp852Latin2 { get { return this._cp852Latin2; } }
        public bool Cp855IbmCyrillicPrimarilyRussian { get { return this._cp855IbmCyrillicPrimarilyRussian; } }
        public bool Cp857IbmTurkish { get { return this._cp857IbmTurkish; } }
        public bool Cp860MsDosPortuguese { get { return this._cp860MsDosPortuguese; } }
        public bool Cp861MsDosIcelandic { get { return this._cp861MsDosIcelandic; } }
        public bool Cp862Hebrew { get { return this._cp862Hebrew; } }
        public bool Cp863MsDosCanadianFrench { get { return this._cp863MsDosCanadianFrench; } }
        public bool Cp864Arabic { get { return this._cp864Arabic; } }
        public bool Cp865MsDosNordic { get { return this._cp865MsDosNordic; } }
        public bool Cp866MsDosRussian { get { return this._cp866MsDosRussian; } }
        public bool Cp869IbmGreek { get { return this._cp869IbmGreek; } }
        public ulong ReservedForOem { get { return this._reservedForOem; } }
        public Ttf M_Root { get { return this.m_root; } }
        public Os2 M_Parent { get { return this.m_parent; } }
    }
}
