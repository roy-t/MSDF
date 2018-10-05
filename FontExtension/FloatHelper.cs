using System.Globalization;

namespace FontExtension
{
    public static class FloatHelper
    {
        public static float ParseInvariant(string value) => float.Parse(value, CultureInfo.InvariantCulture);
    }
}
