namespace Calculator_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresult.Text = (Int32.Parse(txtnum1.Text) + Int32.Parse(txtnum2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresult.Text = (Int32.Parse(txtnum1.Text) - Int32.Parse(txtnum2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresult.Text = (Int32.Parse(txtnum1.Text) * Int32.Parse(txtnum2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtresult.Text = (Int32.Parse(txtnum1.Text) / Int32.Parse(txtnum2.Text)).ToString();
        }
    }
}
