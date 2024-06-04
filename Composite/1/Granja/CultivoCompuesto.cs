using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class CultivoCompuesto : Cultivo
    {
        private List<Cultivo> cultivos = new List<Cultivo>();
       
        public CultivoCompuesto(string _nombre) : base(_nombre)
        {
        }

        public void AgregarCultivo(Cultivo c)
        {
            cultivos.Add(c);
        }
        public void RemoverCultivo(Cultivo c)
        {
            cultivos.Remove(c);
        }

        public override double CalcularGanancia()
        {
            decimal ganancia = 0;
            foreach (var c in cultivos)
            {
                if (c is Trigo)
                {

                }
            }
        }
    }
}
