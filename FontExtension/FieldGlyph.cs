using Microsoft.Xna.Framework.Content;

namespace FontExtension
{    
    public class FieldGlyph
    {        
        [ContentSerializer] private readonly char CharacterBackend;
        [ContentSerializer] private readonly byte[] BitmapBackend;
        [ContentSerializer] private readonly Metrics MetricsBackend;

        public FieldGlyph()
        {
           
        }

        public FieldGlyph(char character, byte[] bitmap, Metrics metrics)
        {
            this.CharacterBackend = character;
            this.BitmapBackend = bitmap;
            this.MetricsBackend = metrics;
        }
        
        /// <summary>
        /// The character this glyph represents
        /// </summary>
        public char Character => this.CharacterBackend;
        /// <summary>
        /// Distance field for this character
        /// </summary>
        public byte[] Bitmap => this.BitmapBackend;                
        /// <summary>
        /// Metrics for this character
        /// </summary>
        public Metrics Metrics => this.MetricsBackend;
    }
}
