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
        string draft;
        public MainForm()
        {
            InitializeComponent();
            if (mainTextBox.Text == "")
            {
                selectAllPanel.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
            }
        }

        void openFile(OpenFileDialog ofd)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "TextFiles|*.txt|XMLFiles|*.xml";
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    mainTextBox.Text = sr.ReadToEnd();
                    mainTextBox.ReadOnly = ofd.ReadOnlyChecked;
                }
            }
        }
        void saveFile(string check)
        {
            draft = mainTextBox.Text;
            if (check != null)
            {
                
                using (StreamWriter sr = new StreamWriter(check))
                {
                    sr.Write(draft);
                }
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog(); sfd.Filter = "TextFiles|*.txt|XMLFiles|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sr = new StreamWriter(sfd.FileName))
                    {
                        sr.Write(draft);
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
                    sr.Write(mainTextBox.Text);
                }
                opernOrCreateNew = "";
            }
        }
        void findWord()
        {
            Find find = new Find();
            find.Owner = this;
            //foreach (var item in OwnedForms)
            //{
            //    MessageBox.Show(item.ToString());
            //}

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

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "")
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
            this.Close();
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findWord();
        }

        private void VievPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(VievPanel.Checked == true)
            {
                toolStripPanel.Visible = true;
            }
            else
            {
                toolStripPanel.Visible = false;
            }
        }
      
        // FOR EDIT
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
            checkEnableCutCopyPasteSelectAll();
        }

        /// //////////////////////////////////////////////////////////////////////
      
        private void ContextMenuStrip_Opening_1(object sender, CancelEventArgs e)
        {
            checkEnableCutCopyPasteSelectAll();
        }
        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mainTextBox.Text == "")
            {
                selectAllPanel.Enabled = false;
            }
            else
                selectAllPanel.Enabled = true;
            countWords.Text = mainTextBox.Text.Length.ToString();
            checkEnableCutCopyPasteSelectAll();

        }

        void checkEnableCutCopyPasteSelectAll()
        {
            if (mainTextBox.SelectionLength == 0)
            {
                cutExtraPanel.Enabled = false;
                copyExtraPanel.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                panelCopy.Enabled = false;
                cutPanel.Enabled = false;

                countSelect.Visible = false;
                countSelectSymbol.Visible = false;
            }
            else
            {
                panelCopy.Enabled = true;
                cutPanel.Enabled = true;
                cutExtraPanel.Enabled = true;
                copyExtraPanel.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;

                countSelect.Visible = true;
                countSelectSymbol.Visible = true;
                countSelectSymbol.Text = mainTextBox.SelectionLength.ToString();
            }
            if (mainTextBox.Text == "")
            {
                selectAllExtraPanel.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
            }
            else
            {
                selectAllExtraPanel.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
            }
        }


        private void MainTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mainTextBox.SelectionLength == 0)
            {
                panelCopy.Enabled = false;
                cutPanel.Enabled = false;
                countSelect.Visible = false;
                countSelectSymbol.Visible = false;
            }
            else
            {
                cutPanel.Enabled = true;
                panelCopy.Enabled = true;
                countSelect.Visible = true;
                countSelectSymbol.Visible = true;
                countSelectSymbol.Text = mainTextBox.SelectionLength.ToString();
            }
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text +=DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            mainTextBox.Font = fd.Font;
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want save this file", "Save ???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                saveAs();
            }
            mainTextBox.Text = "";
            opernOrCreateNew = null;
        }

        private void FormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkEnableCutCopyPasteSelectAll();
        }

        private void VievStatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(vievStatusBarToolStripMenuItem.Checked == true)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Melnychuk Vasyl (roadstobe)", "Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want save change?", "Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                saveFile(opernOrCreateNew);
        }
    }
}
