using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            colorDialog1 = new ColorDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
            }

        }

        private void Form5_BackColorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
