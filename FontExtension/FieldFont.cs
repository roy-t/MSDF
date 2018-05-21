using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Content;

namespace FontExtension
{
    public class FieldFont
    {
        [ContentSerializer] private readonly Dictionary<char, FieldGlyph> Glyphs;
        [ContentSerializer] private readonly string NameBackend;
        [ContentSerializer] private readonly float PxRangeBackend;
        [ContentSerializer] private readonly List<KerningPair> KerningPairsBackend;

        public FieldFont()
        {            
        }

        public FieldFont(string name, IReadOnlyCollection<FieldGlyph> glyphs, IReadOnlyCollection<KerningPair> kerningPairs, float pxRange)
        {
            this.NameBackend = name;
            this.PxRangeBackend = pxRange;
            this.KerningPairsBackend = kerningPairs.ToList();

            this.Glyphs = new Dictionary<char, FieldGlyph>(glyphs.Count);
            foreach (var glyph in glyphs)
            {
                this.Glyphs.Add(glyph.Character, glyph);
            }
        }

        public string Name => this.NameBackend;
        public float PxRange => this.PxRangeBackend;
        public IReadOnlyList<KerningPair> KerningPairs => this.KerningPairsBackend;

        [ContentSerializerIgnore]
        public IEnumerable<char> SupportedCharacters => this.Glyphs.Keys;
       
        public FieldGlyph GetGlyph(char c)
        {
            if (this.Glyphs.TryGetValue(c, out FieldGlyph glyph))
            {
                return glyph;
            }

            throw new InvalidOperationException($"Character '{c}' not found in font {this.Name}. Did you forget to include it in the character ranges?");
        }
    }
}
