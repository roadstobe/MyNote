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

namespace WindowsFormsApp12
{
    public partial class MainForm : Form
    {
        static string opernOrCreateNew;
        public MainForm()
        {
            InitializeComponent();
        }

        void openFile(OpenFileDialog ofd)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "TextFiles|*.txt|XMLFiles|*.xml";
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    textBox1.Text = sr.ReadToEnd();
                    textBox1.ReadOnly = ofd.ReadOnlyChecked;
                }
            }
        }
        void saveFile(string check)
        {
            if (check != null)
            {
                using (StreamWriter sr = new StreamWriter(check))
                {
                    sr.Write(textBox1.Text);
                }
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog(); sfd.Filter = "TextFiles|*.txt|XMLFiles|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sr = new StreamWriter(sfd.FileName))
                    {
                        sr.Write(textBox1.Text);
                    }
                    opernOrCreateNew = sfd.FileName;
                }
            }
        }
        void saveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog(); sfd.Filter = "TextFiles|*.txt|XMLFiles|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(sfd.FileName))
                {
                    sr.Write(textBox1.Text);
                }
                opernOrCreateNew = "";
            }
        }
        void findWord()
        {
            Find find = new Find();
            find.Owner = this;
            find.Show();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        { 
            
            switch (e.KeyCode)
            {
                case Keys.O:
                    {
                        if(e.Control)
                        {
                            OpenFileDialog ofd = new OpenFileDialog();
                            openFile(ofd);
                            opernOrCreateNew = ofd.FileName;
                        }
                        break;
                    }
                case Keys.S:
                    {
                        if(e.Control)
                        {
                            saveFile(opernOrCreateNew);
                        }
                        break;
                    }
                case Keys.A:
                    {
                        if (e.Control && e.Shift)
                            saveAs();
                        break;
                    }
                case Keys.F:
                    {
                        if (e.Control)
                            findWord();
                        break;
                    }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(opernOrCreateNew);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                saveToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveToolStripMenuItem.Enabled = false;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            openFile(ofd);
            opernOrCreateNew = ofd.FileName;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want save file?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                saveAs();
            this.Close();
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findWord();
        }
    }
}
