using AeroMils___Controlo_de_Frota.Data.DbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class InserirAviao : Form
    {
        private string special2Type = "string";
        SQLiteDBContext dbContext = new SQLiteDBContext();


        public InserirAviao()
        {
            InitializeComponent();
            inserirTipoInput.SelectedIndex = 0;
        }



        private void inserirTipoInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = inserirTipoInput.SelectedItem.ToString();

            switch (selected)
            {
                case "Aeronave Comercial":
                    inserirSpecial1Label.Text = "Número de Voos Diários:";
                    inserirSpecial2Label.Text = "Companhia Aérea:";
                    special2Type = "string";
                    break;
                case "Aeronave de Mercadorias":
                    inserirSpecial1Label.Text = "Capacidade de Carga:";
                    inserirSpecial2Label.Text = "Valor do Frete:";
                    special2Type = "double";
                    break;
                case "Aeronave Particular":
                    inserirSpecial1Label.Text = "Número de Proprietários:";
                    inserirSpecial2Label.Text = "Valor do Frete:";
                    special2Type = "double";
                    break;
                case "Avioneta":
                    inserirSpecial1Label.Text = "Área mínima de descolagem:";
                    inserirSpecial2Label.Text = "Valor do Frete:";
                    special2Type = "double";
                    break;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            while (!validations())
            {
                return;
            }

            string modelo = inserirModeloInput.Text;
            string marca = inserirMarcaInput.Text;
            int capacidade = Convert.ToInt32(inserirCapacidadeInput.Text);
            int autonomia = Convert.ToInt32(inserirAutonomiaInput.Text);
            DateTime manutencao = inserirManutencaoInput.Value;
            if (inserirTipoInput.SelectedItem == null)
            {
                MessageBox.Show("Deve escolher um tipo válido");
                return;
            }
            string tipo = determinarTipo(inserirTipoInput.SelectedItem.ToString());
            DateTime ano = parseAnoFabrico();
            int quantidade = Convert.ToInt32(inserirQuantidadeInput.Text);

            DialogResult result = MessageBox.Show("A informação está toda correta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int idInserted = dbContext.InserirNovoAviao(modelo, marca, capacidade, autonomia, manutencao, tipo, ano, quantidade);

                if (idInserted > 0)
                {
                    // The plane insertion was successful
                    inserirSpecial(idInserted);
                    MessageBox.Show("Avião inserido com sucesso!");
                }
                else
                {
                    // Handle the case where the insertion failed
                    MessageBox.Show("Falha ao inserir o Avião.");
                }
            }

        }

        private string determinarTipo(string tipo)
        {
            return tipo switch
            {
                "Aeronave Comercial" => "AeronaveComercial",
                "Aeronave de Mercadorias" => "AeronaveMercadorias",
                "Aeronave Particular" => "AeronaveParticular",
                "Avioneta" => "Avioneta",
                _ => "Aeronave Comercial",
            };
        }

        private DateTime parseAnoFabrico()
        {
            string yearString = inserirAnoInput.Text; // Use the Text property to get user input

            if (int.TryParse(yearString, out int year))
            {
                DateTime selectedDate = new DateTime(year, 1, 1);

                if (selectedDate.Year < 1900 || selectedDate.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Ano de Fabrico Inválido");
                    return DateTime.MinValue; // Return an "invalid" date
                }
                return selectedDate;
            }
            else
            {
                // Handle the case where the input string is not a valid integer
                MessageBox.Show("Ano de Fabrico Inválido");
                return DateTime.MinValue; // Return an "invalid" date
            }
        }

        private bool validations()
        {
            string modelo = inserirModeloInput.Text;
            string marca = inserirMarcaInput.Text;

            if (string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(marca))
            {
                // Handle empty or whitespace input for modelo and marca
                MessageBox.Show("Modelo e Marca são campos obrigatórios.");
                return false; // Exit the method
            }

            int capacidade;
            if (!int.TryParse(inserirCapacidadeInput.Text, out capacidade) || capacidade <= 0)
            {
                // Handle invalid or non-positive integer input for capacidade
                MessageBox.Show("Capacidade deve ser um número inteiro positivo.");
                return false; // Exit the method
            }

            int autonomia;
            if (!int.TryParse(inserirAutonomiaInput.Text, out autonomia) || autonomia <= 0)
            {
                // Handle invalid or non-positive integer input for autonomia
                MessageBox.Show("Autonomia deve ser um número inteiro positivo.");
                return false; // Exit the method
            }

            int quantidade;
            if (!int.TryParse(inserirQuantidadeInput.Text, out quantidade) || quantidade <= 0)
            {
                // Handle invalid or non-positive integer input for quantidade
                MessageBox.Show("Quantidade de motores deve ser um número inteiro positivo.");
                return false; // Exit the method
            }

            int special1;
            if (!int.TryParse(inserirSpecial1Input.Text, out special1))
            {
                // Handle invalid integer input for special1
                MessageBox.Show($"{inserirSpecial1Label.Text} deve ser um número inteiro.");
                return false; // Exit the method
            }

            if (special2Type == "double")
            {
                double special2;
                if (!double.TryParse(inserirSpecial2Input.Text, out special2))
                {
                    // Handle invalid double input for special2
                    MessageBox.Show($"{inserirSpecial2Label.Text} deve ser um número decimal válido.");
                    return false; // Exit the method
                }
            }

            if (string.IsNullOrEmpty(inserirSpecial2Input.Text))
            {
                MessageBox.Show($"{inserirSpecial2Label.Text} é um campo obrigatório.");
                return false;
            }

            if (string.IsNullOrEmpty(inserirAnoInput.Text) || !int.TryParse(inserirAnoInput.Text, out int ano) || ano <= 1990)
            {
                // Handle empty, non-integer, or less than 1990 input for inserirAnoInput
                MessageBox.Show("O ano deve ser um número inteiro maior que 1990.");
                return false; // Exit the method
            }

            return true;
        }


        public bool inserirSpecial(int aviaoID)
        {
            string tipoAviao = inserirTipoInput.SelectedItem.ToString();
            switch (tipoAviao)
            {
                case "Aeronave Comercial":
                    dbContext.InserirNovaAeronaveComercial(aviaoID, Convert.ToInt32(inserirSpecial1Input.Text), inserirSpecial2Input.Text);
                    break;
                case "Aeronave de Mercadorias":
                    dbContext.InserirNovaAeronaveMercadorias(aviaoID, Convert.ToInt32(inserirSpecial1Input.Text), Convert.ToDouble(inserirSpecial2Input.Text));
                    break;
                case "Aeronave Particular":
                    dbContext.InserirNovaAeronaveParticular(aviaoID, Convert.ToInt32(inserirSpecial1Input.Text), Convert.ToDouble(inserirSpecial2Input.Text));
                    break;
                case "Avioneta":
                    dbContext.InserirNovaAvioneta(aviaoID, Convert.ToInt32(inserirSpecial1Input.Text), Convert.ToDouble(inserirSpecial2Input.Text));
                    break;
            }
            return false;
        }


    }
}
