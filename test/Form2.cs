using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        //Problem 1: A Click event cannot be overloaded with a Form, making access to a previous form from a click innaccessible
        public string ReturnValue { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e /*, Form1 form1*/)
        {

            this.ReturnValue = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




    }
}
