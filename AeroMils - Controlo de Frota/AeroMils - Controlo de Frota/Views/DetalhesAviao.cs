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
        Aviao aviao = null;
        SQLiteDBContext dbContext = new SQLiteDBContext();
        public DetalhesAviao(Aviao aviao)
        {
            this.aviao = aviao;
            InitializeComponent();

            try
            {
                if (aviao != null)
                {
                    TipoLabelOutput.Text = aviao.Tipo;
                    MarcaLabelOutput.Text = aviao.marca;
                    ModeloLabelOutput.Text = aviao.modelo;
                    AutonomiaLabelOutput.Text = aviao.autonomia.ToString();
                    AnoLabelOutput.Text = aviao.anoFabrico.ToString();
                    qtdMotoresLabelOutput.Text = aviao.qtdMotores.ToString();
                    CapacidadeLabelOutput.Text = aviao.capacidade_passageiros.ToString();
                    ManutencaoLabelOutput.Text = aviao.dataUltimaManutencao.ToString();

                    switch (aviao.Tipo)
                    {
                        case "Aeronave Comercial":
                            AeronaveComercial aeronaveComercial = (AeronaveComercial)aviao;
                            dbContext.GetAeronavesComerciaisData(aeronaveComercial.id);
                            Special1LabelOutput.Text = aeronaveComercial.numeroVoosDia.ToString();
                            Special2LabelOutput.Text = aeronaveComercial.companhiaAerea;
                            break;

                        case "Aeronave de Mercadorias":
                            AeronaveMercadorias aeronaveMercadorias = (AeronaveMercadorias)aviao;
                            dbContext.GetAeronavesMercadoriasData(aeronaveMercadorias.id);
                            Special1LabelOutput.Text = aeronaveMercadorias.capacidadeCarga.ToString();
                            Special2LabelOutput.Text = aeronaveMercadorias.valorFrete.ToString();
                            break;

                        case "Aeronave Particular":
                            AeronaveParticular aeronaveParticular = (AeronaveParticular)aviao;
                            dbContext.GetAeroNaveParticularData(aeronaveParticular.id);
                            Special1LabelOutput.Text = aeronaveParticular.numProprietarios.ToString();
                            Special2LabelOutput.Text = aeronaveParticular.valorFrete.ToString();
                            break;

                        case "Avioneta":
                            Avioneta avioneta = (Avioneta)aviao;
                            dbContext.GetAvionetaData(avioneta.id);
                            Special1LabelOutput.Text = avioneta.areaDescolagem.ToString();
                            Special2LabelOutput.Text = avioneta.valorFrete.ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Precisa Selecionar um avião");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        private void enviarManutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("A informação está toda correta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dbContext.novaManutencao(Convert.ToInt32(aviao.id));
            }
        }
    }
}
