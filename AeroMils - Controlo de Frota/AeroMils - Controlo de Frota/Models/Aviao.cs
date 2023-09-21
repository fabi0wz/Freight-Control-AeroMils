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
                _id = value;
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
                _capacidade_passageiros = value;
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
                _autonomia = value;
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
                _dataUltimaManutencao = value;
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
                _estado = value;
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
                _qtdMotores = value;
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
                _marca = value;
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
                _modelo = value;
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
                _anoFabrico = value;
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
                _tipo = value;
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
