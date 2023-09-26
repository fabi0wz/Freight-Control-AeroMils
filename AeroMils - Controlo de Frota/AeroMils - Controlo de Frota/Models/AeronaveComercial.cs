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
            set
            {
                if (value >= 0) // Validate that numeroVoosDia is non-negative
                {
                    _numeroVoosDia = value;
                }
                else
                {
                    throw new ArgumentException("Número de voos por dia must be non-negative.");
                }
            }
        }

        public string companhiaAerea
        {
            get => _companhiaAerea;
            set
            {
                if (!string.IsNullOrEmpty(value)) // Validate that companhiaAerea is not null or empty
                {
                    _companhiaAerea = value;
                }
                else
                {
                    throw new ArgumentException("Companhia aérea cannot be null or empty.");
                }
            }
        }

        public AeronaveComercial(int id, int numeroVoosDia, string companhiaAerea)
            : base(id)
        {
            _numeroVoosDia = numeroVoosDia;
            _companhiaAerea = companhiaAerea;
        }
    }
}
