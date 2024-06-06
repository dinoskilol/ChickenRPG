namespace gameRPG.Logic
{
    public class TileMapLogic
    {
        public int Rows { get; }
        public int Columns { get; }
        public Tile[,] Map { get; }

        public (int X, int Y) DotPosition { get; private set; }

        public TileMapLogic(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Map = new Tile[rows, columns];

            // Initialize the map with default passable tiles
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    Map[y, x] = new Tile(true);
                }
            }

            DotPosition = (0, 0); // Initial position of the dot
        }

        public void MoveCharacter(string direction)
        {
            var (x, y) = DotPosition;
            var (newX, newY) = (x, y);

            switch (direction)
            {
                case "up":
                    if (y > 0) newY--;
                    break;
                case "down":
                    if (y < Rows - 1) newY++;
                    break;
                case "left":
                    if (x > 0) newX--;
                    break;
                case "right":
                    if (x < Columns - 1) newX++;
                    break;
            }

            // Check if the new position is passable
            if (Map[newY, newX].IsPassable)
            {
                DotPosition = (newX, newY);

                // Trigger any event associated with entering the tile
                Map[newY, newX].OnEnter?.Invoke();
            }
        }

        public void SetTile(int x, int y, Tile tile)
        {
            if (x >= 0 && x < Columns && y >= 0 && y < Rows)
            {
                Map[y, x] = tile;
            }
        }
    }
}
