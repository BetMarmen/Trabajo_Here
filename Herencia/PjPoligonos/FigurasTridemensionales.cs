using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjPoligonos
{
    public class FigurasTridemensionales:Figuras
    {
        //ya sabemos que hereda todo de la clase padre
        //definimos dos metodos, depende de la figura elegida se calcula
        public double CalcularArea(string figuraElegida)
        {
            if (figuraElegida.Equals("Esfera"))
            {
                return (4*Math.PI*Math.Pow((DiametroEsf/2), 2));
            }
            else if (figuraElegida.Equals("Cubo"))
            {
                return (6*Math.Pow(LadoCubo, 2));
            }
            else if (figuraElegida.Equals("Tetraedro"))
            {
                return (Math.Sqrt(3)*Math.Pow(LadoTetra, 2));
            }
            return 0;
        }
        public double CalcularVolumen(string figuraElegida)
        {
            if (figuraElegida.Equals("Esfera"))
            {
                return (4*Math.PI*Math.Pow((DiametroEsf/2), 3))/3;
            }
            else if (figuraElegida.Equals("Cubo"))
            {
                return (Math.Pow(LadoCubo, 3));
            }
            else if (figuraElegida.Equals("Tetraedro"))
            {
                return (Math.Sqrt(3)*Math.Pow(LadoTetra, 2))/3;
            }
            return 0;
        }
    }
}
