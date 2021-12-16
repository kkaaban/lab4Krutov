namespace lab4Krutov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Are you sure?", "laboratory", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            textBox1.Text = ds.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("What to do?", "laboratory", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            textBox1.Text = ds.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.ShowDialog();
            textBox1.Text = OPF.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.OK)
            {
                button5.Enabled = true;
                textBox1.Text = form.EnterMessage;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            textBox1.Text = form.NumOfOption.ToString();

        }
    }
}