using System.Drawing.Drawing2D;

namespace ATLS_TALKHAND
{
    public partial class Form4 : Form
    {

        public Form4(int valor)
        {
            InitializeComponent();
            this.valor = valor;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


        }

        public Image FormImg
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public int valor { get; set; }

        private void Form4_Load(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();


            if (valor == 16)
            {
                label1.Text = class1.infoLetra(valor);
                label1.Font = new Font(label1.Font.FontFamily, 10);
            } else { 
            label1.Text = class1.infoLetra(valor);
            label2.Text = class1.getLetra(valor);
            }

            if(valor == 11) { 
            
            label2.Text = class1.getLetra(valor);
            label2.Font = new Font(label1.Font.FontFamily, 14);
        } else { 
            label1.Text = class1.infoLetra(valor);
            label2.Text = class1.getLetra(valor);
            }

            // Titulo del formulario dependiendo la letra que escogio
            this.Text = class1.getLetra(valor);

            //Cambiamos backcolor


            System.Drawing.Drawing2D.GraphicsPath panelPath = new System.Drawing.Drawing2D.GraphicsPath();
            panelPath.StartFigure();
            panelPath.AddArc(0, 0, 20, 20, 180, 90);
            panelPath.AddLine(20, 0, panel1.Width - 20, 0);
            panelPath.AddArc(panel1.Width - 20, 0, 20, 20, 270, 90);
            panelPath.AddLine(panel1.Width, 20, panel1.Width, panel1.Height - 20);
            panelPath.AddArc(panel1.Width - 20, panel1.Height - 20, 20, 20, 0, 90);
            panelPath.AddLine(panel1.Width - 20, panel1.Height, 20, panel1.Height);
            panelPath.AddArc(0, panel1.Height - 20, 20, 20, 90, 90);
            panelPath.CloseFigure();
            panel1.Region = new System.Drawing.Region(panelPath);

        }

        private void Form4_SizeChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 20;
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - borderRadius, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();
            pictureBox1.Region = new Region(path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.DrawImage(pictureBox1.Image, rect);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
    }
}
