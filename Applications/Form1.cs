using System;
using System.Drawing;
using System.Windows.Forms;

namespace Applications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ledBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ledBox.BackColor = Color.FromArgb((int)numericUpDown1.Value, Color.Red);
            }
            else if (radioButton2.Checked)
            {
                ledBox.BackColor = Color.FromArgb((int)numericUpDown1.Value, Color.Red);
            }
            else if (radioButton3.Checked)
            {
                ledBox.BackColor = Color.FromArgb((int)numericUpDown1.Value, Color.Red);
            }
            colorDialog1.ShowDialog();
            ledBox.BackColor = colorDialog1.Color;
        }
    }
}
