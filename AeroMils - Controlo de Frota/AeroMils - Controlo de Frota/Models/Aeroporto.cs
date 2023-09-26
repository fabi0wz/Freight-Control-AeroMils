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
            set
            {
                if (!string.IsNullOrEmpty(value)) // Validate that localizacao is not null or empty
                {
                    _localizacao = value;
                }
                else
                {
                    throw new ArgumentException("Localizacao cannot be null or empty.");
                }
            }
        }


        public int numeroPistas
        {
            get => _numeroPistas;
            set
            {
                if (value >= 0) // Validate that numeroPistas is non-negative
                {
                    _numeroPistas = value;
                }
                else
                {
                    throw new ArgumentException("Numero de pistas must be non-negative.");
                }
            }
        }


        public int capacidadeAtendimento
        {
            get => _capacidadeAtendimento;
            set
            {
                if (value >= 0) // Validate that capacidadeAtendimento is non-negative
                {
                    _capacidadeAtendimento = value;
                }
                else
                {
                    throw new ArgumentException("Capacidade de atendimento must be non-negative.");
                }
            }
        }


        public Aeroporto(string localizacao, int numeroPistas, int capacidadeAtendimento)
        {
            _localizacao = localizacao;
            _numeroPistas = numeroPistas;
            _capacidadeAtendimento = capacidadeAtendimento;
        }

    }
}
