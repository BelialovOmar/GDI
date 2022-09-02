using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_1
{
    public partial class Form5 : Form
    {
        private const int I = 5;     // размер матрицы, строка
        private const int J = 5;     // размер матрицы, столбец
        private int       X = 40;    // позиция кнопки на форме
        private int       Y = 40;    // позиция кнопки на форме
        
        Random rnd = new Random(); 
        Button[,] buttons = new Button[I, J];    // массив кнопок

        int num = 0;      // порядковый номер ячейки

        public Form5()
        {
            InitializeComponent();

            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    buttons[i, j] = new Button();

                    buttons[i, j].Parent = this;
                    buttons[i, j].Height = 80;
                    buttons[i, j].Width  = 80;
                    buttons[i, j].BackColor = Color.FromArgb(rnd.Next(150),
                                                             rnd.Next(150), 
                                                             rnd.Next(150));

                    num++;

                    buttons[i, j].Text     =  num.ToString();
                    buttons[i, j].Click    += new EventHandler(RemoveButton);              // удаляем кнопку при нажатии
                    buttons[i, j].Location =  new Point(i * X + i * Y, j * X + j * Y);
                }
            }
        }

        private void RemoveButton(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);            // удаляет кнопку 
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
