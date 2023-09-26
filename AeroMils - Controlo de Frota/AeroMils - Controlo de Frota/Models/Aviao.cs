using AeroMils___Controlo_de_Frota.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    public class Aviao : IAviao
    {

        private int _id;

        private int _capacidade_passageiros;

        private int _autonomia;

        private DateTime _dataUltimaManutencao;

        private bool _estado;

        private int _qtdMotores;

        private string _marca;

        private string _modelo;

        private DateTime _anoFabrico;

        private string _tipo;

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                if (value >= 0) // Validate that id is non-negative
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentException("ID must be non-negative.");
                }
            }
        }

        public int capacidade_passageiros
        {
            get
            {
                return _capacidade_passageiros;
            }

            set
            {
                if (value >= 0) // Validate that capacidade_passageiros is non-negative
                {
                    _capacidade_passageiros = value;
                }
                else
                {
                    throw new ArgumentException("Capacidade de passageiros must be non-negative.");
                }
            }
        }


        public int autonomia
        {
            get
            {
                return _autonomia;
            }

            set
            {
                if (value >= 0) // Validate that autonomia is non-negative
                {
                    _autonomia = value;
                }
                else
                {
                    throw new ArgumentException("Autonomia must be non-negative.");
                }
            }
        }

        public DateTime dataUltimaManutencao
        {
            get
            {
                return _dataUltimaManutencao;
            }

            set
            {
                if (value <= DateTime.Now) // Validate that dataUltimaManutencao is not in the future
                {
                    _dataUltimaManutencao = value;
                }
                else
                {
                    throw new ArgumentException("Data de última manutenção cannot be in the future.");
                }
            }
        }

        public bool estado
        {
            get
            {
                return _estado;
            }

            set
            {
                if (value == true || value == false) // Validate that estado is a valid boolean value
                {
                    _estado = value;
                }
                else
                {
                    throw new ArgumentException("Estado must be a valid boolean value (true or false).");
                }
            }
        }

        public int qtdMotores
        {
            get
            {
                return _qtdMotores;
            }

            set
            {
                if (value >= 0) // Validate that qtdMotores is non-negative
                {
                    _qtdMotores = value;
                }
                else
                {
                    throw new ArgumentException("Quantidade de motores must be non-negative.");
                }
            }
        }

        public string marca
        {
            get
            {
                return _marca;
            }

            set
            {
                if (!string.IsNullOrEmpty(value)) // Validate that marca is not null or empty
                {
                    _marca = value;
                }
                else
                {
                    throw new ArgumentException("Marca cannot be null or empty.");
                }
            }
        }

        public string modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                if (!string.IsNullOrEmpty(value)) // Validate that modelo is not null or empty
                {
                    _modelo = value;
                }
                else
                {
                    throw new ArgumentException("Modelo cannot be null or empty.");
                }
            }
        }


        public DateTime anoFabrico
        {
            get
            {
                return _anoFabrico;
            }

            set
            {
                if (value <= DateTime.Now) // Validate that anoFabrico is not in the future
                {
                    _anoFabrico = value;
                }
                else
                {
                    throw new ArgumentException("Ano de fabrico cannot be in the future.");
                }
            }
        }


        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) // Validate that Tipo is not null or empty
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Tipo cannot be null or empty.");
                }
            }
        }


        public Aviao(int id)
        {
            this.id = id;
        }

        public Aviao(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico)
        {
            this.capacidade_passageiros = capacidade_passageiros;
            this.autonomia = autonomia;
            this.dataUltimaManutencao = data_ult_manutencao;
            this.estado = estado;
            this.qtdMotores = qtdMotores;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabrico = anoFabrico;
        }

        public void AlterarEstado(int id)
        {
        }
    }
}
