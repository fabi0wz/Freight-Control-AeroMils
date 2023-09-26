using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Modules;

namespace AeroMils___Controlo_de_Frota.Models
{
    public class AeronaveParticular : Aviao
    {
        private int _numProprietarios;
        private double _valorFrete;
        public int numProprietarios
        {
            get => _numProprietarios;
            set
            {
                if (value >= 0) // Validate that numProprietarios is non-negative
                {
                    _numProprietarios = value;
                }
                else
                {
                    throw new ArgumentException("Number of proprietarios must be non-negative.");
                }
            }
        }

        public double valorFrete
        {
            get => _valorFrete;
            set
            {
                if (value >= 0) // Validate that valorFrete is non-negative
                {
                    _valorFrete = value;
                }
                else
                {
                    throw new ArgumentException("Valor do frete must be non-negative.");
                }
            }
        }



        public AeronaveParticular(int id, int numProprietarios, double valorFrete)
        : base(id)
        {
            _numProprietarios = numProprietarios;
            _valorFrete = valorFrete;
        }

        
    }
}
