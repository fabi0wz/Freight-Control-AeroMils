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
    public partial class Dashboard : Form
    {
        private SQLiteDBContext dbContext = new SQLiteDBContext();
        int dayCounter = 0;

        public Dashboard()
        {
            //sets the date to today and renders the table
            InitializeComponent();
            dataHoje_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
            renderTable();
        }

        private void Mais1dia_button_Click(object sender, EventArgs e)
        {
            //adds 1 day to the date and renders the table
            dayCounter++;

            dataHoje_label.Text = DateTime.Now.AddDays(dayCounter).ToString("dd/MM/yyyy");
            renderTable();
        }

        private void Menos1dia_Button_Click(object sender, EventArgs e)
        {
            //removes 1 day to the date and renders the table
            dayCounter--;
            dataHoje_label.Text = DateTime.Now.AddDays(dayCounter).ToString("dd/MM/yyyy");
            renderTable();
        }
        private void Today_button_Click(object sender, EventArgs e)
        {
            //sets the date to today and renders the table
            dataHoje_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
            renderTable();
        }

        private void renderTable()
        {
            //gets the data from the database and renders the table
            DataTable avioesEmViagemDataTable = dbContext.GetAvioesEmViagem(DateTime.Parse(dataHoje_label.Text));
            DataTable fretesATerminarDataTable = dbContext.GetFretesATerminar(DateTime.Parse(dataHoje_label.Text));
            DataTable manutencoesEmBreveDataTAble = dbContext.GetManutencoesEmBreve(DateTime.Parse(dataHoje_label.Text));

            //sets the data source of the table to the data from the database
            dataGridViewAvioesemViagem.DataSource = avioesEmViagemDataTable;
            dataGridViewFretesaTerminar.DataSource = fretesATerminarDataTable;
            dataGridViewManutencoesemBreve.DataSource = manutencoesEmBreveDataTAble;
        }

    }
}
