using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwiastki
{
    public class PierwiastkiFunkcji
    {
        public string Pierwiastki(float a, float b, float c)
        {
            float delta;
            
            delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return "Brak pierwiastkow rzeczywistych";
            }
            else if (delta == 0)
            {
                return("x0 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
            }
            else
            {
                return("x1 = " + ((-b - Math.Sqrt(delta)) / (2 * a)) + " x2 = " + ((Math.Sqrt(delta) - b) / (2 * a)));
            }
        }
    }
}
