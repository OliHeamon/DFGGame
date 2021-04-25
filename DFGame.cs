using Microsoft.Xna.Framework;

namespace DFGame
{
    public class DFGame : Game
    {
        private GraphicsDeviceManager graphics;

        public DFGame()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
