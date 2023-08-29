using AeroMils___Controlo_de_Frota.Data.DbContext;
using AeroMils___Controlo_de_Frota.Models;
using AeroMils___Controlo_de_Frota.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class Avioes : Form
    {
        private SQLiteDBContext dbContext = new SQLiteDBContext();

        public Avioes()
        {
            InitializeComponent();
            Empresa empresa = dbContext.GetAvioesData();
            List<Aviao> listaAvioes = empresa.GetAvioes();

            MessageBox.Show(listaAvioes.Count.ToString());

            for (int i = 0; i < listaAvioes.Count; i++)
            {
                Aviao aviao = listaAvioes[i];
                MessageBox.Show($"Element {i + 1}: Marca = {aviao.marca}");
            }
        }


    }
}
