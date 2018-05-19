using Microsoft.Xna.Framework.Content;

namespace FontExtension
{    
    public class FieldGlyph
    {        
        [ContentSerializer]
        private readonly char CharacterBackend;

        [ContentSerializer]
        private readonly byte[] BitmapBackend;

        public FieldGlyph()
        {
           
        }

        public FieldGlyph(char character, byte[] bitmap)
        {
            this.CharacterBackend = character;
            this.BitmapBackend = bitmap;
        }
        
        public char Character => this.CharacterBackend;
        public byte[] Bitmap => this.BitmapBackend;
    }
}
