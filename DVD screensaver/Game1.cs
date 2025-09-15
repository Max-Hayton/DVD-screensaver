using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DVD_screensaver
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _logo;
        private int _logoXPos = 100;
        private int _logoYPos = 100;
        bool xEdgeHit=true;
        bool yEdgeHit=true;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
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
            _logo = Content.Load<Texture2D>("DVD screensaver");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            if (_logoXPos == 750 || _logoXPos == 0)
            {
                xEdgeHit=!xEdgeHit;
            }

            if (xEdgeHit==true)
            {
                _logoXPos += 2;
            }
            else
            {
                _logoXPos -= 2;
            }

            if (_logoYPos == 550 || _logoYPos == 0)
            {
                yEdgeHit = !yEdgeHit;
            }

            if (yEdgeHit == true)
            {
                _logoYPos += 2;
            }
            else
            {
                _logoYPos -= 2;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_logo, new Rectangle(_logoXPos,_logoYPos,50,50), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
