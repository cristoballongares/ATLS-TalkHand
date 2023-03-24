using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

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
            ["Hola"] = 6
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
            label1.Text = valor.ToString();
            Form4 form4 = new Form4(valor);
            form4.valor = valor;
            string imagePath = Path.Combine(path, "img", "a.png");

            if (File.Exists(imagePath))
            {
                form4.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
            }
            else
            {
                MessageBox.Show("La imagen no existe en la ruta especificada.");
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
                
                if(valoresLetras.TryGetValue(valorVariable, out valor)) { 
                    translate(valor);
                }


                objetoJson["letra"] = "x";
                string newContent = JsonConvert.SerializeObject(objetoJson);
                File.WriteAllText(jsPath, newContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

   
    }
}
