using AlkonostXNAGame.AlkonostDataStructure.Interfaces;

namespace AlkonostXNAGame.XNAData
{
#if WINDOWS || XBOX
    static class GameEntryPoint 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static  void Main()
        {
            using (AlkonostGame game = new AlkonostGame())
            {
                game.Run();
            }
        }
    }
#endif
}

