namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ListView listView1;

        public Form1()
        {
            InitializeComponent();

            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            listView1.View = View.Details;

            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            ListViewItem item1 = new ListViewItem("Car #1", 0);
            item1.SubItems.Add("100 000 $");
            ListViewItem item2 = new ListViewItem("Car #2", 0);
            item2.SubItems.Add("200 000 $");
            ListViewItem item3 = new ListViewItem("House", 0);
            item3.SubItems.Add("1 100 000 $");


            listView1.Columns.Add("Item", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Price", 100, HorizontalAlignment.Left);

            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });


            this.Controls.Add(listView1);

            Width = 350; // Ширина формы
            Height = 250; // Высота формы
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}