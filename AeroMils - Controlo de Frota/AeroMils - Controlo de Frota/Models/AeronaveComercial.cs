using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    public class AeronaveComercial : Aviao
    {
        private int _numeroVoosDia;
        private string _companhiaAerea;

        public int numeroVoosDia
        {
            get => _numeroVoosDia;
            set => _numeroVoosDia = value;
        }

        public string companhiaAerea
        {
            get => _companhiaAerea;
            set => _companhiaAerea = value;
        }

        public AeronaveComercial(int id, int numeroVoosDia, string companhiaAerea)
            : base(id)
        {
            _numeroVoosDia = numeroVoosDia;
            _companhiaAerea = companhiaAerea;
        }
    }
}
