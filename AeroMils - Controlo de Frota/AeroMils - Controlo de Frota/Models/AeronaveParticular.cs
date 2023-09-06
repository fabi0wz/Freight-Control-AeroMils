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
            set => _numProprietarios = value;
        }
        public double valorFrete
        {
            get => _valorFrete;
            set => _valorFrete = value;
        }


        public AeronaveParticular(int id, int numProprietarios, double valorFrete)
        : base(id)
        {
            _numProprietarios = numProprietarios;
            _valorFrete = valorFrete;
        }

        
    }
}
