using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Find : Form
    {
        int positionFind;
        public Find()
        {
            InitializeComponent();
        }

        private void buttonCancale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            /*if (this.Owner?.Controls["textBox1"].Text.IndexOf(textBoxFind.Text) != -1)
            {
                (this.Owner?.Controls["textBox1"] as TextBox).SelectionStart = (int)this.Owner?.Controls["textBox1"].Text.IndexOf(textBoxFind.Text);
                (this.Owner?.Controls["textBox1"] as TextBox).SelectionLength = textBoxFind.TextLength;
                positionFind = (int)this.Owner?.Controls["textBox1"].Text.IndexOf(textBoxFind.Text);
                positionFind++;
            }
            else
                MessageBox.Show($"not find: {textBoxFind.Text}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);*/


            FindAndSelect(textBoxFind.Text);
        }
        public bool FindAndSelect(string TextToFind)
        {

            int position = (this.Owner?.Controls["textBox1"] as TextBox).Text.IndexOf(TextToFind, positionFind);

            if (position == -1)
            {
                MessageBox.Show($"not find: {textBoxFind.Text}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            (this.Owner?.Controls["textBox1"] as TextBox).SelectionStart = position;
            (this.Owner?.Controls["textBox1"] as TextBox).SelectionLength = TextToFind.Length;
            positionFind = position;
            positionFind++;
            return true;
        }
    }
}
