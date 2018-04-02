using System;
using System.Windows.Forms;

namespace MD5HASH
{
    public partial class Menu : Form
    {
        MD5 md5;

        public Menu()
        {
            InitializeComponent();
            md5 = new MD5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            md5.Value = textBox1.Text;
            textBox2.Text = md5.FingerPrint;
        }
    }
}
