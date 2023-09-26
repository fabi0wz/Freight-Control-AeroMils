using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    internal class Aeroporto
    {
        private string _localizacao;
        private int _numeroPistas;
        private int _capacidadeAtendimento;

        public string localizacao
        {
            get => _localizacao;
            set => _localizacao = value;
        }

        public int numeroPistas
        {
            get => _numeroPistas;
            set => _numeroPistas = value;
        }

        public int capacidadeAtendimento
        {
            get => _capacidadeAtendimento;
            set => _capacidadeAtendimento = value;
        }

        public Aeroporto(string localizacao, int numeroPistas, int capacidadeAtendimento)
        {
            _localizacao = localizacao;
            _numeroPistas = numeroPistas;
            _capacidadeAtendimento = capacidadeAtendimento;
        }

    }
}
