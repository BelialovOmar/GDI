using System;
using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType      
            { HALL, WALL, MEDAL, ENEMY, CHAR, AID };
        public enum MazeObjectDirection 
            { UP, DOWN, LEFT, RIGHT };


        public Bitmap[] images = { new Bitmap(@"C:\Users\user\Desktop\ДЗ\Maze\hall.png"),
                                   new Bitmap(@"C:\Users\user\Desktop\ДЗ\Maze\wall.png"),
                                   new Bitmap(@"C:\Users\user\Desktop\ДЗ\Maze\medal.png"),
                                   new Bitmap(@"C:\Users\user\Desktop\ДЗ\Maze\enemy.png"),
                                   new Bitmap(@"C:\Users\user\Desktop\ДЗ\Maze\player.png"),
        };

        public MazeObjectType type;
        public int   width;
        public int   height;
        public Image texture;

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
            width     = 16;
            height    = 16;
            texture   = images[(int)type];
        }

    }
}
