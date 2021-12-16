using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4Krutov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool OK { get; set; } = false;
        public string EnterMessage { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            OK = true;
            EnterMessage = textBox1.Text;
            this.Close();
        }
        public int NumOfOption { get; set; }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            NumOfOption = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NumOfOption = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            NumOfOption = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            NumOfOption = 4;
        }
    }
}
