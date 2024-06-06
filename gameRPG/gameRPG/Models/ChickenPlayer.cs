namespace gameRPG.Models
{
    public class ChickenPlayer
    {
        public string Name { get; set; } = "Chicken";

        public int Level { get; set; } = 1;
        public int CurrentExperience { get; set; } = 0;
        public int ExperienceNeededToLevelUp { get; set; } = 10;

        public int Vigor { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Faith { get; set; } = 10;
        public int Resilience { get; set; } = 10;
        public int Haste { get; set; } = 10;

        public int StatPoints { get; set; } = 20;

        public int CurrentHealthPoints { get; set; } = 20;
        public int MaxHealthPoints { get; set; } = 20;
        public int CurrentMana { get; set; } = 20;
        public int MaxMana { get; set; } = 20; 

        public List<ChickenMove> Moves { get; set; }

        public void LevelUp ()
        {
            Level++;
            CurrentExperience = 0;
            ExperienceNeededToLevelUp = Convert.ToInt32(ExperienceNeededToLevelUp * 1.5);
        }

        public void StatUp (string stat)
        {
            StatPoints--;
            switch (stat.ToLower())
            {
                case "vigor":
                    Vigor++;
                    MaxHealthPoints += 2;
                    CurrentHealthPoints += 2;
                    break;
                case "strength":
                    Strength++;
                    break;
                case "intelligence":
                    Intelligence++;
                    MaxMana += 2;
                    CurrentMana += 2;
                    break;
                case "faith":
                    Faith++;
                    MaxMana += 2;
                    CurrentMana += 2;
                    break;
                case "resilience":
                    Resilience++;
                    break;
                case "haste":
                    Haste++;
                    break;

            }
        }
    }
}
