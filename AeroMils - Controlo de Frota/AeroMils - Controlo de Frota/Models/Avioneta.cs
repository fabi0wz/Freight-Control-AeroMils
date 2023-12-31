﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Modules;

namespace AeroMils___Controlo_de_Frota.Models
{
    public class Avioneta : Aviao
    {
        private int _areaDescolagem;
        private double _valorFrete;

        public int areaDescolagem
        {
            get => _areaDescolagem;
            set
            {
                if (value >= 0) // Validate that areaDescolagem is non-negative
                {
                    _areaDescolagem = value;
                }
                else
                {
                    throw new ArgumentException("Area de descolagem must be non-negative.");
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


        public Avioneta(int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca, string modelo, DateTime anoFabrico) : base(capacidade_passageiros, autonomia, data_ult_manutencao, estado, qtdMotores, marca, modelo, anoFabrico) { }

        public Avioneta(int id, int areaMinimaDescolagem, double valorFrete)
            : base(id)
        {
            _areaDescolagem = areaMinimaDescolagem;
            _valorFrete = valorFrete;
        }
    }
}
