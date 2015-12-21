using AlkonostXNAGame.AlkonostDataStructure.Interfaces;

namespace AlkonostXNAGame.XNAData
{
#if WINDOWS || XBOX
    class GameEntryPoint : IEngine
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public void Run()
        {
            using (AlkonostGame game = new AlkonostGame())
            {
                game.Run();
            }
        }
    }
#endif
}