﻿namespace AeroMils___Controlo_de_Frota.Models
{
    internal interface IAviao
    {
        DateTime anoFabrico { get; set; }
        int autonomia { get; set; }
        int capacidade_passageiros { get; set; }
        DateTime dataUltimaManutencao { get; set; }
        bool estado { get; set; }
        string marca { get; set; }
        string modelo { get; set; }
        int qtdMotores { get; set; }

        void AlterarEstado();
    }
}