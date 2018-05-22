using System.Collections.Generic;
using System.IO;
using System.Linq;
using FontExtension;
using Kaitai;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoMSDF
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Quad quad;
        private Effect effect;
        private FieldFont font;
        private List<FieldGlyph> glyphs;
        private List<Texture2D> textures;

        private float scale = 10.0f;

        private bool canInput;
        

        public Game1()
        {
            this.graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1080,
                PreferredBackBufferHeight = 768,
                SynchronizeWithVerticalRetrace = false,
                GraphicsProfile = GraphicsProfile.HiDef
            };

            this.Content.RootDirectory = "Content";
        }      

        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            this.quad = new Quad();

            this.effect = this.Content.Load<Effect>("FieldFontEffect");
            this.font = this.Content.Load<FieldFont>("arial");

            this.glyphs = new List<FieldGlyph>();
            this.textures = new List<Texture2D>();           

            PrepareGlyph('A');
       }

        private void PrepareGlyph(char c)
        {
            // TODO: instead of reading it, use setdata (but then we need to have stripped the bitmap headers in the processor
            var glyph = this.font.GetGlyph(c);
            using (var stream = new MemoryStream(glyph.Bitmap))
            {
                var texture = Texture2D.FromStream(this.GraphicsDevice, stream);

                this.glyphs.Add(glyph);
                this.textures.Add(texture);
            }            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var mouseState = Mouse.GetState();
            this.scale = mouseState.ScrollWheelValue * 0.005f + 1.0f;

            var keyState = Keyboard.GetState();

            var pressed = keyState.GetPressedKeys();
            if (pressed.Any() && this.canInput)
            {
                var key = pressed.First();
                var c = (char) key;
                if (char.IsLetterOrDigit(c))
                {
                    if (keyState.IsKeyDown(Keys.LeftShift))
                    {
                        PrepareGlyph(c);
                    }
                    else
                    {
                        PrepareGlyph(char.ToLower(c));
                    }
                }

                if (this.glyphs.Any() && keyState.IsKeyDown(Keys.Back))
                {
                    this.glyphs.RemoveAt(this.glyphs.Count - 1);
                    this.textures.RemoveAt(this.textures.Count - 1);
                }
            }

            this.canInput = (pressed.Length == 1 && pressed.Contains(Keys.LeftShift)) || !pressed.Any();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.CornflowerBlue);

            this.GraphicsDevice.BlendState = BlendState.AlphaBlend;
            this.GraphicsDevice.DepthStencilState = DepthStencilState.Default;
            this.GraphicsDevice.RasterizerState = RasterizerState.CullCounterClockwise;

            var viewport = this.GraphicsDevice.Viewport;


            var pen = new Vector2(-viewport.Width / 2.0f, 0);
            for (var i = 0; i < this.glyphs.Count; i++)
            {
                var glyph = this.glyphs[i];
                var texture = this.textures[i];
                
                var world = Matrix.Identity; // Matrix.CreateScale(this.scale / glyph.Metrics.Scale)
                            //* Matrix.CreateTranslation(new Vector3(pen, 0));
                            //* Matrix.CreateTranslation(new Vector3(t, 0));
                var view = Matrix.CreateLookAt(Vector3.Zero, Vector3.Forward, Vector3.Up);
                var projection = Matrix.CreateOrthographic(viewport.Width, viewport.Height, 0.0f, 1.0f);

                var wvp = world * view * projection;

                this.effect.Parameters["WorldViewProjection"].SetValue(wvp);
                this.effect.Parameters["PxRange"].SetValue(this.font.PxRange);
                this.effect.Parameters["TextureSize"].SetValue(new Vector2(texture.Width, texture.Height));
                this.effect.Parameters["ForegroundColor"].SetValue(Color.White.ToVector4());
                this.effect.Parameters["GlyphTexture"].SetValue(texture);

                this.effect.CurrentTechnique.Passes[0].Apply();
                
                var height = texture.Height * (this.scale / glyph.Metrics.Scale);
                var width = texture.Width * (this.scale / glyph.Metrics.Scale);

                var left = pen.X - glyph.Metrics.Translation.X * this.scale;
                var bottom = pen.Y - glyph.Metrics.Translation.Y * this.scale;

                var right = left + width;
                var top = bottom + height;
                
                               
                this.quad.Render(this.GraphicsDevice, new Vector2(left, bottom), new Vector2(right, top));


                pen.X += glyph.Metrics.Advance * this.scale;
                if (i < this.glyphs.Count - 1 && Keyboard.GetState().IsKeyDown(Keys.Tab))
                {
                    var next = this.glyphs[i + 1];

                    var kern = FontAnalyzer.Analyzer.Do(this.font.Name, glyph.Character, next.Character);

                    pen.X += kern * this.scale;
                }                
            }

            base.Draw(gameTime);
        }
    }
}
