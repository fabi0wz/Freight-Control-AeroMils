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
    public partial class HistoricoManutencoes : Form
    {
        //starts the database connection, the current page and the records per page, and the list of manutencoes
        private SQLiteDBContext dbContext = new SQLiteDBContext();
        private int currentPage = 0;
        private int recordsPerPage = 7;
        private Empresa empresa;
        private List<Manutencoes> listaManutencoes;

        public HistoricoManutencoes()
        {
            //initializes the components, retrieves the data, initializes the buttons and displays the records
            InitializeComponent();
            retrieveData();
        }

        private void retrieveData()
        {
            empresa = dbContext.GetManutencoesData();
            listaManutencoes = empresa.GetManutencoes();

            removeActive();
            DisplayRecords();
        }

        private void removeActive()
        {
            // if data_fim > data atual, remove from list
            DateTime dataAtual = DateTime.Now;
            listaManutencoes.RemoveAll(listaManutencoes => DateTime.Parse(listaManutencoes.data_fim) > dataAtual);
        }

        private void DisplayRecords()
        {
            clearTable();

            // Calculate the starting and ending index for the current page
            int startIndex = currentPage * recordsPerPage;
            int endIndex = Math.Min(startIndex + recordsPerPage, listaManutencoes.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                int rowNumber = i - startIndex + 1;


                // Generate the Label names dynamically based on the row number
                string idManutencaoLabelName = $"histManutLinha{rowNumber}IDmanut";
                string idAviaoLabelName = $"histManutLinha{rowNumber}ID";
                string dataInicioLabelName = $"histManutLinha{rowNumber}DataInicio";
                string dataFimLabelName = $"histManutLinha{rowNumber}DataFim";

                Label idManutencaoLabel = FindLabelByName(idManutencaoLabelName);
                Label idAviaoLabel = FindLabelByName(idAviaoLabelName);
                Label dataInicioLabel = FindLabelByName(dataInicioLabelName);
                Label dataFimLabel = FindLabelByName(dataFimLabelName);

                Manutencoes manutencoes = listaManutencoes[i];
                idManutencaoLabel.Text = manutencoes.id_manutencao.ToString();
                idAviaoLabel.Text = manutencoes.id_aviao.ToString();
                dataInicioLabel.Text = manutencoes.data_inicio;
                dataFimLabel.Text = manutencoes.data_fim;
            }

            // Enable or disable the "Next" and "Previous" buttons based on the index bounds
            histManutNextButton.Enabled = endIndex < listaManutencoes.Count;
            histManutPreviousButton.Enabled = currentPage > 0;
        }

        private void clearTable()
        {
            for (int rowNumber = 1; rowNumber <= recordsPerPage; rowNumber++)
            {
                string idManutencaoLabelName = $"histManutLinha{rowNumber}IDManut";
                string idAviaoLabelName = $"histManutLinha{rowNumber}ID";
                string dataInicioLabelName = $"histManutLinha{rowNumber}DataInicio";
                string dataFimLabelName = $"histManutLinha{rowNumber}DataFim";

                Label idManutencaoLabel = FindLabelByName(idManutencaoLabelName);
                Label idAviaoLabel = FindLabelByName(idAviaoLabelName);
                Label dataInicioLabel = FindLabelByName(dataInicioLabelName);
                Label dataFimLabel = FindLabelByName(dataFimLabelName);

                idManutencaoLabel.Text = "";
                idAviaoLabel.Text = "";
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

        private void histManutPreviousButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            DisplayRecords();
        }

        private void histManutNextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            DisplayRecords();
        }
    }
}
