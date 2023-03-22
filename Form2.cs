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

        public void openForm()
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            valor = 1;
            Form4 form = new Form4(valor);
            form.valor = valor;
            form.Show();
            form.FormImg = Image.FromFile(class1.getImage(valor));

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            valor = 2;
            Form4 form = new Form4(valor);
            form.valor = valor;
            form.Show();
            form.FormImg = Image.FromFile(class1.getImage(valor));

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor = 3;
            Form4 form = new Form4(valor);
            form.valor = valor;
            form.Show();
            form.FormImg = Image.FromFile(class1.getImage(valor));

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor = 4;
            Form4 form = new Form4(valor);
            form.valor = valor;
            form.Show();
            form.FormImg = Image.FromFile(class1.getImage(valor));

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor = 5;
            Form4 form = new Form4(valor);
            form.valor = valor;
            form.Show();
            form.FormImg = Image.FromFile(class1.getImage(valor));

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
