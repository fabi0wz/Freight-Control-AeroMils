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
                    // Display general information about the aircraft
                    TipoLabelOutput.Text = aviao.Tipo;
                    MarcaLabelOutput.Text = aviao.marca;
                    ModeloLabelOutput.Text = aviao.modelo;
                    AutonomiaLabelOutput.Text = aviao.autonomia.ToString();
                    AnoLabelOutput.Text = aviao.anoFabrico.ToString();
                    qtdMotoresLabelOutput.Text = aviao.qtdMotores.ToString();
                    CapacidadeLabelOutput.Text = aviao.capacidade_passageiros.ToString();
                    ManutencaoLabelOutput.Text = aviao.dataUltimaManutencao.ToString();

                    // Use a switch statement to handle different types of aircraft
                    switch (aviao.Tipo)
                    {
                        case "Aeronave Comercial":
                            // If the aircraft is a commercial airplane, cast it to the specific type
                            AeronaveComercial aeronaveComercial = (AeronaveComercial)aviao;
                            // Call a method to get additional data for commercial airplanes
                            dbContext.GetAeronavesComerciaisData(aeronaveComercial.id);
                            // Display special information for commercial airplanes
                            Special1LabelOutput.Text = aeronaveComercial.numeroVoosDia.ToString();
                            Special2LabelOutput.Text = aeronaveComercial.companhiaAerea;
                            break;

                        case "Aeronave de Mercadorias":
                            // If the aircraft is a cargo airplane, cast it to the specific type
                            AeronaveMercadorias aeronaveMercadorias = (AeronaveMercadorias)aviao;
                            // Call a method to get additional data for cargo airplanes
                            dbContext.GetAeronavesMercadoriasData(aeronaveMercadorias.id);
                            // Display special information for cargo airplanes
                            Special1LabelOutput.Text = aeronaveMercadorias.capacidadeCarga.ToString();
                            Special2LabelOutput.Text = aeronaveMercadorias.valorFrete.ToString();
                            break;

                        case "Aeronave Particular":
                            // If the aircraft is a private airplane, cast it to the specific type
                            AeronaveParticular aeronaveParticular = (AeronaveParticular)aviao;
                            // Call a method to get additional data for private airplanes
                            dbContext.GetAeroNaveParticularData(aeronaveParticular.id);
                            // Display special information for private airplanes
                            Special1LabelOutput.Text = aeronaveParticular.numProprietarios.ToString();
                            Special2LabelOutput.Text = aeronaveParticular.valorFrete.ToString();
                            break;

                        case "Avioneta":
                            // If the aircraft is an avioneta, cast it to the specific type
                            Avioneta avioneta = (Avioneta)aviao;
                            // Call a method to get additional data for avionetas
                            dbContext.GetAvionetaData(avioneta.id);
                            // Display special information for avionetas
                            Special1LabelOutput.Text = avioneta.areaDescolagem.ToString();
                            Special2LabelOutput.Text = avioneta.valorFrete.ToString();
                            break;
                    }
                }
                else
                {
                    // Show a message if no aircraft is selected
                    MessageBox.Show("Precisa Selecionar um avião");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        // Event handler for the "Enviar Manutenção" button
        private void enviarManutButton_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before performing an action
            DialogResult result = MessageBox.Show("A informação está toda correta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Call a method to record a new maintenance entry in the database
                dbContext.novaManutencao(Convert.ToInt32(aviao.id));
            }
        }
    }

}
