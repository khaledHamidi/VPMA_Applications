using System.Drawing;
using System.Windows.Forms;

namespace Applications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // كود يبدأ عند تشغيل البرنامج
        }

        private void redRb_CheckedChanged(object sender, System.EventArgs e)
        {
            if(redRb.Checked)
            {
                ledBox.BackColor = Color.Red;
            }
        }

        private void brightnessNud_ValueChanged(object sender, System.EventArgs e)
        {
            ledBrightnessLb.Text = brightnessNud.Value.ToString();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ledBox.BackColor = Color.Black;
        }
    }
}
