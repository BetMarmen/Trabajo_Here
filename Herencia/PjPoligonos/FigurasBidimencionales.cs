using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjPoligonos
{
    internal class FigurasBidimencionales : Figuras
    {
        //ya sabemos que hereda todo de la clase padre
        //definimos dos metodos, depende de la figura elegida se calcula
        public double CalcularArea(string figuraElegida)
        {
            if (figuraElegida.Equals("Circulo"))
            {
                return (Math.PI* Math.Pow((DiametroCir/2),2));
            }
            else if (figuraElegida.Equals("Cuadrado"))
            {
                return Math.Pow(LadoCuad,2);
            }
            
            return 0;
        }
        public double CalcularAreaTriangulo()
        {
            double Semiperimetro = (Lado1Tri + Lado2Tri + Lado3Tri) / 2;

            return Math.Sqrt(Semiperimetro*(Semiperimetro-Lado1Tri)*(Semiperimetro - Lado2Tri)
               *(Semiperimetro - Lado3Tri));
        }
        public double CalcularPerimetro(string figuraElegida)
        {
            if (figuraElegida.Equals("Circulo"))
            {
                return (Math.PI * DiametroCir);
            }
            else if (figuraElegida.Equals("Cuadrado"))
            {
                return 4*LadoCuad;
            }
            return 0;
        }
        public double CalcularPerimetroTriangulo()
        {
            
            return (Lado1Tri + Lado2Tri + Lado3Tri);
        }

      
    }
}
