using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace yggggggggggggggggggg
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D player;
        Texture2D monei;
        Texture2D Price;

        Rectangle playerRect = new Rectangle(0, 0, 400, 200);
        Rectangle moneiRect = new Rectangle(500, 200, 100, 100);
        Rectangle priceRect = new Rectangle(0, 0, 1000, 500);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            player = Content.Load<Texture2D>("dollarr");

            monei = Content.Load<Texture2D>("monei");

            Price = Content.Load<Texture2D>("mighty");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            if (Keyboard.GetState().IsKeyDown(Keys.Right)){
                playerRect.X++;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)){
            playerRect.X--;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up)){
            playerRect.Y--;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down)){
            playerRect.Y++;
            }

/*
            if (playerRect.Intersects(moneiRect))
                moneiRect.X =+ 1000;
*/
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(player, playerRect, Color.White);

            _spriteBatch.Draw(monei, moneiRect, Color.White);

            if (playerRect.Intersects(moneiRect))
             _spriteBatch.Draw(Price, priceRect, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
