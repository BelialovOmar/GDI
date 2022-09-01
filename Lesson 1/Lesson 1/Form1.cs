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

        // Practice 1
        int cnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            cnt++;
            b.Text = cnt + "";
        }


        // Practice 2
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Random rnd = new Random();

            b.Location = new Point(rnd.Next(350), rnd.Next(350));
        }


        // Practice 3 - доделал после пары, предыдущие сделал на паре
        Button button;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            button = new Button();

            button.Location = new Point(e.X, e.Y);
            this.Controls.Add(button);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        


    }
}
