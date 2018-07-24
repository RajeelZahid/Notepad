using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad_01
{
    public partial class Form1 : Form
    {
        public static string text;
        public Form1()
        {
            this.Text = "Notepad";
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                deleteToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                selectToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
                replaceToolStripMenuItem.Enabled = false;
                newToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
            }
            else if (textBox1.Text != "")
            {
                deleteToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                selectToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                replaceToolStripMenuItem.Enabled = true;
                newToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.White;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.WordWrap = false;
            fieToolStripMenuItem.BackColor = Color.White;
            newToolStripMenuItem.BackColor = Color.White;
            saveAsToolStripMenuItem.BackColor = Color.White;
            saveToolStripMenuItem.BackColor = Color.White;
            exitToolStripMenuItem.BackColor = Color.White;
            openToolStripMenuItem.BackColor = Color.White;
            editToolStripMenuItem.BackColor = Color.White;
            cutToolStripMenuItem.BackColor = Color.White;
            copyToolStripMenuItem.BackColor = Color.White;
            pasteToolStripMenuItem.BackColor = Color.White;
            selectToolStripMenuItem.BackColor = Color.White;
            deleteToolStripMenuItem.BackColor = Color.White;
            findToolStripMenuItem.BackColor = Color.White;
            replaceToolStripMenuItem.BackColor = Color.White;
            timeDateToolStripMenuItem.BackColor = Color.White;
            formatToolStripMenuItem.BackColor = Color.White;
            wordWrapToolStripMenuItem.BackColor = Color.White;
            fontToolStripMenuItem.BackColor = Color.White;
            fontsToolStripMenuItem.BackColor = Color.White;
            fontColorToolStripMenuItem.BackColor = Color.White;
            themeToolStripMenuItem.BackColor = Color.White;
            lightToolStripMenuItem.BackColor = Color.White;
            darkToolStripMenuItem.BackColor = Color.White;

            fieToolStripMenuItem.ForeColor = Color.Black;
            newToolStripMenuItem.ForeColor = Color.Black;
            saveAsToolStripMenuItem.ForeColor = Color.Black;
            saveToolStripMenuItem.ForeColor = Color.Black;
            exitToolStripMenuItem.ForeColor = Color.Black;
            openToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.ForeColor = Color.Black;
            cutToolStripMenuItem.ForeColor = Color.Black;
            copyToolStripMenuItem.ForeColor = Color.Black;
            pasteToolStripMenuItem.ForeColor = Color.Black;
            selectToolStripMenuItem.ForeColor = Color.Black;
            deleteToolStripMenuItem.ForeColor = Color.Black;
            findToolStripMenuItem.ForeColor = Color.Black;
            replaceToolStripMenuItem.ForeColor = Color.Black;
            timeDateToolStripMenuItem.ForeColor = Color.Black;
            formatToolStripMenuItem.ForeColor = Color.Black;
            wordWrapToolStripMenuItem.ForeColor = Color.Black;
            fontToolStripMenuItem.ForeColor = Color.Black;
            fontsToolStripMenuItem.ForeColor = Color.Black;
            fontColorToolStripMenuItem.ForeColor = Color.Black;
            themeToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;

            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            lightToolStripMenuItem.Checked = true;
            deleteToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            selectToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.Enabled = false;
            replaceToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Replace(this);
            f3.Show();
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.fontDialog1.Font = new Font(16);
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == false)
            {
                wordWrapToolStripMenuItem.Checked = true;
                textBox1.WordWrap = true;
            }
            else if (wordWrapToolStripMenuItem.Checked == true)
            {
                wordWrapToolStripMenuItem.Checked = false;
                textBox1.WordWrap = false;
            }
        }

        public void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lightToolStripMenuItem.Checked = true;
            darkToolStripMenuItem.Checked = false;

            menuStrip1.BackColor = Color.White;
            fieToolStripMenuItem.BackColor = Color.White;
            newToolStripMenuItem.BackColor = Color.White;
            saveAsToolStripMenuItem.BackColor = Color.White;
            saveToolStripMenuItem.BackColor = Color.White;
            exitToolStripMenuItem.BackColor = Color.White;
            openToolStripMenuItem.BackColor = Color.White;
            editToolStripMenuItem.BackColor = Color.White;
            cutToolStripMenuItem.BackColor = Color.White;
            copyToolStripMenuItem.BackColor = Color.White;
            pasteToolStripMenuItem.BackColor = Color.White;
            selectToolStripMenuItem.BackColor = Color.White;
            deleteToolStripMenuItem.BackColor = Color.White;
            findToolStripMenuItem.BackColor = Color.White;
            replaceToolStripMenuItem.BackColor = Color.White;
            timeDateToolStripMenuItem.BackColor = Color.White;
            formatToolStripMenuItem.BackColor = Color.White;
            wordWrapToolStripMenuItem.BackColor = Color.White;
            fontToolStripMenuItem.BackColor = Color.White;
            fontsToolStripMenuItem.BackColor = Color.White;
            fontColorToolStripMenuItem.BackColor = Color.White;
            themeToolStripMenuItem.BackColor = Color.White;
            lightToolStripMenuItem.BackColor = Color.White;
            darkToolStripMenuItem.BackColor = Color.White;

            fieToolStripMenuItem.ForeColor = Color.Black;
            newToolStripMenuItem.ForeColor = Color.Black;
            saveAsToolStripMenuItem.ForeColor = Color.Black;
            saveToolStripMenuItem.ForeColor = Color.Black;
            exitToolStripMenuItem.ForeColor = Color.Black;
            openToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.ForeColor = Color.Black;
            cutToolStripMenuItem.ForeColor = Color.Black;
            copyToolStripMenuItem.ForeColor = Color.Black;
            pasteToolStripMenuItem.ForeColor = Color.Black;
            selectToolStripMenuItem.ForeColor = Color.Black;
            deleteToolStripMenuItem.ForeColor = Color.Black;
            findToolStripMenuItem.ForeColor = Color.Black;
            replaceToolStripMenuItem.ForeColor = Color.Black;
            timeDateToolStripMenuItem.ForeColor = Color.Black;
            formatToolStripMenuItem.ForeColor = Color.Black;
            wordWrapToolStripMenuItem.ForeColor = Color.Black;
            fontToolStripMenuItem.ForeColor = Color.Black;
            fontsToolStripMenuItem.ForeColor = Color.Black;
            fontColorToolStripMenuItem.ForeColor = Color.Black;
            themeToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;

            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            this.BackColor = Color.White;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Black;
            fieToolStripMenuItem.BackColor = Color.Black;
            newToolStripMenuItem.BackColor = Color.Black;
            saveAsToolStripMenuItem.BackColor = Color.Black;
            saveToolStripMenuItem.BackColor = Color.Black;
            exitToolStripMenuItem.BackColor = Color.Black;
            openToolStripMenuItem.BackColor = Color.Black;
            editToolStripMenuItem.BackColor = Color.Black;
            cutToolStripMenuItem.BackColor = Color.Black;
            copyToolStripMenuItem.BackColor = Color.Black;
            pasteToolStripMenuItem.BackColor = Color.Black;
            selectToolStripMenuItem.BackColor = Color.Black;
            deleteToolStripMenuItem.BackColor = Color.Black;
            findToolStripMenuItem.BackColor = Color.Black;
            replaceToolStripMenuItem.BackColor = Color.Black;
            timeDateToolStripMenuItem.BackColor = Color.Black;
            formatToolStripMenuItem.BackColor = Color.Black;
            wordWrapToolStripMenuItem.BackColor = Color.Black;
            fontToolStripMenuItem.BackColor = Color.Black;
            fontsToolStripMenuItem.BackColor = Color.Black;
            fontColorToolStripMenuItem.BackColor = Color.Black;
            themeToolStripMenuItem.BackColor = Color.Black;
            lightToolStripMenuItem.BackColor = Color.Black;
            darkToolStripMenuItem.BackColor = Color.Black;

            fieToolStripMenuItem.ForeColor = Color.White;
            newToolStripMenuItem.ForeColor = Color.White;
            saveAsToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.ForeColor = Color.White;
            cutToolStripMenuItem.ForeColor = Color.White;
            copyToolStripMenuItem.ForeColor = Color.White;
            pasteToolStripMenuItem.ForeColor = Color.White;
            selectToolStripMenuItem.ForeColor = Color.White;
            deleteToolStripMenuItem.ForeColor = Color.White;
            findToolStripMenuItem.ForeColor = Color.White;
            replaceToolStripMenuItem.ForeColor = Color.White;
            timeDateToolStripMenuItem.ForeColor = Color.White;
            formatToolStripMenuItem.ForeColor = Color.White;
            wordWrapToolStripMenuItem.ForeColor = Color.White;
            fontToolStripMenuItem.ForeColor = Color.White;
            fontsToolStripMenuItem.ForeColor = Color.White;
            fontColorToolStripMenuItem.ForeColor = Color.White;
            themeToolStripMenuItem.ForeColor = Color.White;
            lightToolStripMenuItem.ForeColor = Color.White;
            darkToolStripMenuItem.ForeColor = Color.White;

            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;

            this.BackColor = Color.Black;

            lightToolStripMenuItem.Checked = false;
            darkToolStripMenuItem.Checked = true;
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += System.DateTime.Today.ToString();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Find(this);
            f2.Show();
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;
            }
        }

        private void fieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Open File *.txt | *.txt";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(fname);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Save File *.txt | *.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname,textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Save File *.txt | *.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, textBox1.Text);
                textBox1.Text = "";
            }
            else if(dr == DialogResult.Cancel)
                    {
                textBox1.Text = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Save File *.txt | *.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, textBox1.Text);
            }
        }
    }
}
