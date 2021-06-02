using System;
using System.Windows.Forms;

namespace Automacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton.Checked == true)
                {
                MessageBox.Show("Clicou no radio button","Teste");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oi");
        }
    }
}
