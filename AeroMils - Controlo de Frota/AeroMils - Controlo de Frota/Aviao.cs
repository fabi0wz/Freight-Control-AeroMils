﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class Aviao
    {
        private int _capacidade_passageiros;

        private int _autonomia;

        private DateTime _dataUltimaManutencao;

        private bool _ativoInativo;

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

        public bool ativoInativo
        {
            get
            {
                return _ativoInativo;
            }

            set
            {
                _ativoInativo = value;
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

    public Aviao(int capacidade_passageiros, int autonomia, DateTime dataUltimaManutencao, bool ativoInativo, int qtdMotores, string marca, string modelo, DateTime anoFabrico)
        {
            this.capacidade_passageiros = capacidade_passageiros;
            this.autonomia = autonomia;
            this.dataUltimaManutencao = dataUltimaManutencao;
            this.ativoInativo = ativoInativo;
            this.qtdMotores = qtdMotores;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabrico = anoFabrico;
        }

        public void AlterarEstado()
        {
            ativoInativo = !ativoInativo;
        }

    }
}
