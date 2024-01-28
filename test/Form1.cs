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
            using (var form = new Form2()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    this.label1.Text = form.ReturnValue;
                }
            }
            

        }
    }
}
