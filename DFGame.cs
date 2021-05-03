using ECS.Core;

namespace DFGame
{
    public class DFGame : ECSGame
    {
        private World world;

        protected override void Load()
        {
            world = new World(1000);
        }

        protected override void Unload()
        {
        }
    }
}
