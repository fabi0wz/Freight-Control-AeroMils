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
            InitializeComponent();
            dataHoje_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
            renderTable();
        }

        private void Mais1dia_button_Click(object sender, EventArgs e)
        {
            dayCounter++;

            dataHoje_label.Text = DateTime.Now.AddDays(dayCounter).ToString("dd/MM/yyyy");
            renderTable();
        }

        private void Menos1dia_Button_Click(object sender, EventArgs e)
        {
            dayCounter--;
            dataHoje_label.Text = DateTime.Now.AddDays(dayCounter).ToString("dd/MM/yyyy");
            renderTable();
        }

        private void renderTable()
        {
            DataTable avioesEmViagemDataTable = dbContext.GetAvioesEmViagem(DateTime.Parse(dataHoje_label.Text));
            DataTable fretesATerminarDataTable = dbContext.GetFretesATerminar(DateTime.Parse(dataHoje_label.Text));
            DataTable manutencoesEmBreveDataTAble = dbContext.GetManutencoesEmBreve(DateTime.Parse(dataHoje_label.Text));

            dataGridViewAvioesemViagem.DataSource = avioesEmViagemDataTable;
            dataGridViewFretesaTerminar.DataSource = fretesATerminarDataTable;
            dataGridViewManutencoesemBreve.DataSource = manutencoesEmBreveDataTAble;
        }
    }
}
