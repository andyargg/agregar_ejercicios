using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Soja : Cultivo
    {
        public Soja() : base("Soja") { }

        public override double CalcularGanancia()
        {
            return 400;
        }
    }
}
