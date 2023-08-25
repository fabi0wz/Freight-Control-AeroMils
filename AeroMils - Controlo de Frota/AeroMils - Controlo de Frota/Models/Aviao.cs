using AeroMils___Controlo_de_Frota.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    internal class Aviao : IAviao
    {

        private int id;

        private int _capacidade_passageiros;

        private int _autonomia;

        private DateTime _dataUltimaManutencao;

        private bool _estado;

        private int _qtdMotores;

        private string _marca;

        private string _modelo;

        private DateTime _anoFabrico;


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

        public Aviao(int id, int capacidade_passageiros, int autonomia, DateTime dataUltimaManutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico)
        {
            if (id >= 0) 
            {
                this.id = id;
            }
            else
            {
                this.id = SQLiteDBContext.GetLastPlaneID() + 1;
            }
            this.capacidade_passageiros = capacidade_passageiros;
            this.autonomia = autonomia;
            this.dataUltimaManutencao = dataUltimaManutencao;
            this.estado = estado;
            this.qtdMotores = qtdMotores;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabrico = anoFabrico;
        }

        public void AlterarEstado(int id)
        {
            SQLiteDBContext.ChangePlaneStatus(id);
        }

  

        /*public List<Aviao> ConsultarDisponiveis(List<Aviao> avioes)
        {
            List<Aviao> disponiveis = new List<Aviao>();

            foreach (var aviao in avioes)
            {
                if (aviao.estado)
                {
                    disponiveis.Add(aviao);
                }
            }

            return disponiveis;
        }*/

        /*public List<Aviao> ConsultarManutencao(List<Aviao> avioes)
        {
            List<Aviao> emManutencao = new List<Aviao>();

            foreach (var aviao in avioes)
            {
                if (aviao.dataUltimaManutencao < DateTime.Now)
                {
                    emManutencao.Add(aviao);
                }
            }

            return emManutencao;
        }*/

    }
}
