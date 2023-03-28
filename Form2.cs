namespace ATLS_TALKHAND
{
    public partial class Form2 : Form
    {
        int valor;
        Class1 class1 = new Class1();
        public Form2()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int valor = int.Parse(button.Tag.ToString());
            Form4 form = new Form4(valor);
            form.valor = valor;
            form.Show();
            form.FormImg = Image.FromFile(class1.getImage(valor));
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Tag = 1;
            button_Click(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Tag = 2;
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Tag = 3;
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Tag = 4;
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Tag = 5;
            button_Click(sender, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            translate(6);
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            translate(7);
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            translate(11);
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            translate(8);
            this.Close();
        }

        public void translate(int valor)
        {
            Form4 form4 = new Form4(valor);
            form4.valor = valor;
            if (valor != 11 || valor != 12 || valor != 13 || valor != 14 || valor != 15 || valor != 16)
            {
                form4.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
            }
            else
            {
                System.Drawing.Image gif = System.Drawing.Image.FromFile(class1.getImage(valor));
                form4.pictureBox1.Image = gif;


            }

            form4.Show();
        }

    }
}
