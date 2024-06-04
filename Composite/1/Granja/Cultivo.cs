using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public abstract class Cultivo
    {
        private string _nombre;

        public Cultivo(string _nombre) 
        {
            this._nombre = _nombre;
        }

        public string Nombre
        { 
            get { return _nombre; }
            set { _nombre = value; }
        }

        public abstract double CalcularGanancia();
       
        //public abstract int ObtenerTamaño { get; }
    }
}
