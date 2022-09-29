namespace Windows_Forms
{
    public partial class PortalForm : Form
    {
        public PortalForm()
        {
            InitializeComponent();
        }

        private void linkMessageBoxviaBtnClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MSGBox_via_Button_click().ShowDialog(); 
        }
    }
}