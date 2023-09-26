using AeroMils___Controlo_de_Frota.Data.DbContext;
using AeroMils___Controlo_de_Frota.Models;
using AeroMils___Controlo_de_Frota.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class NovaReserva : Form
    {
        List<Aeroporto> aeroportos = new List<Aeroporto>();

        SQLiteDBContext dbContext = new SQLiteDBContext();
        // fields
        private string currentButton = "AeronaveComercial";

        public NovaReserva()
        {
            

            aeroportos.Add(new Aeroporto("Porto", 2, 1000));
            aeroportos.Add(new Aeroporto("Lisboa", 3, 2000));
            aeroportos.Add(new Aeroporto("Istambul", 4, 3000));
            aeroportos.Add(new Aeroporto("Italia", 5, 4000));
            aeroportos.Add(new Aeroporto("França", 6, 5000));
            aeroportos.Add(new Aeroporto("Espanha", 7, 6000));
            aeroportos.Add(new Aeroporto("Inglaterra", 8, 7000));
            aeroportos.Add(new Aeroporto("Canada", 9, 8000));
            aeroportos.Add(new Aeroporto("México", 10, 9000));
            aeroportos.Add(new Aeroporto("Brasil", 11, 10000));
            aeroportos.Add(new Aeroporto("Japão", 12, 11000));
            aeroportos.Add(new Aeroporto("Koreia", 13, 12000));
            aeroportos.Add(new Aeroporto("China", 14, 13000));
            aeroportos.Add(new Aeroporto("Finlandia", 15, 14000));
            aeroportos.Add(new Aeroporto("Russia", 16, 15000));

            


            InitializeComponent();
            dbContext.getAvailablePlanes(listaAvioesInput, currentButton);
            valorFreteLabel.Hide();
            Valor_label.Hide();

            foreach (Aeroporto aeroporto in aeroportos)
            {

                localPartidaInput.Items.Add(aeroporto.localizacao);
                localDestinoInput.Items.Add(aeroporto.localizacao);
            }
            startDateInput.Value = DateTime.Now;
            endDateInput.Value = DateTime.Now.AddDays(1);
        }

        private void VooComercial_button_Click(object sender, EventArgs e)
        {
            valorFreteLabel.Hide();
            Valor_label.Hide();

            currentButton = "AeronaveComercial";
            resetColors();
            VooComercial_button.BackColor = Color.FromArgb(255, 98, 45);
            listaAvioesInput.Items.Clear();
            listaAvioesInput.SelectedItem = null;

            dbContext.getAvailablePlanes(listaAvioesInput, currentButton);

            verificarDisponiveis(listaAvioesInput);

        }

        private void VooParticular_button_Click(object sender, EventArgs e)
        {
            valorFreteLabel.Show();
            Valor_label.Show();

            currentButton = "AeronaveParticular";
            resetColors();
            VooParticular_button.BackColor = Color.FromArgb(255, 98, 45);
            listaAvioesInput.Items.Clear();
            listaAvioesInput.SelectedItem = null;

            dbContext.getAvailablePlanes(listaAvioesInput, currentButton);
            verificarDisponiveis(listaAvioesInput);
        }

        private void VooMercadoria_button_Click(object sender, EventArgs e)
        {
            valorFreteLabel.Show();
            Valor_label.Show();

            currentButton = "AeronaveMercadorias";
            resetColors();
            VooMercadoria_button.BackColor = Color.FromArgb(255, 98, 45);
            listaAvioesInput.Items.Clear();
            listaAvioesInput.SelectedItem = null;

            dbContext.getAvailablePlanes(listaAvioesInput, currentButton);
            verificarDisponiveis(listaAvioesInput);

        }

        private void Avionetas_button_Click(object sender, EventArgs e)
        {
            valorFreteLabel.Show();
            Valor_label.Show();

            currentButton = "Avioneta";
            resetColors();
            Avionetas_button.BackColor = Color.FromArgb(255, 98, 45);
            listaAvioesInput.Items.Clear();
            listaAvioesInput.SelectedItem = null;

            dbContext.getAvailablePlanes(listaAvioesInput, currentButton);
            verificarDisponiveis(listaAvioesInput);
        }

        private void Reservar_button_Click(object sender, EventArgs e)
        {
            while (!validations())
            {
                return;
            }


            string nomeCliente = nomeClienteInput.Text;
            DateTime dataPartida = startDateInput.Value;
            DateTime dataRetorno = endDateInput.Value;

            string stringIdAviao = listaAvioesInput.SelectedItem.ToString();
            int index = stringIdAviao.IndexOf("-");
            int id_aviao = Convert.ToInt32(stringIdAviao.Substring(0, index - 1));

            if(localPartidaInput.SelectedItem == null || localDestinoInput.SelectedItem == null)
            {
                MessageBox.Show("Precisa selecionar um local de partida e destino");
                return;
            }
            else if(localPartidaInput.SelectedItem.ToString() == localDestinoInput.SelectedItem.ToString())
            {
                MessageBox.Show("O local de partida e destino não podem ser iguais");
                return;
            }

            DialogResult result = MessageBox.Show("A informação está toda correta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dbContext.InserirNovaReserva(id_aviao, nomeCliente, dataPartida, dataRetorno);
                dbContext.ChangePlaneStatus(id_aviao);
                this.Close();
            }

        }

        private void resetColors()
        {
            VooComercial_button.BackColor = Color.FromArgb(54, 53, 67);
            VooParticular_button.BackColor = Color.FromArgb(54, 53, 67);
            VooMercadoria_button.BackColor = Color.FromArgb(54, 53, 67);
            Avionetas_button.BackColor = Color.FromArgb(54, 53, 67);
        }

        private bool validations()
        {
            string nomeCliente = nomeClienteInput.Text;
            string origem = localPartidaInput.Text;
            string destino = localDestinoInput.Text;

            if (string.IsNullOrWhiteSpace(nomeCliente) || string.IsNullOrWhiteSpace(origem) || string.IsNullOrEmpty(destino))
            {
                // Handle empty or whitespace input for modelo and marca
                MessageBox.Show("Nome Cliente, Local de Origem e Local de Destino são campos obrigatórios.");
                return false; // Exit the method
            }

            DateTime dataPartida = startDateInput.Value;
            DateTime dataRetorno = endDateInput.Value;

            if (DateTime.Now.CompareTo(dataPartida) < 0 )
            {
                // Handle invalid year input
                MessageBox.Show("Data de Partida Inválida.");
                return false; // Exit the method
            }
            if (dataRetorno < dataPartida)
            {
                // Handle invalid year input
                MessageBox.Show("Data de Volta Inválida.");
                return false; // Exit the method
            }


            return true;
        }

        public void verificarDisponiveis(ComboBox listaAvioesInput)
        {
            if (listaAvioesInput.Items.Count == 0)
            {
                MessageBox.Show("Não existem aeronaves disponíveis para o tipo de voo selecionado.");
            }
        }

        private void startDateInput_ValueChanged(object sender, EventArgs e)
        {
            updateFrete();
        }

        private void endDateInput_ValueChanged(object sender, EventArgs e)
        {
            updateFrete();
        }

        private void updateFrete()
        {
            if (listaAvioesInput.SelectedItem == null)
            {
                return;
            }

            string stringIdAviao = listaAvioesInput.SelectedItem.ToString();
            int index = stringIdAviao.IndexOf("-");
            int id_aviao = Convert.ToInt32(stringIdAviao.Substring(0, index - 1));

            Aviao aviao = dbContext.GetAviaoById(id_aviao);

            try
            {
                if (aviao != null)
                {
                    DateTime startDate = startDateInput.Value;
                    DateTime endDate = endDateInput.Value;

                    TimeSpan difference = endDate - startDate;
                    int days = difference.Days + 1;

                    switch (aviao.Tipo)
                    {
                        case "Aeronave Comercial":
                            return;

                        case "Aeronave de Mercadorias":
                            AeronaveMercadorias aeronaveMercadorias = (AeronaveMercadorias)aviao;
                            dbContext.GetAeronavesComerciaisData(aeronaveMercadorias.id);
                            Valor_label.Text = (days * aeronaveMercadorias.valorFrete).ToString();
                            break;

                        case "Aeronave Particular":
                            AeronaveParticular aeronaveParticular = (AeronaveParticular)aviao;
                            dbContext.GetAeroNaveParticularData(aeronaveParticular.id);
                            Valor_label.Text = (days * aeronaveParticular.valorFrete).ToString();
                            break;

                        case "Avioneta":
                            Avioneta avioneta = (Avioneta)aviao;
                            dbContext.GetAvionetaData(avioneta.id);
                            Valor_label.Text = (days * avioneta.valorFrete).ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Precisa Selecionar um avião válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }


        private void listaAvioesInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFrete();
        }
    }
}
