using System;
using System.Windows.Forms;
using System.Drawing;

namespace Maze
{
    class Labirint
    {
        private int HP = 100;
        Point charCoords;

        public int height; // высота лабиринта (количество строк)
        public int width; // ширина лабиринта (количество столбцов в каждой строке)

        public MazeObject[,] maze;
        public PictureBox[,] images;

        public static Random rnd = new Random();
        public Form parent;

        public Labirint(Form parent, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.parent = parent;

            maze = new MazeObject[height, width];
            images = new PictureBox[height, width];

            Generate();
        }

        private void Generate()
        {
            int smileX = 0;
            int smileY = 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    MazeObject.MazeObjectType current = MazeObject.MazeObjectType.HALL;

                    // в 1 случае из 5 - ставим стену
                    if (rnd.Next(5) == 0)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // в 1 случае из 250 - кладём денежку
                    if (rnd.Next(250) == 0)
                    {
                        current = MazeObject.MazeObjectType.MEDAL;
                    }

                    // в 1 случае из 250 - размещаем врага
                    if (rnd.Next(250) == 0)
                    {
                        current = MazeObject.MazeObjectType.ENEMY;
                    }

                    // стены по периметру обязательны
                    if (y == 0 || x == 0 || y == height - 1 | x == width - 1)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // наш персонажик
                    if (x == smileX && y == smileY)
                    {
                        current = MazeObject.MazeObjectType.CHAR;
                    }

                    // есть выход, и соседняя ячейка справа всегда свободна
                    if (x == smileX + 1 && y == smileY || x == width - 1 && y == height - 3)
                    {
                        current = MazeObject.MazeObjectType.HALL;
                    }
                    
                    maze[y, x] = new MazeObject(current);
                    images[y, x] = new PictureBox();
                    images[y, x].Location = new Point(x * maze[y, x].width, y * maze[y, x].height);
                    images[y, x].Parent = parent;
                    images[y, x].Width = maze[y, x].width;
                    images[y, x].Height = maze[y, x].height;
                    images[y, x].BackgroundImage = maze[y, x].texture;
                    images[y, x].Visible = false;
                }
            }
        }

        public void Show()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    images[y, x].Visible = true;
                }
            }
        }

        public bool IsMoveAvailable(MazeObject.MazeObjectDirection dir)
        {
            int x = charCoords.X;
            int y = charCoords.Y;

            switch (dir)
            {
                case MazeObject.MazeObjectDirection.UP:
                    {
                        y--;
                        break;
                    }
                case MazeObject.MazeObjectDirection.DOWN:
                    { 
                        y++;
                        break;
                    }
                case MazeObject.MazeObjectDirection.LEFT:
                    {
                        x--;
                        break;
                    }
                case MazeObject.MazeObjectDirection.RIGHT:
                    {
                        x++;
                        break;
                    }
            }
            try
            {
                switch (maze[y, x].type)
                {
                    case MazeObject.MazeObjectType.HALL:  return true;
                    case MazeObject.MazeObjectType.AID:
                        {
                            if (HP >= 50) return false;
                            else
                            {
                                HP += 5;
                                if (HP > 50) HP = 50;
                                return true;
                            }
                        }
                    case MazeObject.MazeObjectType.ENEMY:
                        {
                            HP -= rnd.Next(20, 25);
                            return true;
                        }
                    default: return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool Status()
        {
            parent.Text = "Your HP: " + HP + "%";

            if (HP <= 0)
            {
                MessageBox.Show("Game Over!\n");
                return false;
            }
            return true;
        }

        public void MakeMove(MazeObject.MazeObjectDirection dir)
        {
            if (IsMoveAvailable(dir))
            {
                switch (dir)
                {
                    case MazeObject.MazeObjectDirection.UP:
                        {
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            charCoords.Y--;
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            break;
                        }
                    case MazeObject.MazeObjectDirection.DOWN:
                        {
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            charCoords.Y++;
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            break;
                        }
                    case MazeObject.MazeObjectDirection.LEFT:
                        {
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            charCoords.X--;
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            break;
                        }
                    case MazeObject.MazeObjectDirection.RIGHT:
                        {
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            charCoords.X++;
                            maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                            images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                            break;
                        }
                }
            }
            Status();
        }
    }
}
