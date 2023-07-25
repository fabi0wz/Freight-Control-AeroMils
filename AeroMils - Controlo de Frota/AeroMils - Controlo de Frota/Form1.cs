using AeroMils___Controlo_de_Frota.Model;

namespace AeroMils___Controlo_de_Frota
{
    public partial class Form1 : Form
    {
        // fields
        private Button currentButton = null!;
        private Form activeForm = null!;


        public Form1()
        {
            InitializeComponent();
            //tempDB.CreateDefaults();

            //open dashboard form by default
            OpenChildForm(new Forms.Dashboard(), button_dashboard);
            this.Text = "AeroMils - Controlo de Frota";

            pictureBox1.Parent = button_dashboard;
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
            foreach (Control previousBtn in panel_sidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(54, 53, 67);
                    previousBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object senderBtn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(senderBtn);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // event handlers
        private void button_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard(), sender);
        }

        private void button_avioes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Avioes(), sender);
        }

        private void button_reservas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reservas(), sender);
        }

        private void button_reservas_MouseHover(object sender, EventArgs e)
        {

        }

        private void button_manutencao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Manutencao(), sender);
        }

        private void button_alertas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Alertas(), sender);
        }

        private void button_sobre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Sobre(), sender);
        }
    }
}