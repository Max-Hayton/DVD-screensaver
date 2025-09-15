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
        private Texture2D _enemy;
        private int _logoXPos = 100;
        private int _logoYPos = 100;
        private int _enemyXPos = 200;
        private int _enemyYPos = 200;
        private int _logoSpeed = 5;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;//Set window size
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
            _enemy = Content.Load<Texture2D>("Generic Fantasy Enemy");
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                if(_logoXPos + 50 <=_graphics.PreferredBackBufferWidth)
                {
                    _logoXPos += _logoSpeed;
                }
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                if(_logoXPos >= 0)
                {
                    _logoXPos -= _logoSpeed;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                if (_logoYPos + 50 <= _graphics.PreferredBackBufferHeight)
                {
                    _logoYPos += _logoSpeed;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if (_logoYPos >= 0)
                {
                    _logoYPos -= _logoSpeed;
                }
            }



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_logo, new Rectangle(_logoXPos,_logoYPos,50,50), Color.White);
            _spriteBatch.Draw(_enemy, new Rectangle(_enemyXPos,_enemyYPos,50,50),Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
