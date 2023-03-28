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

                case 7: 
                    info = "Levanta la mano derecha con la palma\n hacia adelante y los dedos juntos.\nLuego, agita la mano de un lado \na otro varias veces.";
                    break;

                case 8: 
                    info = "Con el dedo medio de la mano \nizquierda, llevalo en la parte \nde en medio de la palma de la otra mano";  
                    break;

                case 9:
                    info = "Con el pulgar levantado, llevalo\n al menton y despues haz un\n movimiento hacia afuera con el pulgar";
                    break;

                case 10:
                    info = "Con el pulgar levantado, llevalo\n al menton y despues haz un\n movimiento hacia afuera con el pulgar";
                    break;

                case 11:
                    info = "Con las dos manos abiertas y viendo\n hacia abajo, se juntan, \ndespues se voltean y se bajan";
                    break;
                case 12:
                    info = "Alzamos nuestra palma, bajamos los 3\n dedos de en medio dejando el\n meñique y pulgar levantado y la \nllevamos al menton";
                        break;
                case 13:
                    info = "Cerramos la mano y alzamos el dedo \nmedio, el indice y el pulgar y \ncerramos los dedos";
                    break;
                case 14:
                    info = "Cerramos la mano y alzamos el \nmeñique despues bajamos la \nmitad deldedo meñique";
                    break;
                case 15:
                    info = "Alzamos nuestra mano y la abrimos\n, escondemos el pulgar y \nllevamos la mano al menton, despues hacemos un \nlijero empuje hacia afuera";
                    break;
                case 16:
                    info = "Alzamos nuestra mano y la abrimos\n, escondemos el pulgar y llevamos la\n mano almenton pero de forma en que\n los dedos queden de lado, despues\n bajamos la muñeca";
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
                case 7: return "Adios";
                case 8: return "Gracias";
                case 9: return "Denada";
                case 10: return "Denada ";
                case 11: return "¿Como estas?";
                case 12: return "Perdon";
                case 13: return "No";
                case 14: return "Si";
                case 15: return "Bien";
                case 16: return "Mal";
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
                case 7:
                    ub = Path.Combine(path, "img/adios.png");
                    return ub;
                case 8:
                    ub = Path.Combine(path, "img/gracias.png");
                    return ub;
                case 9:
                    ub = Path.Combine(path, "img/denada.png");
                    return ub;
                case 10:
                    ub = Path.Combine(path, "img/denada.png");
                    return ub;
                case 11:
                    ub = Path.Combine(path, "img/comoestas.gif");
                    return ub;
                case 12:
                    ub = Path.Combine(path, "img/perdon.gif");
                    return ub;
                case 13:
                    ub = Path.Combine(path, "img/no.gif");
                    return ub;
                case 14:
                    ub = Path.Combine(path, "img/si.gif");
                    return ub;
                case 15:
                    ub = Path.Combine(path, "img/bien.gif");
                    return ub;
                case 16:
                    ub = Path.Combine(path, "img/mal.gif");
                    return ub;

            }
            {
                return null;
            }
        }
    }
}
