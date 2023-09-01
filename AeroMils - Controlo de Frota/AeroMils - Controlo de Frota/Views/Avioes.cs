using AeroMils___Controlo_de_Frota.Data.DbContext;
using AeroMils___Controlo_de_Frota.Models;
using AeroMils___Controlo_de_Frota.Modules;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class Avioes : Form
    {
        private SQLiteDBContext dbContext = new SQLiteDBContext();
        private int currentPage = 0;
        private int recordsPerPage = 9;
        private Empresa empresa;
        private List<Aviao> listaAvioes;

        public Avioes()
        {
            InitializeComponent();
            retrieveData();
            InitializeButtons();
        }

        private void retrieveData()
        {
            empresa = dbContext.GetAvioesData();
            listaAvioes = empresa.GetAvioes();
            
            DisplayRecords();
        }

        private void InitializeButtons()
        {
            avioesNextButton.Enabled = listaAvioes.Count > recordsPerPage;
            avioesPreviousButton.Enabled = false; // Initially, the "Previous" button is disabled
        }

        private void DisplayRecords()
        {
            clearTable();

            // Calculate the starting and ending index for the current page
            int startIndex = currentPage * recordsPerPage;
            int endIndex = Math.Min(startIndex + recordsPerPage, listaAvioes.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                int rowNumber = i - startIndex + 1;

                // Generate the Label names dynamically based on the row number
                string idLabelName = $"aviaoLinha{rowNumber}ID";
                string modeloLabelName = $"aviaoLinha{rowNumber}Modelo";
                string estadoLabelName = $"aviaoLinha{rowNumber}Estado";
                string tipoLabelName = $"aviaoLinha{rowNumber}Tipo";
                string dataManutencaoLabelName = $"aviaoLinha{rowNumber}DataManutencao";

                Label idLabel = FindLabelByName(idLabelName);
                Label modeloLabel = FindLabelByName(modeloLabelName);
                Label estadoLabel = FindLabelByName(estadoLabelName);
                Label tipoLabel = FindLabelByName(tipoLabelName);
                Label dataManutencaoLabel = FindLabelByName(dataManutencaoLabelName);

                Aviao aviao = listaAvioes[i];
                idLabel.Text = aviao.id.ToString();
                modeloLabel.Text = aviao.modelo.ToString();
                estadoLabel.Text = aviao.estado == false ? "No Hangar" : "Em Viagem";
                tipoLabel.Text = aviao.Tipo;
                dataManutencaoLabel.Text = aviao.dataUltimaManutencao.ToString();
            }

            // Enable or disable the "Next" and "Previous" buttons based on the index bounds
            avioesNextButton.Enabled = endIndex < listaAvioes.Count;
            avioesPreviousButton.Enabled = currentPage > 0;
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

        private void clearTable()
        {
            for (int rowNumber = 1; rowNumber <= recordsPerPage; rowNumber++)
            {
                string idLabelName = $"aviaoLinha{rowNumber}ID";
                string modeloLabelName = $"aviaoLinha{rowNumber}Modelo";
                string estadoLabelName = $"aviaoLinha{rowNumber}Estado";
                string tipoLabelName = $"aviaoLinha{rowNumber}Tipo";
                string dataManutencaoLabelName = $"aviaoLinha{rowNumber}DataManutencao";

                Label idLabel = FindLabelByName(idLabelName);
                Label modeloLabel = FindLabelByName(modeloLabelName);
                Label estadoLabel = FindLabelByName(estadoLabelName);
                Label tipoLabel = FindLabelByName(tipoLabelName);
                Label dataManutencaoLabel = FindLabelByName(dataManutencaoLabelName);

                idLabel.Text = "";
                modeloLabel.Text = "";
                estadoLabel.Text = "";
                tipoLabel.Text = "";
                dataManutencaoLabel.Text = "";
            }
        }

        private void avioesNextButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            DisplayRecords();
        }

        private void avioesPreviousButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            DisplayRecords();
        }
    }
}
