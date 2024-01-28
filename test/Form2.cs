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
        
        public Form1 form = new Form1();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            form = GetFormControl(form1);
        }

        private void button1_Click(object sender, EventArgs e /*, Form1 form1*/)
        {
            form.displaytext = textBox1.Text;
            this.Close();
        }

        private Form1 GetFormControl(Form1 form1)
        {
            return form1;
        }
    }
}
