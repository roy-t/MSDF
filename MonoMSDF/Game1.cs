using FontExtension;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoMSDF.Text;

namespace MonoMSDF
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private TextRenderer textRenderer;

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
            var effect = this.Content.Load<Effect>("FieldFontEffect");
            var font = this.Content.Load<FieldFont>("arial");

            this.textRenderer = new TextRenderer(effect, font, this.GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();           

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.Black);

            this.GraphicsDevice.BlendState = BlendState.AlphaBlend;
            this.GraphicsDevice.DepthStencilState = DepthStencilState.None;
            this.GraphicsDevice.RasterizerState = RasterizerState.CullNone;            

            var viewport = this.GraphicsDevice.Viewport;

            //var world = Matrix.CreateScale(0.01f) *  Matrix.CreateRotationY((float)gameTime.TotalGameTime.TotalSeconds);
            var world = Matrix.CreateScale(0.01f) * Matrix.Identity;
            var view = Matrix.CreateLookAt(Vector3.Backward , Vector3.Forward, Vector3.Up);
            var projection = Matrix.CreatePerspectiveFieldOfView(
                MathHelper.PiOver2,
                viewport.Width / (float) viewport.Height,
                0.01f,
                1000.0f);

            var wvp = world * view * projection;

            this.textRenderer.Render("→~!435&^%$", wvp);
            

            world = Matrix.CreateScale(0.01f) *  Matrix.CreateRotationY((float)gameTime.TotalGameTime.TotalSeconds) * Matrix.CreateRotationZ(MathHelper.PiOver4);            
            view = Matrix.CreateLookAt(Vector3.Backward, Vector3.Forward, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(
                MathHelper.PiOver2,
                viewport.Width / (float)viewport.Height,
                0.01f,
                1000.0f);

            wvp = world * view * projection;

            this.textRenderer.Render("          To Infinity And Beyond!", wvp);
        }
    }
}
