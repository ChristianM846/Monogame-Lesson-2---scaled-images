using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_2___scaled_images
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        SpriteFont labelFont;
        Texture2D rectangleTexture;
        Texture2D circleTexture;
        Rectangle sunRect;
        Rectangle headRect;
        Rectangle bodyRect;
        Rectangle leftLegRect;
        Rectangle rightLegRect;
        Rectangle leftFootRect;
        Rectangle rightFootRect;
        Rectangle leftArmRect;
        Rectangle rightArmRect;
        Rectangle leftHandRect;
        Rectangle rightHandRect;
        Rectangle leftEyeRect;
        Rectangle rightEyeRect;
        Rectangle mouth1Rect;
        Rectangle mouth2Rect;
        Rectangle mouth3Rect;

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
            sunRect = new Rectangle(20, 20, 75, 75);
            headRect = new Rectangle(350, 50, 100, 100);
            bodyRect = new Rectangle(300, 150, 200, 250);
            leftLegRect = new Rectangle(300, 400, 75, 75);
            rightLegRect = new Rectangle(425, 400, 75, 75);
            leftFootRect = new Rectangle(300, 475, 75, 25);
            rightFootRect = new Rectangle(425, 475, 75, 25);
            leftArmRect = new Rectangle(150, 150, 150, 50);
            rightArmRect = new Rectangle(500, 150, 150, 50);
            leftHandRect = new Rectangle(120, 145, 60, 60);
            rightHandRect = new Rectangle(620, 145, 60, 60);
            leftEyeRect = new Rectangle(365, 80, 25, 25);
            rightEyeRect = new Rectangle(410, 80, 25, 25);
            mouth1Rect = new Rectangle(380, 115, 10, 20);
            mouth2Rect = new Rectangle(395, 115, 10, 20);
            mouth3Rect = new Rectangle(410, 115, 10, 20);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            labelFont = Content.Load<SpriteFont>("Text");

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
            spriteBatch.Draw(rectangleTexture, headRect, Color.Gray);
            spriteBatch.Draw(rectangleTexture, bodyRect, Color.Gray);
            spriteBatch.Draw(rectangleTexture, leftLegRect, Color.Gray);
            spriteBatch.Draw(rectangleTexture, rightLegRect, Color.Gray);
            spriteBatch.Draw(rectangleTexture, leftFootRect, Color.Yellow);
            spriteBatch.Draw(rectangleTexture, rightFootRect, Color.Yellow);
            spriteBatch.Draw(rectangleTexture, leftArmRect, Color.Gray);
            spriteBatch.Draw(rectangleTexture, rightArmRect, Color.Gray);
            spriteBatch.Draw(circleTexture, leftHandRect, Color.Yellow);
            spriteBatch.Draw(circleTexture, rightHandRect, Color.Yellow);
            spriteBatch.Draw(circleTexture, leftEyeRect, Color.Red);
            spriteBatch.Draw(circleTexture, rightEyeRect, Color.Red);
            spriteBatch.Draw(rectangleTexture, mouth1Rect, Color.White);
            spriteBatch.Draw(rectangleTexture, mouth2Rect, Color.White);
            spriteBatch.Draw(rectangleTexture, mouth3Rect, Color.White);
            spriteBatch.Draw(circleTexture, sunRect, Color.Yellow);
            spriteBatch.DrawString(labelFont, "Robot #846", new Vector2(365, 200), Color.White);
            spriteBatch.DrawString(labelFont, "Name - Jeff", new Vector2(365, 250), Color.White);


            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}