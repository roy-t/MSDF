using System.Collections.Generic;
using System.Linq;

namespace FontExtension
{
    public class FontDescription
    {
        public FontDescription(string path, int size, params char[] characters)
        {
            this.Path = path;
            this.Size = size;
            this.Characters = characters.ToList().AsReadOnly();
        }

        public string Path { get; }
        public int Size { get; }
        public IReadOnlyList<char> Characters { get; }
    }
}
