namespace gameRPG.Models
{
    public class ChickenMove
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int HealthRequired { get; set; }
        public int ManaRequired { get; set; }
        public bool Toggleable { get; set; }
        public int Damage { get; set; }
        public List<string> ScalingOn { get; set; }
        public List<int> LearnedAt { get; set; }

        public ChickenMove (string name, string image, string description, int healthRequired, int manaRequired, bool toggleable, int damage, List<string> scalingOn, List<int> learnedAt)
        {
            Name = name;
            Image = image;
            Description = description;
            HealthRequired = healthRequired;
            ManaRequired = manaRequired;
            Toggleable = toggleable;
            Damage = damage;
            ScalingOn = scalingOn;
            LearnedAt = learnedAt;
        }
    }
}
