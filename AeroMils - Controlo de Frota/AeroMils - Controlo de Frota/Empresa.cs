﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
{
    internal class Empresa
    {

        public List<Aviao> ConsultarDisponiveis(List<Aviao> avioes)
        {
            List<Aviao> disponiveis = new List<Aviao>();

            foreach (var aviao in avioes)
            {
                if (aviao.ativoInativo)
                {
                    disponiveis.Add(aviao);
                }
            }

            return disponiveis;
        }

        public List<Aviao> ConsultarManutencao(List<Aviao> avioes)
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
        }
    }
}