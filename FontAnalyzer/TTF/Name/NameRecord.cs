using System;
using System.Globalization;
using FontAnalyzer.TTF.Cmap;

namespace FontAnalyzer.TTF.Name
{
    public class NameRecord
    {
        public static NameRecord FromReader(FontReader reader, long storageStart)
        {  
            // Currently always 0, but 
            var platformId = (Platform)reader.ReadUInt16BigEndian();
           


            var encodingId = reader.ReadUInt16BigEndian();

            if (platformId == Platform.Windows)
            {
                if (encodingId > 1) // Should be 0 for symbol fonts, 1 for unicode fonts
                {
                    throw new Exception("Unexpected encoding in name record");
                }
            }

            if (platformId == Platform.Macintosh)
            {
                if (encodingId != 0)
                {
                    throw new Exception("Unexpected encoding in name record");
                }
            }

            var languageId = reader.ReadUInt16BigEndian();
            var language = LanguageIdConverter.ToCulture(platformId, languageId);
            var nameId     = (NameId)reader.ReadUInt16BigEndian();
            var length     = reader.ReadUInt16BigEndian();
            var offset     = reader.ReadUInt16BigEndian();

            var end = reader.Position;

            reader.Seek(storageStart + offset);
            var text = ReadString(reader, platformId, encodingId, length);
            reader.Seek(end);

           

            return new NameRecord(platformId, encodingId, language, nameId, length, offset, text);
        }

        private static string ReadString(FontReader reader, Platform platform, ushort encodingId, ushort length)
        {

            if (platform == Platform.Windows || platform == Platform.Unicode)
            {
                // All unicode fonts on windows encode their name in the naming table using UTF16 Big Endian unicode.
                return reader.ReadBigEndianUnicode(length);
            }
            
            // platform is Mac

            // Mac uses the MacRoman character set for the names in a font. Unfortunately they
            // differ slightly from the ANSII character set, but for characters 32-126 they are identical
            // so we use ANSII encoding as a best effort to read the names
            return reader.ReadAscii(length);
        }

        public NameRecord(
            Platform platformId,
            ushort encodingId,
            CultureInfo language,
            NameId nameId,
            ushort length,
            ushort offset,
            string text)
        {
            this.PlatformId = platformId;
            this.EncodingId = encodingId;
            this.Language = language;
            this.NameId = nameId;
            this.Length = length;
            this.Offset = offset;
            this.Text = text;
        }

        public Platform PlatformId { get; }
        public ushort EncodingId { get; }
        public CultureInfo Language { get; }
        public NameId NameId { get; }
        public ushort Length { get; }
        public ushort Offset { get; }
        public string Text { get; }

        public override string ToString() => $"{this.NameId}:  {this.Text}";
    }
}