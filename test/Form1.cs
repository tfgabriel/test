namespace test
{
    public partial class Form1 : Form
    {

        public string displaytext;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = displaytext;
        }
    }
}
