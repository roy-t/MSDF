using FontExtension;
using Microsoft.Xna.Framework.Graphics;

namespace MonoMSDF.Text
{
    public sealed class GlyphRenderInfo
    {
        public char Character { get; }
        public Texture2D Texture { get; }
        public Metrics Metrics { get; }

        public GlyphRenderInfo(char character, Texture2D texture, Metrics metrics)
        {
            this.Character = character;
            this.Texture = texture;
            this.Metrics = metrics;
        }
    }
}
