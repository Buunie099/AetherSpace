using AetherArk

namespace AetherSpace
{
    public class Game
    {
        public static void Main()
        {
            WindowSystem window = new WindowSystem();

            var application = new Application();
            application.Run(window);
        }
    }
}

