using System;

namespace Alkonost2
{
#if WINDOWS || XBOX
    static class GameEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (AlkonostGame game = new AlkonostGame())
            {
                game.Run();
            }
        }
    }
#endif
}