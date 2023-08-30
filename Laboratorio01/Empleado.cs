using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Empleado : Persona
    {
        public double Sueldo { get; set; }
        
        public Double CalcularImpuesto(double Impuesto)
        {

            return Sueldo * Impuesto/100 ;

        }
    }
}
