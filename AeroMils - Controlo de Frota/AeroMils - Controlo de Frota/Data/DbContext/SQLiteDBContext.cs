using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;
using AeroMils___Controlo_de_Frota.Models;

namespace AeroMils___Controlo_de_Frota.Data.DbContext
{
    internal class SQLiteDBContext
    {
        SQLiteConnection DBConnection = new SQLiteConnection(@"Data/AeroMilsDatabase.db"); 


        public void openConnection()
        {
            DBConnection.Open();
        }

        public void closeConnection()
        {
            DBConnection.Close();
        }

        public void inserirNovoAviao(IAviao aviao)
        {
            string query = $"INSERT INTO Aviao (modelo, capacidade_passageiros, autonomia, data_ult_manutencao, tipo_de_aviao) VALUES ({aviao.modelo}, {aviao.capacidade_passageiros}, {aviao.autonomia}, )";
            //ok uma explicacao rapida (depois explico melhor) esta funcao recebe por parametro nao um objeto mas uma interface (como o sergio disse interface é um contrato que as classes sao obrigadas a implementar)
            //ou seja nao importa qual é o tipo de aviao que estamos a passar para aqui, o que importa é que implemente a interface IAviao
            //isto é util porque assim podemos passar qualquer tipo de aviao para aqui e o codigo vai funcionar na mesma
            //A seguir vou fazer um metodo para determinar o tipo de aviao (em cada um dos Models, vai ter uma especie to_string que só retorna o string a dizer o tipo de aviao) e depois com um if
            //escolhemos para que table vamos adicionar o resto das informacoes do aviao

            //getPlaneType(aviao.GetPlaneType);
        }   
    }
}
