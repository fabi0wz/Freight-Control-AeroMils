using AeroMils___Controlo_de_Frota.Data.DbContext;
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
        SQLiteDBContext dbContext = new SQLiteDBContext();
        // fields
        private string currentButton = "AeronaveComercial";

        public NovaReserva()
        {
            InitializeComponent();
            dbContext.getAvailablePlanes(listaAvioesInput, currentButton);
            valorFreteLabel.Hide();
            Valor_label.Hide();
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

            currentButton = "AeronaveMercadoria";
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

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
            string nomeCliente = nomeClienteInput.Text;
            string origem = localPartidaInput.Text;
            string destino = localDestinoInput.Text;
            DateTime dataPartida = startDateInput.Value;
            DateTime dataRetorno = endDateInput.Value;

            string stringIdAviao = listaAvioesInput.SelectedItem.ToString();
            int index = stringIdAviao.IndexOf("-");
            int id_aviao = Convert.ToInt32(stringIdAviao.Substring(0, index - 1));


            DialogResult result = MessageBox.Show("A informação está toda correta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dbContext.InserirNovaReserva(id_aviao, nomeCliente, origem, destino, dataPartida, dataRetorno);
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

            if (dataPartida < DateTime.Now)
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



    }
}
