using System.Windows.Forms;

namespace ATLS_TALKHAND
{
    internal class Class1
    {
        public int tipo;
        public int letra;

        
        public string infoLetra(int numeroLetra)
        {
            string info;
            switch (numeroLetra) {
                case 1:  info = "Con la mano cerrada, se muestran\nlas uñas y se estira el dedo pulgar\n hacia un lado. La palma mira al frente.";
                break;

                case 2:  info = "Los dedos índice, medio, anular y\nmeñique se mantienen bien unidos y en\nposición cóncava; el pulgar también se pone en\n esa posición. La palma mira a un lado";
                break;

                case 3: info = "Con la mano cerrada, el dedo meñique\n se estira señalando hacia arriba.\n La palma se pone de lado.";
                break;

                case 4: info = "Con la mano se forma una letra o.\nTodos los dedos se tocan por las puntas.";
                break;

                case 5: info = "Con la mano cerrada, se estiran los\n dedos índice y medio unidos.\n La palma mira al frente.";
                break;

                case 6: info = "Junta los dedos pulgar, índice y\n medio. Lleva la mano nhacia la altura\n del hombro, manteniendo la palma\n  hacia abajo.";
                break;

                default:
                    info = "asd";
                    break;
            }
            return info;

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
                case 6: return "Hola";
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
                    ub = Path.Combine(path, "img/hola.jpeg");
                    return ub;


            }
            {
                return null;
            }
        }
    }
}
