using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_2___scaled_images
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        Texture2D rectangleTexture;
        Texture2D circleTexture;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 500;
            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(rectangleTexture, new Rectangle(350, 50, 100, 100), Color.Gray);
            spriteBatch.Draw(rectangleTexture, new Rectangle(300, 150, 200, 250), Color.Gray);
            spriteBatch.Draw(rectangleTexture, new Rectangle(300, 400, 75, 75), Color.Gray);
            spriteBatch.Draw(rectangleTexture, new Rectangle(425, 400, 75, 75), Color.Gray);
            spriteBatch.Draw(rectangleTexture, new Rectangle(300, 475, 75, 25), Color.Yellow);
            spriteBatch.Draw(rectangleTexture, new Rectangle(425, 475, 75, 25), Color.Yellow);
            spriteBatch.Draw(rectangleTexture, new Rectangle(150, 150, 150, 50), Color.Gray);
            spriteBatch.Draw(rectangleTexture, new Rectangle(500, 150, 150, 50), Color.Gray);
            spriteBatch.Draw(circleTexture, new Rectangle(120, 145, 60, 60), Color.Yellow);
            spriteBatch.Draw(circleTexture, new Rectangle(620, 145, 60, 60), Color.Yellow);
            spriteBatch.Draw(circleTexture, new Rectangle(365, 80, 25, 25), Color.Red);
            spriteBatch.Draw(circleTexture, new Rectangle(410, 80, 25, 25), Color.Red);
            spriteBatch.Draw(rectangleTexture, new Rectangle(380, 115, 10, 20), Color.White);
            spriteBatch.Draw(rectangleTexture, new Rectangle(395, 115, 10, 20), Color.White);
            spriteBatch.Draw(rectangleTexture, new Rectangle(410, 115, 10, 20), Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}