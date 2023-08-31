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
        private int counter = -1;
        private bool endFlag = false;

        public Avioes()
        {
            InitializeComponent();
            retrieveData();
        }

        public void retrieveData()
        {
            Empresa empresa = dbContext.GetAvioesData();
            List<Aviao> listaAvioes = empresa.GetAvioes();
            renderTable(listaAvioes);
        }

        private void avioesNextButton_Click(object sender, EventArgs e)
        {
            if (endFlag)
            {
                MessageBox.Show("Não existem mais dados para mostrar");
            }
            else
            {
                counter += 9;
                clearTable();
                retrieveData();
            }
            
        }

        private void avioesPreviousButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(counter < -1)
                {
                    MessageBox.Show("Não existem mais dados para mostrar");
                }
                else
                {
                    counter -= 9;
                    retrieveData();
                    endFlag = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Index está fora do range");
            }

        }

        public void renderTable(List<Aviao> listaAvioes)
        {

            //Linha 1
            if (counter + 1 <= listaAvioes.Count - 1)
            {
                aviaoLinha1ID.Text = listaAvioes[counter + 1].id.ToString();
                aviaoLinha1Modelo.Text = listaAvioes[counter + 1].modelo.ToString();
                aviaoLinha1Estado.Text = listaAvioes[counter + 1].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha1Tipo.Text = listaAvioes[counter + 1].Tipo;
                aviaoLinha1DataManutencao.Text = listaAvioes[counter + 1].dataUltimaManutencao.ToString();

                if (counter + 1 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha2
            if (counter + 2 <= listaAvioes.Count - 1)
            {
                aviaoLinha2ID.Text = listaAvioes[counter + 2].id.ToString();
                aviaoLinha2Modelo.Text = listaAvioes[counter + 2].modelo.ToString();
                aviaoLinha2Estado.Text = listaAvioes[counter + 2].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha2Tipo.Text = listaAvioes[counter + 2].Tipo;
                aviaoLinha2DataManutencao.Text = listaAvioes[counter + 2].dataUltimaManutencao.ToString();

                if(counter+2 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha3
            if (counter + 3 <= listaAvioes.Count - 1)
            {
                aviaoLinha3ID.Text = listaAvioes[counter + 3].id.ToString();
                aviaoLinha3Modelo.Text = listaAvioes[counter + 3].modelo.ToString();
                aviaoLinha3Estado.Text = listaAvioes[counter + 3].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha3Tipo.Text = listaAvioes[counter + 3].Tipo;
                aviaoLinha3DataManutencao.Text = listaAvioes[counter + 3].dataUltimaManutencao.ToString();

                if (counter + 3 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha4
            if (counter + 4 <= listaAvioes.Count - 1)
            {
                aviaoLinha4ID.Text = listaAvioes[counter + 4].id.ToString();
                aviaoLinha4Modelo.Text = listaAvioes[counter + 4].modelo.ToString();
                aviaoLinha4Estado.Text = listaAvioes[counter + 4].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha4Tipo.Text = listaAvioes[counter + 4].Tipo;
                aviaoLinha4DataManutencao.Text = listaAvioes[counter + 4].dataUltimaManutencao.ToString();

                if (counter + 4 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha5
            if (counter + 5 <= listaAvioes.Count - 1)
            {
                aviaoLinha5ID.Text = listaAvioes[counter + 5].id.ToString();
                aviaoLinha5Modelo.Text = listaAvioes[counter + 5].modelo.ToString();
                aviaoLinha5Estado.Text = listaAvioes[counter + 5].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha5Tipo.Text = listaAvioes[counter + 5].Tipo;
                aviaoLinha5DataManutencao.Text = listaAvioes[counter + 5].dataUltimaManutencao.ToString();

                if (counter + 5 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha6
            if (counter + 6 <= listaAvioes.Count - 1)
            {
                aviaoLinha6ID.Text = listaAvioes[counter + 6].id.ToString();
                aviaoLinha6Modelo.Text = listaAvioes[counter + 6].modelo.ToString();
                aviaoLinha6Estado.Text = listaAvioes[counter + 6].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha6Tipo.Text = listaAvioes[counter + 6].Tipo;
                aviaoLinha6DataManutencao.Text = listaAvioes[counter + 6].dataUltimaManutencao.ToString();

                if (counter + 6 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha7
            if (counter + 7 <= listaAvioes.Count - 1)
            {
                aviaoLinha7ID.Text = listaAvioes[counter + 7].id.ToString();
                aviaoLinha7Modelo.Text = listaAvioes[counter + 7].modelo.ToString();
                aviaoLinha7Estado.Text = listaAvioes[counter + 7].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha7Tipo.Text = listaAvioes[counter + 7].Tipo;
                aviaoLinha7DataManutencao.Text = listaAvioes[counter + 7].dataUltimaManutencao.ToString();

                if (counter + 7 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha8
            if (counter + 8 <= listaAvioes.Count - 1)
            {
                aviaoLinha8ID.Text = listaAvioes[counter + 8].id.ToString();
                aviaoLinha8Modelo.Text = listaAvioes[counter + 8].modelo.ToString();
                aviaoLinha8Estado.Text = listaAvioes[counter + 8].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha8Tipo.Text = listaAvioes[counter + 8].Tipo;
                aviaoLinha8DataManutencao.Text = listaAvioes[counter + 8].dataUltimaManutencao.ToString();

                if (counter + 8 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

            //Linha 9
            if (counter + 9 <= listaAvioes.Count - 1)
            {
                aviaoLinha9ID.Text = listaAvioes[counter + 9].id.ToString();
                aviaoLinha9Modelo.Text = listaAvioes[counter + 9].modelo.ToString();
                aviaoLinha9Estado.Text = listaAvioes[counter + 9].estado == false ? "No Hangar" : "Em Viagem";
                aviaoLinha9Tipo.Text = listaAvioes[counter + 9].Tipo;
                aviaoLinha9DataManutencao.Text = listaAvioes[counter + 9].dataUltimaManutencao.ToString();

                if (counter + 9 == listaAvioes.Count - 1)
                {
                    endFlag = true;
                }
            }

        }

        public void clearTable()
        {
            //Linha 1
            aviaoLinha1ID.Text = "";
            aviaoLinha1Modelo.Text = "";
            aviaoLinha1Estado.Text = "";
            aviaoLinha1Tipo.Text = "";
            aviaoLinha1DataManutencao.Text = "";

            //Linha2
            aviaoLinha2ID.Text = "";
            aviaoLinha2Modelo.Text = "";
            aviaoLinha2Estado.Text = "";
            aviaoLinha2Tipo.Text = "";
            aviaoLinha2DataManutencao.Text = "";

            //Linha3
            aviaoLinha3ID.Text = "";
            aviaoLinha3Modelo.Text = "";
            aviaoLinha3Estado.Text = "";
            aviaoLinha3Tipo.Text = "";
            aviaoLinha3DataManutencao.Text = "";

            //Linha4
            aviaoLinha4ID.Text = "";
            aviaoLinha4Modelo.Text = "";
            aviaoLinha4Estado.Text = "";
            aviaoLinha4Tipo.Text = "";
            aviaoLinha4DataManutencao.Text = "";

            //Linha5
            aviaoLinha5ID.Text = "";
            aviaoLinha5Modelo.Text = "";
            aviaoLinha5Estado.Text = "";
            aviaoLinha5Tipo.Text = "";
            aviaoLinha5DataManutencao.Text = "";

            //Linha6
            aviaoLinha6ID.Text = "";
            aviaoLinha6Modelo.Text = "";
            aviaoLinha6Estado.Text = "";
            aviaoLinha6Tipo.Text = "";
            aviaoLinha6DataManutencao.Text = "";

            //Linha7

            aviaoLinha7ID.Text = "";
            aviaoLinha7Modelo.Text = "";
            aviaoLinha7Estado.Text = "";
            aviaoLinha7Tipo.Text = "";
            aviaoLinha7DataManutencao.Text = "";

            //Linha8

            aviaoLinha8ID.Text = "";
            aviaoLinha8Modelo.Text = "";
            aviaoLinha8Estado.Text = "";
            aviaoLinha8Tipo.Text = "";
            aviaoLinha8DataManutencao.Text = "";

            //Linha 9

            aviaoLinha9ID.Text = "";
            aviaoLinha9Modelo.Text = "";
            aviaoLinha9Estado.Text = "";
            aviaoLinha9Tipo.Text = "";
            aviaoLinha9DataManutencao.Text = "";
        }

    }
}
