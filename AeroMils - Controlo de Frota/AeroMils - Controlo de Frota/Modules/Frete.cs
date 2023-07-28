using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Modules
{
    internal class Frete
    {
        private double _valorFrete;

        public Frete(double valorFrete)
        {
            _valorFrete = valorFrete;
        }

        public double ValorFrete { get { return _valorFrete; } }
        public double calculoFrete(int numDias) { return _valorFrete * numDias; }
    }
}
