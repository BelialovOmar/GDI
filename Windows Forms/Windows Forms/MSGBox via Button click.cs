using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class MSGBox_via_Button_click : Form
    {
        public MSGBox_via_Button_click()
        {
            InitializeComponent();
        }

        private void ButtonMSGBoxClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!"); //
        }
    }
}
