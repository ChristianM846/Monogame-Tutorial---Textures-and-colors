using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Tutorial___Textures_and_colors
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;
        Texture2D dinoTexture;
        Texture2D cityTexture;
        Texture2D chopperTexture;
        Texture2D rocketTexture;
        Texture2D diagonalRocketTexture;
        Texture2D tankTexture;
        Texture2D flameTexture;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "Monogame Tutorial";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            dinoTexture = Content.Load<Texture2D>("dino");
            cityTexture = Content.Load<Texture2D>("City");
            chopperTexture = Content.Load<Texture2D>("Chopper2");
            rocketTexture = Content.Load<Texture2D>("Rockets");
            diagonalRocketTexture = Content.Load<Texture2D>("Rocket");
            tankTexture = Content.Load<Texture2D>("Tank");
            flameTexture = Content.Load<Texture2D>("Flamethrower");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            spriteBatch.Draw(cityTexture, new Vector2 (0, 0), Color.White);
            spriteBatch.Draw(dinoTexture, new Vector2 (10, 200), Color.White);
            spriteBatch.Draw(chopperTexture, new Vector2(500, 50), Color.White);
            spriteBatch.Draw(rocketTexture, new Vector2(300, 250), Color.White);
            spriteBatch.Draw(diagonalRocketTexture, new Vector2(250, 200), Color.White);
            spriteBatch.Draw(tankTexture, new Vector2(450, 350), Color.White);
            spriteBatch.Draw(flameTexture, new Vector2(175, 450), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}