using AeroMils___Controlo_de_Frota.Data.DbContext;
using AeroMils___Controlo_de_Frota.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class HistoricoReservas : Form
    {
        private SQLiteDBContext dbContext = new SQLiteDBContext();
        private int currentPage = 0;
        private int recordsPerPage = 7;
        private Empresa empresa;
        private List<Reserva> listaReservas;

        public HistoricoReservas()
        {
            InitializeComponent();
            retrieveData();
        }

        private void retrieveData()
        {
            empresa = dbContext.GetReservasData();
            listaReservas = empresa.GetReservas();

            removeActive();
            DisplayRecords();
        }

        private void removeActive()
        {
            for (int j = 0; j < listaReservas.Count; j++)
            {
                if (listaReservas[j].data_fim.CompareTo(DateTime.Now.ToString("dd/MM/yyyy")) > 0)
                {
                    listaReservas.RemoveAt(j);
                }
            }
        }

        private void DisplayRecords()
        {
            clearTable();

            // Calculate the starting and ending index for the current page
            int startIndex = currentPage * recordsPerPage;
            int endIndex = Math.Min(startIndex + recordsPerPage, listaReservas.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                int rowNumber = i - startIndex + 1;

                // Generate the Label names dynamically based on the row number

                string idReservaLabelName = $"histReservasLinha{rowNumber}IDreserva";
                string idAviaoLabelName = $"histReservasLinha{rowNumber}ID";
                string nomeClienteLabelName = $"histReservasLinha{rowNumber}NomeCliente";
                string dataInicioLabelName = $"histReservasLinha{rowNumber}DataInicio";
                string dataFimLabelName = $"histReservasLinha{rowNumber}DataFim";

                Label idReservaLabel = FindLabelByName(idReservaLabelName);
                Label idAviaoLabel = FindLabelByName(idAviaoLabelName);
                Label nomeClienteLabel = FindLabelByName(nomeClienteLabelName);
                Label dataInicioLabel = FindLabelByName(dataInicioLabelName);
                Label dataFimLabel = FindLabelByName(dataFimLabelName);

                Reserva reservas = listaReservas[i];
                idReservaLabel.Text = reservas.id_reserva.ToString();
                idAviaoLabel.Text = reservas.id_aviao.ToString();
                nomeClienteLabel.Text = reservas.nome_cliente.ToString();
                dataInicioLabel.Text = reservas.data_inicio;
                dataFimLabel.Text = reservas.data_fim;
            }

            // Enable or disable the "Next" and "Previous" buttons based on the index bounds
            histReservasNextButton.Enabled = endIndex < listaReservas.Count;
            histReservasPreviousButton.Enabled = currentPage > 0;
        }

        private void clearTable()
        {
            for (int rowNumber = 1; rowNumber <= recordsPerPage; rowNumber++)
            {
                string idReservaLabelName = $"histReservasLinha{rowNumber}IDreserva";
                string idAviaoLabelName = $"histReservasLinha{rowNumber}ID";
                string nomeClienteLabelName = $"histReservasLinha{rowNumber}NomeCliente";
                string dataInicioLabelName = $"histReservasLinha{rowNumber}DataInicio";
                string dataFimLabelName = $"histReservasLinha{rowNumber}DataFim";

                Label idReservaLabel = FindLabelByName(idReservaLabelName);
                Label idAviaoLabel = FindLabelByName(idAviaoLabelName);
                Label nomeClienteLabel = FindLabelByName(nomeClienteLabelName);
                Label dataInicioLabel = FindLabelByName(dataInicioLabelName);
                Label dataFimLabel = FindLabelByName(dataFimLabelName);

                idReservaLabel.Text = "";
                idAviaoLabel.Text = "";
                nomeClienteLabel.Text = "";
                dataInicioLabel.Text = "";
                dataFimLabel.Text = "";
            }
        }


        private Label FindLabelByName(string labelName)
        {
            Control[] controls = this.Controls.Find(labelName, true);

            if (controls.Length > 0 && controls[0] is Label label)
            {
                return label;
            }

            throw new InvalidOperationException($"Label control with name '{labelName}' not found.");
        }

        private void histReservasPreviousButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            DisplayRecords();
        }

        private void histReservasNextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            DisplayRecords();
        }
    }
}

