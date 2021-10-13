using System;

namespace les3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Room newRoom = new Room(5,2);
        }
    }
    class Room
    {
        Tile[][] tilemap;

        public Room(int width, int height)
        {
            tilemap = new Tile[height][];
            for (int i = 0; i < tilemap.Length; i++)
            {
                tilemap[i] = new Tile[width];
                for (int i2 = 0; i2 < tilemap[i].Length; i2++)
                {
                    tilemap[i][i2] = new Tile();
                }
            }
        }
    }
    class Tile
    {

    }
}
