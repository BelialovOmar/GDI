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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        int cnt = 0;
        
        private void button1_Click_1(object sender, EventArgs e)
        {

           Button b = sender as Button;
           cnt++;
           b.Text = cnt + "";
        }
    }
}
