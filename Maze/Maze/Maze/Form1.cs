using System.Drawing;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        Labirint l;

        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
        }

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 40;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame() {
            Labirint l = new Labirint(this, 40, 20);
            l.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                l.MakeMove(MazeObject.MazeObjectDirection.UP);
            }
            else if (e.KeyCode == Keys.S)
            {
                l.MakeMove(MazeObject.MazeObjectDirection.DOWN);
            }
            else if (e.KeyCode == Keys.A)
            {
                l.MakeMove(MazeObject.MazeObjectDirection.LEFT);
            }

            else if (e.KeyCode == Keys.D)
            {
                l.MakeMove(MazeObject.MazeObjectDirection.RIGHT);
            }
        }
    }
}
