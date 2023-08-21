
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


        public Form1()
        {
            InitializeComponent();
            //tempDB.CreateDefaults();

            //open dashboard form by default
            OpenChildForm(new Views.Dashboard(), button_dashboard);
            this.Text = "AeroMils - Controlo de Frota";
        }

        // methods
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 98, 45);
                currentButton.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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
                            btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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

        private void button_alertas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Alertas(), sender);

            CloseExpanded();
        }

        private void button_sobre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Sobre(), sender);

            CloseExpanded();
        }

        private void button_InserirAviao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.InserirAviao(), sender);
        }

        private void button_NovaReserva_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.NovaReserva(), sender);
        }

        private void button_HistoricoReserva_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.HistoricoReservas(), sender);
        }

        private void button_NovaManutencao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.NovaManutencao(), sender);
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


    }
}