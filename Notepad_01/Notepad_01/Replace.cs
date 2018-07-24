using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_01
{
    public partial class Replace : Form
    {
        Form1 f1;
        public Replace(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Replace_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (f1.textBox1.Text.Contains(textBox1.Text))
                {
                    f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
                    MessageBox.Show("Replaced Successfully...");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not Found...");
                    this.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
