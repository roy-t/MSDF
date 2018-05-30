using System.IO;
using FontAnalyzer.TTF.Cmap;

namespace FontAnalyzer.TTF.Name
{
    public class NameRecord
    {
        public static NameRecord FromReader(FontReader reader, long storageStart)
        {            
            var platformId = reader.ReadUInt16BigEndian();
            var encodingId = (UnicodeEncoding)reader.ReadUInt16BigEndian();
            var languageId = reader.ReadUInt16BigEndian();
            var nameId     = reader.ReadUInt16BigEndian();
            var length     = reader.ReadUInt16BigEndian();
            var offset     = reader.ReadUInt16BigEndian();

            var end = reader.Position;

            reader.Seek(storageStart + offset);
            var text = ReadString(reader, encodingId, length);
            reader.Seek(end);

           
            return new NameRecord(platformId, encodingId, languageId, nameId, length, offset, text);
        }

        private static string ReadString(FontReader reader, UnicodeEncoding encodingId, ushort length)
        {
            switch (encodingId)
            {
                case UnicodeEncoding.UnicodeSemantics1_1:
                case UnicodeEncoding.UnicodeSemanticsBitmap2_0:
                    return reader.ReadBigEndianUnicode(length);
                default:
                    return reader.ReadUTF8(length);
            }
        }

        public NameRecord(
            ushort platformId,
            UnicodeEncoding encodingId,
            ushort languageId,
            ushort nameId,
            ushort length,
            ushort offset,
            string text)
        {
            this.PlatformId = platformId;
            this.EncodingId = encodingId;
            this.LanguageId = languageId;
            this.NameId = nameId;
            this.Length = length;
            this.Offset = offset;
            this.Text = text;
        }

        public ushort PlatformId { get; }
        public UnicodeEncoding EncodingId { get; }
        public ushort LanguageId { get; }
        public ushort NameId { get; }
        public ushort Length { get; }
        public ushort Offset { get; }
        public string Text { get; }

        public override string ToString() => this.Text;
    }
}