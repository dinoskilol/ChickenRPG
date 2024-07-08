
    using gameRPG.Models;
    namespace gameRPG.Services
    {
        public class PlayerService
        {
            public ChickenPlayer Player { get; private set; }

            public PlayerService()
            {
                Player = new ChickenPlayer();
            }
        }
    }
