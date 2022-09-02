using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lesson_1
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
            start = DateTime.Now;
            timer1.Start();
        }

        // static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        DateTime start;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            var date = DateTime.Now;
            // var date2 = date - start;
            //date2.ToString("HH: mm: ss");

            labelTime.Text = (date - start).ToString(/*"HH: mm: ss"*/);
        }

    }
}
