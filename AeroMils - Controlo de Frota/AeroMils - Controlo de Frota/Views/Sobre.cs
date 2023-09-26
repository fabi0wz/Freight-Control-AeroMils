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
    public partial class Sobre : Form
    {
        int pageNumber = 0;

        public Sobre()
        {
            InitializeComponent();
            panel0.Visible = true;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            pageNumber++;

            if (pageNumber > 3)
            {
                pageNumber = 3;
            }

            if (pageNumber == 0)
            {
                panel0.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }

            if (pageNumber == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel0.Visible = false;

            }

            if (pageNumber == 2)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
                panel0.Visible = false;
            }

            if (pageNumber == 3)
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel0.Visible = false;
            }

        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            pageNumber--;

            if (pageNumber < 0)
            {
                pageNumber = 0;
            }

            if (pageNumber == 0)
            {
                panel0.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }

            if (pageNumber == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel0.Visible = false;
            }

            if (pageNumber == 2)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
                panel0.Visible = false;
            }

            if (pageNumber == 3)
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel0.Visible = false;
            }
        }


    }
}
