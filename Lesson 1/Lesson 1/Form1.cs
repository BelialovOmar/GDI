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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }


        // Practice 2
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button b   = sender as Button;
            Random rnd = new Random();

            b.Location = new Point(rnd.Next(350), rnd.Next(350));
        }


        // Practice 3 - доделал после пары, предыдущие сделал на паре
        Button button;

        int X1       = 0;       // изначальная координата X, откуда начнется отрисовка
        int Y1       = 0;       // изначальная координата Y, откуда начнется отрисовка
        int X2       = 0;       // конечная координата X, где закончится отрисвка, когда мы отпустим клавишу
        int Y2       = 0;       // конечная координата Y, где закончится отрисвка, когда мы отпустим клавишу
        bool release = false;   // переменная, обозначающая состоянии клавиши - нажата или отпущена

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // проверка; если кнопка ещё зажата
            if (!release)   
            {
                if (button != null)
                {
                    var newLocationX = 0;   // новые координаты по X, куда мы "протянем" нашу кнопку
                    var newLocationY = 0;   // новые координаты по Y, куда мы "протянем" нашу кнопку

                    if (e.X - X2 > 0)
                    {
                        X1 = e.X - X2;
                        newLocationX = X2;
                    }
                    else
                    {
                        newLocationX = e.X;
                        X1 = Math.Abs(X2 - e.X);
                    }

                    if (e.Y - Y2 > 0)
                    {
                        Y1 = e.Y - Y2;
                        newLocationY = Y2;
                    }
                    else
                    {
                        newLocationY = e.Y;
                        Y1 = Math.Abs(Y2 - e.Y);
                    }

                    button.Location = new Point(newLocationX, newLocationY);
                    button.Size     = new Size(X1, Y1);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            button = new Button();
            X1      = 0;
            Y1      = 0;
            X2      = e.X;
            Y2      = e.Y;
            release = false;

            button.Location = new Point(e.X, e.Y);  // задаем координаты, откуда начнется отрисовка кнопки

            this.Controls.Add(button);              // создаем эту самую кнопку
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            release = true;   // кнопку отпустили
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TimerDemo_Click(object sender, EventArgs e)
        {
            new TimerForm().ShowDialog();
        }

        private void RemoveButtons_Click(object sender, EventArgs e)
        {
            new RemoveButtons().ShowDialog();
        }

        private void child_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //new ChildParent().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new drop().ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form6().ShowDialog();

        }
    }
}
