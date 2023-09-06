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
    public partial class Manutencao : Form
    {
        private SQLiteDBContext dbContext = new SQLiteDBContext();
        private int currentPage = 0;
        private int recordsPerPage = 9;
        private Empresa empresa;
        private List<Manutencoes> listaManutencoes;

        public Manutencao()
        {
            InitializeComponent();
            retrieveData();
        }

        private void retrieveData()
        {
            empresa = dbContext.GetManutencoesData();
            listaManutencoes = empresa.GetManutencoes();

            DisplayRecords();
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
                string idManutencaoLabelName = $"manutencaoLinha{rowNumber}IDManutencao";
                string idAviaoLabelName = $"manutencaoLinha{rowNumber}IDAviao";
                string dataInicioLabelName = $"manutencaoLinha{rowNumber}DataInicio";
                string dataFimLabelName = $"manutencaoLinha{rowNumber}DataFim";

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
            manutencaoNextButton.Enabled = endIndex < listaManutencoes.Count;
            manutencaoPreviousButton.Enabled = currentPage > 0;
        }

        private void clearTable()
        {
            for (int rowNumber = 1; rowNumber <= recordsPerPage; rowNumber++)
            {
                string idManutencaoLabelName = $"manutencaoLinha{rowNumber}IDManutencao";
                string idAviaoLabelName = $"manutencaoLinha{rowNumber}IDAviao";
                string dataInicioLabelName = $"manutencaoLinha{rowNumber}DataInicio";
                string dataFimLabelName = $"manutencaoLinha{rowNumber}DataFim";

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

        private void manutencaoPreviousButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            DisplayRecords();
        }

        private void manutencaoNextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            DisplayRecords();
        }
    }
}
