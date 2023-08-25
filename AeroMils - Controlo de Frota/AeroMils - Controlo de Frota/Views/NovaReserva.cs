using AeroMils___Controlo_de_Frota.Data.DbContext;
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
        // fields
        private Button currentButton = null!;
        private SQLiteDBContext dbContext = new SQLiteDBContext();


        public NovaReserva()
        {
            InitializeComponent();

            ComercialDetails_panel.Visible = true;
            IdaVolta_panel.Visible = true;
            Comercial_SoIda_panel.Visible = false;
            ParticularDetails_panel.Visible = false;
            MercadoriaDetails_panel.Visible = false;

            PopulateDropDown();

            //dataGridViewAvioesDisponiveis
        }

        private void PopulateDropDown()
        {
            DataTable avioesDisponiveisDataTable = dbContext.getAvailablePlanes();
            if(avioesDisponiveisDataTable.Rows.Count > 0)
            {
                avioesDisponiveisComboBox.DisplayMember = "modelo";
                avioesDisponiveisComboBox.ValueMember = "id_aviao";
                avioesDisponiveisComboBox.DataSource = avioesDisponiveisDataTable;
            }
            else
            {
                MessageBox.Show("Não existem aviões disponíveis");
            }
        }

        // methods
        private void ActivateBigButtons(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableBigButtons();
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 98, 45);
            }
        }
        private void ActivateSmallButtons(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableSmallButtons();
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 98, 45);
            }
        }

        private void DisableBigButtons()
        {
            foreach (Control btn in VoosPanel.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(54, 53, 67);
                }
            }
        }
        private void DisableSmallButtons()
        {
            foreach (Control panel in VoosPanel.Controls)
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

        //opens a panel and closes child panels if they are open 

        private void VooComercial_Click(object sender, EventArgs e)
        {
            ActivateBigButtons(sender);

            ComercialDetails_panel.Visible = true;
            ParticularDetails_panel.Visible = false;
            MercadoriaDetails_panel.Visible = false;

        }

        private void VooParticular_Click(object sender, EventArgs e)
        {
            ActivateBigButtons(sender);

            ComercialDetails_panel.Visible = false;
            ParticularDetails_panel.Visible = true;
            MercadoriaDetails_panel.Visible = false;

        }

        private void VooMercadoria_Click(object sender, EventArgs e)
        {
            ActivateBigButtons(sender);

            ComercialDetails_panel.Visible = false;
            ParticularDetails_panel.Visible = false;
            MercadoriaDetails_panel.Visible = true;

        }

        private void Avionetas_Click(object sender, EventArgs e)
        {
            ActivateBigButtons(sender);

            ComercialDetails_panel.Visible = false;
            ParticularDetails_panel.Visible = false;
            MercadoriaDetails_panel.Visible = false;

        }


        private void Comercial_IdaVolta_button_Click(object sender, EventArgs e)
        {
            ActivateSmallButtons(sender);

            IdaVolta_panel.Visible = true;
            Comercial_SoIda_panel.Visible = false;
        }

        private void Comercial_SoIda_button_Click(object sender, EventArgs e)
        {
            ActivateSmallButtons(sender);

            IdaVolta_panel.Visible = false;
            Comercial_SoIda_panel.Visible = true;
        }

        private void Reservar_button_Click(object sender, EventArgs e)
        {
            if (ComercialDetails_panel.Visible == true)
            {
                if (IdaVolta_panel.Visible == true)
                {
                    //reserva ida e volta



                }
                else
                {
                    //reserva so ida
                }
            }
            else if (ParticularDetails_panel.Visible == true)
            {
                //reserva particular
            }
            else if (MercadoriaDetails_panel.Visible == true)
            {
                //reserva mercadoria
            }
            else
            {
                //reserva avioneta
            }
        }
    }
}
