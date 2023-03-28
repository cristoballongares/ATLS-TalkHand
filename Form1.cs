using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json.Serialization;
using static IronPython.Modules._ast;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Imaging;


namespace ATLS_TALKHAND
{
    public partial class Form1 : Form
    {
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory;
        private readonly Class1 class1 = new Class1();
        private readonly Dictionary<string, int> valoresLetras = new Dictionary<string, int>
        {
            ["letra a"] = 1,
            ["letra e"] = 2,
            ["letra i"] = 3,
            ["letra o"] = 4,
            ["letra u"] = 5,
            ["Hola"] = 6,
            ["hola"] = 6,
            ["adi\u00f3s"] = 7,
            ["adios"] = 7,
            ["Adios"] = 7,
            ["gracias"] = 8,
            ["Gracias"] = 8,
            ["denada"] = 9,
            ["Denada"] = 9,
            ["de nada"] = 9,
            ["De nada"] = 9,
            ["C\u00f3mo est\u00e1s"] = 11,
            ["como estas"] = 11,
            ["perd\u00f3n"] = 12,
            ["perdon"] = 12,
            ["no"] = 13,
            ["si"] = 14,
            ["s\u00ed"] = 14,
            ["bien"] = 15,
            ["mal"] = 16

        };



        int valor;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


        private void button2_Click(object sender, EventArgs e)
        {


            string trPath = Path.Combine(path, "traductor\\translate.exe");

            Process proceso = Process.Start(trPath);
            proceso.WaitForExit();
            Thread.Sleep(2000);
            string jsPath = Path.Combine(path, "info.json");
            try
            {
                string contenidoJson = File.ReadAllText(jsPath);
                dynamic objetoJson = JsonConvert.DeserializeObject(contenidoJson);
                string valorVariable = objetoJson["letra"];
                int valor;

                if (valoresLetras.TryGetValue(valorVariable, out valor))
                {
                    translate(valor);
                }


                objetoJson["letra"] = "x";
                string newContent = JsonConvert.SerializeObject(objetoJson);
                File.WriteAllText(jsPath, newContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Palabra no encontrada " + ex);
                throw;
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {

            string fullPath = Path.Combine(path, "general\\app.exe");

            Process.Start(fullPath);




        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string texto = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el texto\nEj: hola, letra a, adios", "Texto");
            if (!string.IsNullOrWhiteSpace(texto))
            {
            
               string valorVariable = texto;
               int valor;
               string newText = texto.ToLower();

                if (valoresLetras.TryGetValue(newText, out valor))
                {
                    translate(valor);
                }

            }
        }
    }
}
