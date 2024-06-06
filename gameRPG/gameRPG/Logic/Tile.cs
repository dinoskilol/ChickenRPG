namespace gameRPG.Logic
{
    public class Tile
    {
        public bool IsPassable { get; set; }
        public Action OnEnter { get; set; }

        public Tile(bool isPassable, Action onEnter = null)
        {
            IsPassable = isPassable;
            OnEnter = onEnter;
        }
    }
}
