using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AlkonostXNAGame.XNAData.GameGraphic
{
    class Map
    {
        private List<CollisionsTiles> collisionsTiles = new List<CollisionsTiles>();
       
        public List<CollisionsTiles> CollisionsTiles
        {
         get {return  collisionsTiles;}
        }

        private int width, height;
        public int Width 
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }

        public Map()
        {
        }
        public void Generate(int[,] map, int size)
        {
            for (int x = 0; x < map.GetLength(1);x++ )
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    int number = map[y,x];
                    if (number > 0)
                        collisionsTiles.Add(new CollisionsTiles(number,new Rectangle(x*size,y*size,size,size)));
                    width = (x + 1) * size;
                    height = (y +1) * size;

                }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (CollisionsTiles tile in collisionsTiles)
                tile.Draw(spriteBatch);
        }
    }
}
