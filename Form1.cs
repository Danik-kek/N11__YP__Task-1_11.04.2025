namespace N11__YP__Task1_11._04._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                label1.Text = "Result=ok";
            }
            else { label1.Text = "Result= Cancel"; }
        }
    }
}
