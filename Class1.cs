namespace ATLS_TALKHAND
{
    internal class Class1
    {
        public int tipo;
        public int letra;

        public void openForm(int valor)
        {
            Form4 form4 = new Form4(valor);

        }

        public void modifyForm(int numeroLetra, Form formulario)
        {
            string info;
            switch (numeroLetra)
            {
                case 1:
                    info = "Con la mano cerrada, se muestran\nlas uñas y se estira el dedo pulgar\n hacia un lado. La palma mira al frente.";
                    Label label = formulario.Controls["label1"] as Label;
                    label.Text = info;
                    break;

                case 2:
                    info = "Los dedos índice, medio, anular y\nmeñique se mantienen bien unidos y en\nposición cóncava; el pulgar también se pone en\n esa posición. La palma mira a un lado";
                    break;

                case 3:
                    info = "Con la mano cerrada, el dedo meñique\n se estira señalando hacia arriba.\n La palma se pone de lado.";
                    break;

                case 4:
                    info = "Con la mano se forma una letra o.\nTodos los dedos se tocan por las puntas.";
                    break;

                case 5:
                    info = "Con la mano cerrada, se estiran los\n dedos índice y medio unidos.\n La palma mira al frente.";
                    break;
            }
            

        }

        public string infoLetra(int numeroLetra)
        {
            string info;
            switch (numeroLetra) {
                case 1:  info = "Con la mano cerrada, se muestran\nlas uñas y se estira el dedo pulgar\n hacia un lado. La palma mira al frente.";
                return info;

                case 2:  info = "Los dedos índice, medio, anular y\nmeñique se mantienen bien unidos y en\nposición cóncava; el pulgar también se pone en\n esa posición. La palma mira a un lado";
                return info;

                case 3: info = "Con la mano cerrada, el dedo meñique\n se estira señalando hacia arriba.\n La palma se pone de lado.";
                return info;

                case 4: info = "Con la mano se forma una letra o.\nTodos los dedos se tocan por las puntas.";
                return info;

                case 5: info = "Con la mano cerrada, se estiran los\n dedos índice y medio unidos.\n La palma mira al frente.";
                return info;
            }
            return null;

        }

        public string getLetra(int numeroLetra)
        {
            switch(numeroLetra)
            {
                case 1: return "Letra A"; 
                case 2: return "Letra E";
                case 3: return "Letra I";
                case 4: return "Letra O";
                case 5: return "Letra U";
            }
            
            return "x";
        }
        public string getImage(int numeroLetra)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string ub;

            switch(numeroLetra)
            {
                case 1:
                    ub = Path.Combine(path, "img/a.png");
                    return ub;
                case 2:
                    ub = Path.Combine(path, "img/e.png");
                    return ub;
                case 3:
                    ub = Path.Combine(path, "img/i.png");
                    return ub;
                case 4:
                    ub = Path.Combine(path, "img/o.png");
                    return ub;
                case 5:
                    ub = Path.Combine(path, "img/u.png");
                    return ub;
                case 6:
                    ub = Path.Combine(path, "img/hola.png");
                    return ub;


            }
            {
                return null;
            }
        }
    }
}
