using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Trigo : Cultivo
    {
        public Trigo() : base("Trigo") { }

        public override double CalcularGanancia()
            
        {
            return 600;
        }
    }
}
