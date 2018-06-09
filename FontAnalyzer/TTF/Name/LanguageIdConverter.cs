using System.Globalization;
using FontAnalyzer.TTF.Cmap;

namespace FontAnalyzer.TTF.Name
{
    public static class LanguageIdConverter
    {            
        public static CultureInfo ToCulture(Platform platform, ushort languageId)
        {
            if (platform == Platform.Windows)
            {
                return CultureInfo.GetCultureInfo(languageId);
            }
            
            if (platform == Platform.Macintosh)
            {
                return CultureInfo.GetCultureInfo(MacLangaugeIdToWindowsLanguageId(languageId));
            }

            return CultureInfo.InvariantCulture;            
        }

        private static ushort MacLangaugeIdToWindowsLanguageId(ushort macLanguageId)
        {
            switch (macLanguageId)
            {
                case 0: // English
                    return 0x0009;
                case 1: // French
                    return 0x00C;
                case 2: // German
                    return 0x0007;
                case 3: // Italian
                    return 0x0010;
                case 4: // Dutch
                    return 0x0013;
                case 5: // Swedish
                    return 0x001D;
                case 6: // Spanish
                    return 0x000A;
                case 7: // Danish
                    return 0x0006;
                case 8: // Portuguese
                    return 0x0016;
                case 9: // Norwegian
                    return 0x0014;

                // TODO: extend to all 150 locales supported by mac
                // Mac list: https://developer.apple.com/fonts/TrueType-Reference-Manual/RM06/Chap6name.html
                // Windows list: https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo(vs.71).aspx

                default:
                    return 0x007f; // Invariant culture
            }
        }
    }
}
