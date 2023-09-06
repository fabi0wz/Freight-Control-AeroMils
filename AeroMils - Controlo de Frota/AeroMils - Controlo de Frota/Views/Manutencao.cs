using AeroMils___Controlo_de_Frota.Data.DbContext;
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
    public partial class Manutencao : Form
    {
        private SQLiteDBContext dbContext = new SQLiteDBContext();
        public Manutencao()
        {
            InitializeComponent();

        }
    }
}
