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
        private int recordsPerPage = 7;
        private Empresa empresa;
        private List<Aviao> listaAvioes;
        private bool isfiltered = false;

        public Avioes()
        {
            InitializeComponent();
            retrieveData();
            InitializeButtons();
            DisplayRecords();
        }



        private void retrieveData()
        {
            empresa = dbContext.GetAvioesData();
            listaAvioes = empresa.GetAvioes();

        }

        private void InitializeButtons()
        {
            avioesNextButton.Enabled = listaAvioes.Count > recordsPerPage;
            avioesPreviousButton.Enabled = false; // Initially, the "Previous" button is disabled
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
                modeloLabel.Text = aviao.marca.ToString();
                estadoLabel.Text = aviao.estado == false ? "No Hangar" : "Em Viagem";
                tipoLabel.Text = aviao.Tipo;
                dataManutencaoLabel.Text = aviao.dataUltimaManutencao.ToString();
            }

            // Enable or disable the "Next" and "Previous" buttons based on the index bounds
            avioesNextButton.Enabled = endIndex < listaAvioes.Count;
            avioesPreviousButton.Enabled = currentPage > 0;
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

        ///////////////////////////  BUTTONS  ///////////////////////////

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


        ///////////////////////////  MOUSE HOVER  ///////////////////////////

        private void aviaoLine1_MouseHover(object sender, EventArgs e)
        {
            aviaoLine1.Cursor = Cursors.Hand;
            aviaoLine1.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine1_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine1.Cursor = Cursors.Default;
            aviaoLine1.BackColor = Control.DefaultBackColor;
        }

        private void aviaoLine2_MouseHover(object sender, EventArgs e)
        {
            aviaoLine2.Cursor = Cursors.Hand;
            aviaoLine2.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine2_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine2.Cursor = Cursors.Default;
            aviaoLine2.BackColor = Control.DefaultBackColor;
        }

        private void aviaoLine3_MouseHover(object sender, EventArgs e)
        {
            aviaoLine3.Cursor = Cursors.Hand;
            aviaoLine3.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine3_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine3.Cursor = Cursors.Default;
            aviaoLine3.BackColor = Control.DefaultBackColor;
        }

        private void aviaoLine4_MouseHover(object sender, EventArgs e)
        {
            aviaoLine4.Cursor = Cursors.Hand;
            aviaoLine4.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine4_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine4.Cursor = Cursors.Default;
            aviaoLine4.BackColor = Control.DefaultBackColor;
        }

        private void aviaoLine5_MouseHover(object sender, EventArgs e)
        {
            aviaoLine5.Cursor = Cursors.Hand;
            aviaoLine5.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine5_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine5.Cursor = Cursors.Default;
            aviaoLine5.BackColor = Control.DefaultBackColor;
        }

        private void aviaoLine6_MouseHover(object sender, EventArgs e)
        {
            aviaoLine6.Cursor = Cursors.Hand;
            aviaoLine6.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine6_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine6.Cursor = Cursors.Default;
            aviaoLine6.BackColor = Control.DefaultBackColor;
        }

        private void aviaoLine7_MouseHover(object sender, EventArgs e)
        {
            aviaoLine7.Cursor = Cursors.Hand;
            aviaoLine7.BackColor = Color.FromArgb(255, 127, 84);
        }

        private void aviaoLine7_MouseLeave(object sender, EventArgs e)
        {
            aviaoLine7.Cursor = Cursors.Default;
            aviaoLine7.BackColor = Control.DefaultBackColor;
        }

        ///////////////////////////  MOUSE DOUBLE CLICK  ///////////////////////////

        private void aviaoLine1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha1ID.Text == "" ? 0 : int.Parse(aviaoLinha1ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        private void aviaoLine2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha2ID.Text == "" ? 0 : int.Parse(aviaoLinha2ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        private void aviaoLine3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha3ID.Text == "" ? 0 : int.Parse(aviaoLinha3ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        private void aviaoLine4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha4ID.Text == "" ? 0 : int.Parse(aviaoLinha4ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        private void aviaoLine5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha5ID.Text == "" ? 0 : int.Parse(aviaoLinha5ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        private void aviaoLine6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha6ID.Text == "" ? 0 : int.Parse(aviaoLinha6ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        private void aviaoLine7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = aviaoLinha7ID.Text == "" ? 0 : int.Parse(aviaoLinha7ID.Text);
            Aviao aviao = dbContext.GetAviaoById(id);

            Views.DetalhesAviao detalhesAviao = new Views.DetalhesAviao(aviao);
            detalhesAviao.Show();
        }

        ///////////////////////////  ESTADO CHANGE   ///////////////////////////

        private void aviaoLinha1EstadoChange_Click(object sender, EventArgs e)
        {

            int id = aviaoLinha1ID.Text == "" ? 0 : int.Parse(aviaoLinha1ID.Text);

            if (aviaoLinha1Estado.Text == "Em Viagem")
            {
                aviaoLinha1Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha1Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void aviaoLinha2EstadoChange_Click(object sender, EventArgs e)
        {
            int id = aviaoLinha2ID.Text == "" ? 0 : int.Parse(aviaoLinha2ID.Text);

            if (aviaoLinha2Estado.Text == "Em Viagem")
            {
                aviaoLinha2Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha2Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void aviaoLinha3EstadoChange_Click(object sender, EventArgs e)
        {
            int id = aviaoLinha3ID.Text == "" ? 0 : int.Parse(aviaoLinha3ID.Text);

            if (aviaoLinha3Estado.Text == "Em Viagem")
            {
                aviaoLinha3Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha3Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void aviaoLinha4EstadoChange_Click(object sender, EventArgs e)
        {
            int id = aviaoLinha4ID.Text == "" ? 0 : int.Parse(aviaoLinha4ID.Text);

            if (aviaoLinha4Estado.Text == "Em Viagem")
            {
                aviaoLinha4Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha4Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void aviaoLinha5EstadoChange_Click(object sender, EventArgs e)
        {
            int id = aviaoLinha5ID.Text == "" ? 0 : int.Parse(aviaoLinha5ID.Text);

            if (aviaoLinha5Estado.Text == "Em Viagem")
            {
                aviaoLinha5Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha5Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void aviaoLinha6EstadoChange_Click(object sender, EventArgs e)
        {
            int id = aviaoLinha6ID.Text == "" ? 0 : int.Parse(aviaoLinha6ID.Text);

            if (aviaoLinha6Estado.Text == "Em Viagem")
            {
                aviaoLinha6Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha6Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void aviaoLinha7EstadoChange_Click(object sender, EventArgs e)
        {
            int id = aviaoLinha7ID.Text == "" ? 0 : int.Parse(aviaoLinha7ID.Text);

            if (aviaoLinha7Estado.Text == "Em Viagem")
            {
                aviaoLinha7Estado.Text = "No Hangar";
            }
            else
            {
                aviaoLinha7Estado.Text = "Em Viagem";
            }

            dbContext.ChangePlaneStatus(id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterComboBox1();
        }

        private void filterComboBox1()
        {
            retrieveData();

            isfiltered = true;

            if (comboBox1.Text == "Todos")
            {
                isfiltered = false;
                retrieveData();
            }

            if (comboBox1.Text == "Em viagem")
            {
                listaAvioes.RemoveAll(aviao => aviao.estado == false);
            }
            if (comboBox1.Text == "No hangar")
            {
                listaAvioes.RemoveAll(aviao => aviao.estado == true);
            }

            if (listaAvioes.Any())
            {
                DisplayRecords();
            }
            else
            {
                MessageBox.Show("Não existem registos com esse filtro");
                retrieveData();
                filterComboBox2();
                return;
            }

            if (isfiltered)
            {
                filterComboBox2();
            }

            DisplayRecords();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            filterComboBox2();
        }

        private void filterComboBox2()
        {
            retrieveData();

            isfiltered = true;

            if (comboBox2.Text == "Todos")
            {
                isfiltered = false;
                retrieveData();
            }

            if (comboBox2.Text == "Comercial")
            {
                listaAvioes.RemoveAll(aviao => aviao.Tipo != "Aeronave Comercial");
            }
            if (comboBox2.Text == "Particular")
            {
                listaAvioes.RemoveAll(aviao => aviao.Tipo != "Aeronave Particular");
            }
            if (comboBox2.Text == "Mercadoria")
            {
                listaAvioes.RemoveAll(aviao => aviao.Tipo != "Aeronave de Mercadorias");
            }
            if (comboBox2.Text == "Avioneta")
            {
                listaAvioes.RemoveAll(aviao => aviao.Tipo != "Avioneta");
            }

            if (listaAvioes.Any())
            {
                DisplayRecords();
            }
            else
            {
                MessageBox.Show("Não existem registos com esse filtro");
                retrieveData();
                filterComboBox1();

                return;
            }

            if (isfiltered)
            {
                filterComboBox1();
            }

            DisplayRecords();
        }
    }
}
