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

        public NovaReserva()
        {
            InitializeComponent();

            panel_vooComercial.Visible = true;
            panel_vooParticular.Visible = false;
            panel_vooMercadoria.Visible = false;
            panel_avionetas.Visible = false;
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
            foreach (Control btn in VoosPanel.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(54, 53, 67);
                    btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //opens a panel and closes child panels if they are open 

        private void VooComercial_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panel_vooComercial.Visible = true;
            panel_vooParticular.Visible = false;
            panel_vooMercadoria.Visible = false;
            panel_avionetas.Visible = false;
        }

        private void VooParticular_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panel_vooComercial.Visible = false;
            panel_vooParticular.Visible = true;
            panel_vooMercadoria.Visible = false;
            panel_avionetas.Visible = false;
        }

        private void VooMercadoria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panel_vooComercial.Visible = false;
            panel_vooParticular.Visible = false;
            panel_vooMercadoria.Visible = true;
            panel_avionetas.Visible = false;
        }

        private void Avionetas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            panel_vooComercial.Visible = false;
            panel_vooParticular.Visible = false;
            panel_vooMercadoria.Visible = false;
            panel_avionetas.Visible = true;
        }


    }
}
