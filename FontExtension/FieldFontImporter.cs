using System.Linq;
using IniParser;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace FontExtension
{   
    [ContentImporter(".ini", DisplayName = "Field Font Importer", DefaultProcessor = "FieldFontProcessor")]
    public class FieldFontImporter : ContentImporter<FontDescription>
    {     
        public override FontDescription Import(string filename, ContentImporterContext context)
        {
            return Parse(filename);            
        }

        private static FontDescription Parse(string filename)
        {            
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(filename);

            var fontSection = data.Sections["font"];
            var path = fontSection["path"];
            var size = int.Parse(fontSection["size"]);

            var characterSection = data.Sections["characters"];
            var min = int.Parse(characterSection["min"]);
            var max = int.Parse(characterSection["max"]);


            var characters = Enumerable.Range(min, max - min + 1)
                .Select(i => (char) i)
                .ToArray();

            return new FontDescription(path, size, characters);
        }
    }

}
