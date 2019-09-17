using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Some_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");
        }


        double pi = 3.141592653589793;
        double c = 299792458;
        


        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
