
using AeroMils___Controlo_de_Frota.Data.DbContext;
using AeroMils___Controlo_de_Frota.Models;
using AeroMils___Controlo_de_Frota.Modules;
using System.Data;
using System.Text;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class Form1 : Form
    {
        // fields
        private Button currentButton = null!;
        private Form activeForm = null!;
        bool avioesCollapsed = true;
        bool reservasCollapsed = true;
        bool manutencaoCollapsed = true;
        private SQLiteDBContext dbContext = new SQLiteDBContext();

        Login login;


        public Form1(Login login)
        {
            InitializeComponent();
            //tempDB.CreateDefaults();

            //open dashboard form by default
            OpenChildForm(new Views.Dashboard(), button_dashboard);
            this.Text = "AeroMils - Controlo de Frota";

            this.login = login;
        }

        // methods
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 98, 45);
            }
        }

        private void DisableButton()
        {
            foreach (Control panel in panel_sidebar.Controls)
            {
                if (panel.GetType() == typeof(Panel))
                {
                    foreach (Control btn in panel.Controls)
                    {
                        if (btn.GetType() == typeof(Button))
                        {
                            btn.BackColor = Color.FromArgb(54, 53, 67);
                        }
                    }
                }
            }
        }

        // open the child form in the main panel and close the previous one if it exists
        private void OpenChildForm(Form childForm, object senderBtn)
        {
            // close the previous form if it exists
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // activate the button that was clicked
            ActivateButton(senderBtn);

            // open the new form in the main panel and set it as the active form 
            activeForm = childForm;
            // set the form as a child of the panel so it can be displayed inside it 
            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //close the expanded panels when the user clicks on another panel
        private void CloseExpanded()
        {
            if (!avioesCollapsed)
            {
                AvioesTimer.Start();
            }
            if (!reservasCollapsed)
            {
                ReservasTimer.Start();
            }
            if (!manutencaoCollapsed)
            {
                ManutencaoTimer.Start();
            }
        }


        // event handlers
        // the buttons on the sidebar are used to open the forms
        private void button_dashboard_Click(object sender, EventArgs e)
        {
            //open dashboard form and pass the button that was clicked as a parameter to the method OpenChildForm
            OpenChildForm(new Views.Dashboard(), sender);

            // close the expanded panels
            CloseExpanded();
        }

        private void button_avioes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Avioes(), sender);

            // start the timer to animate the panel
            AvioesTimer.Start();

            CloseExpanded();
        }

        private void button_reservas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Reservas(), sender);

            ReservasTimer.Start();

            CloseExpanded();
        }

        private void button_manutencao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Manutencao(), sender);

            ManutencaoTimer.Start();

            CloseExpanded();
        }

        private void button_sobre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Sobre(), sender);

            CloseExpanded();
        }

        private void button_InserirAviao_Click(object sender, EventArgs e)
        {
            Views.InserirAviao inserirAviao = new Views.InserirAviao();
            inserirAviao.Show();
        }


        //open a new form in a separate window
        private void button_NovaReserva_Click(object sender, EventArgs e)
        {
            Views.NovaReserva novaReserva = new Views.NovaReserva();
            novaReserva.Show();
        }

        private void button_HistoricoReserva_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.HistoricoReservas(), sender);
        }

        private void button_HistoricoManutencao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.HistoricoManutencoes(), sender);
        }

        // the timers are used to animate the panels 
        private void AvioesTimer_Tick(object sender, EventArgs e)
        {
            // if the panel is collapsed, expand it
            if (avioesCollapsed)
            {
                // expand the panel by 10px
                AvioesContainer.Height += 10;

                // if the panel is fully expanded, stop the timer
                if (AvioesContainer.Height == AvioesContainer.MaximumSize.Height)
                {
                    avioesCollapsed = false;
                    AvioesTimer.Stop();
                }

            }
            // if the panel is expanded, collapse it
            else
            {
                // collapse the panel by 10px
                AvioesContainer.Height -= 10;

                // if the panel is fully collapsed, stop the timer
                if (AvioesContainer.Height == AvioesContainer.MinimumSize.Height)
                {
                    avioesCollapsed = true;
                    AvioesTimer.Stop();
                }
            }
        }

        private void ReservasTimer_Tick(object sender, EventArgs e)
        {
            if (reservasCollapsed)
            {
                ReservasContainer.Height += 10;

                if (ReservasContainer.Height == ReservasContainer.MaximumSize.Height)
                {
                    reservasCollapsed = false;
                    ReservasTimer.Stop();
                }

            }
            else
            {
                ReservasContainer.Height -= 10;

                if (ReservasContainer.Height == ReservasContainer.MinimumSize.Height)
                {
                    reservasCollapsed = true;
                    ReservasTimer.Stop();
                }
            }
        }

        private void ManutencaoTimer_Tick(object sender, EventArgs e)
        {
            if (manutencaoCollapsed)
            {
                ManutencaoContainer.Height += 10;

                if (ManutencaoContainer.Height == ManutencaoContainer.MaximumSize.Height)
                {
                    manutencaoCollapsed = false;
                    ManutencaoTimer.Stop();
                }
            }
            else
            {
                ManutencaoContainer.Height -= 10;

                if (ManutencaoContainer.Height == ManutencaoContainer.MinimumSize.Height)
                {
                    manutencaoCollapsed = true;
                    ManutencaoTimer.Stop();
                }
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }


        private void ExportCSV_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Set the initial folder to the desktop.
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected folder path.
                    string selectedFolder = folderDialog.SelectedPath;

                    try
                    {

                        // Saves the Planes Data
                        Empresa empresaavioes = dbContext.GetAvioesData();
                        List<Aviao> avioes = empresaavioes.GetAvioes();

                        Empresa empresareservas = dbContext.GetReservasData();
                        List<Reserva> listaReservas = empresareservas.GetReservas();

                        Empresa empresamanutencoes = dbContext.GetManutencoesData();
                        List<Manutencoes> listaManutencoes = empresamanutencoes.GetManutencoes();

                        // Define the string you want to save to the CSV file.
                        string dataAvioes = PlanesData(avioes);
                        string dataReservas = ReservationsData(listaReservas);
                        string dataManutencoes = ManutencoesData(listaManutencoes);
                        string dataToSave = dataAvioes + Environment.NewLine + dataReservas + Environment.NewLine + dataManutencoes;


                        // Define the path for the CSV file.
                        string csvFilePath = Path.Combine(selectedFolder, "Dados_Exportados.csv");

                        // Write the string to the CSV file.
                        File.WriteAllText(csvFilePath, dataToSave);

                        MessageBox.Show("Data has been saved to: " + csvFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string PlanesData(List<Aviao> avioes)
        {
            StringBuilder csvData = new StringBuilder();

            // Header row
            csvData.AppendLine("Avioes:");
            csvData.AppendLine("id | capacidade | autonomia | data_ultima_manutencao | estado | quantidade_motores | marca | modelo | ano_fabrico | tipo | AdditionalAttribute1 | AdditionalAttribute2");

            // Data rows
            foreach (Aviao aviao in avioes)
            {
                // Create a line for each aviao
                string aviaoLine = $"{aviao.id} | {aviao.capacidade_passageiros} | {aviao.autonomia} | {aviao.dataUltimaManutencao} | {aviao.estado} | {aviao.qtdMotores} | {aviao.marca} | {aviao.modelo} | {aviao.anoFabrico}| {aviao.Tipo}";

                // Depending on the type, add additional attributes
                switch (aviao.Tipo)
                {
                    case "AeronaveComercial":
                        AeronaveComercial comercialAviao = aviao as AeronaveComercial;
                        if (comercialAviao != null)
                        {
                            aviaoLine += $",{comercialAviao.numeroVoosDia},{comercialAviao.companhiaAerea}";
                        }
                        break;
                    case "AeronaveParticular":
                        AeronaveParticular particularAviao = aviao as AeronaveParticular;
                        if (particularAviao != null)
                        {
                            aviaoLine += $",{particularAviao.numProprietarios},{particularAviao.valorFrete}";
                        }
                        break;
                    case "AeronaveMercadorias":
                        AeronaveMercadorias mercadoriasAviao = aviao as AeronaveMercadorias;
                        if (mercadoriasAviao != null)
                        {
                            aviaoLine += $",{mercadoriasAviao.capacidadeCarga},{mercadoriasAviao.valorFrete}";
                        }
                        break;
                    case "Avioneta":
                        Avioneta avioneta = aviao as Avioneta;
                        if (avioneta != null)
                        {
                            aviaoLine += $",{avioneta.areaDescolagem},{avioneta.valorFrete}";
                        }
                        break;
                }


                csvData.AppendLine(aviaoLine);
            }

            return csvData.ToString();
        }

        private string ReservationsData(List<Reserva> reservas)
        {
            StringBuilder csvData = new StringBuilder();

            // Header row
            csvData.AppendLine("Reservas:");
            csvData.AppendLine("ID Reserva | ID Aviaao | Nome do Cliente | Data de Inicio | Data de Fim");

            // Data rows
            foreach (Reserva reserva in reservas)
            {
                // Create a line for each reserva
                string reservaLine = $"{reserva.id_reserva} | {reserva.id_aviao} | {reserva.nome_cliente} | {reserva.data_inicio} | {reserva.data_fim}";

                csvData.AppendLine(reservaLine);
            }

            return csvData.ToString();
        }

        private string ManutencoesData(List<Manutencoes> manutencoes)
        {
            StringBuilder csvData = new StringBuilder();

            // Header row
            csvData.AppendLine("Manutencoes:");
            csvData.AppendLine("ID Manutencao | ID Aviaao | Data de Inicio | Data de Fim");

            // Data rows
            foreach (Manutencoes manutencao in manutencoes)
            {
                // Create a line for each reserva
                string manutencaoLine = $"{manutencao.id_manutencao} | {manutencao.id_aviao} | {manutencao.data_inicio} | {manutencao.data_inicio}";

                csvData.AppendLine(manutencaoLine);
            }

            return csvData.ToString();
        }
    }
}