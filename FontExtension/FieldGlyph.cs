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
        
        public char Character => this.CharacterBackend;
        public byte[] Bitmap => this.BitmapBackend;                
        public Metrics Metrics => this.MetricsBackend;
    }
}
