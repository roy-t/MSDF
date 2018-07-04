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

        /// <summary>
        /// Name of the font
        /// </summary>
        public string Name => this.NameBackend;
        
        /// <summary>
        /// Distance field effect range in pixels
        /// </summary>
        public float PxRange => this.PxRangeBackend;

        /// <summary>
        /// Kerning pairs available in this font
        /// </summary>
        public IReadOnlyList<KerningPair> KerningPairs => this.KerningPairsBackend;

        /// <summary>
        /// Characters supported by this font
        /// </summary>
        [ContentSerializerIgnore]
        public IEnumerable<char> SupportedCharacters => this.Glyphs.Keys;
       
        /// <summary>
        /// Returns the glyph for the given character, or throws an exception when the glyph is not supported by this font
        /// </summary>        
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
