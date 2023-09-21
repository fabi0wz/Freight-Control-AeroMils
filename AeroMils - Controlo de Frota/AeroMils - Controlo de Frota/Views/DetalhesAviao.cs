using AeroMils___Controlo_de_Frota.Data.DbContext;
using AeroMils___Controlo_de_Frota.Models;
using AeroMils___Controlo_de_Frota.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class DetalhesAviao : Form
    {

        public DetalhesAviao(Aviao aviao)
        {
            InitializeComponent();

            TipoLabelOutput.Text = aviao.Tipo;
            MarcaLabelOutput.Text = aviao.marca;
            ModeloLabelOutput.Text = aviao.modelo;
            AutonomiaLabelOutput.Text = aviao.autonomia.ToString();
            AnoLabelOutput.Text = aviao.anoFabrico.ToString();
            QuantidadeLabelOutput.Text = aviao.qtdMotores.ToString();
            CapacidadeLabelOutput.Text = aviao.capacidade_passageiros.ToString();
            ManutencaoLabelOutput.Text = aviao.dataUltimaManutencao.ToString();

            switch (aviao.Tipo)
            {
                case "AeronaveComercial":
                    break;
                case "AeronaveMercadorias":

                    break;
                case "AeronaveParticular":

                    break;
                case "Avioneta":

                    break;
            }
        }


    }
}
