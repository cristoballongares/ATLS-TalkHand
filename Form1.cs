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
        string path = AppDomain.CurrentDomain.BaseDirectory; // ubicacion actual
        int valor;
        Class1 class1 = new Class1();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); */
        

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

                switch(valorVariable)
                {
                    case "letra a":
                        valor = 1;
                        Form4 form = new Form4(valor);
                        form.valor = valor;
                        form.Show();
                        form.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;

                    case "letra e":
                        valor = 2;
                        Form4 form1 = new Form4(valor);
                        form1.valor = valor;
                        form1.Show();
                        form1.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;

                    case "letra i":
                        valor = 3;
                        Form4 form2 = new Form4(valor);
                        form2.valor = valor;
                        form2.Show();
                        form2.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;

                    case "letra o":
                        valor = 4;
                        Form4 form3 = new Form4(valor);
                        form3.valor = valor;
                        form3.Show();
                        form3.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;

                    case "letra u":
                        valor = 5;
                        Form4 form4 = new Form4(valor);
                        form4.valor = valor;
                        form4.Show();
                        form4.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;

                    case "hola":
                        valor = 6;
                        Form4 form5 = new Form4(valor);
                        form5.valor = valor;
                        form5.Show();
                        form5.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;
                    case "que":
                        valor = 7;
                        Form4 form6 = new Form4(valor);
                        form6.valor = valor;
                        form6.Show();
                        form6.FormImg = System.Drawing.Image.FromFile(class1.getImage(valor));
                        break;
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
