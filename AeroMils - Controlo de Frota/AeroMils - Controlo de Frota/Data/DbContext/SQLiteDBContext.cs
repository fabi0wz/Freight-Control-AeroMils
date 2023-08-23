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
    public class SQLiteDBContext
    {
        private SQLiteConnection connection;

        public SQLiteDBContext()
        {
            // Initialize your connection in the constructor
            string connectionString = @"Data Source=../AeroMilsDatabase.db";
            connection = new SQLiteConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        static int InserirNovoAviao(IAviao aviao)
        {
            string connectionString = @"Data Source=Data/AeroMilsDatabase.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO Aviao (modelo, capacidade_passageiros, autonomia, data_ult_manutencao, tipo_de_aviao) VALUES (@modelo, @capacidade, @autonomia, @dataManutencao, @tipo); SELECT last_insert_rowid();";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@modelo", aviao.modelo);
                    command.Parameters.AddWithValue("@capacidade", aviao.capacidade_passageiros);
                    command.Parameters.AddWithValue("@autonomia", aviao.autonomia);
                    command.Parameters.AddWithValue("@dataManutencao", aviao.dataUltimaManutencao);
                    //command.Parameters.AddWithValue("@tipo", aviao.tipoAviao);

                    int newAviaoId = Convert.ToInt32(command.ExecuteScalar());
                    return newAviaoId;
                }
            }
        }

        static void InserirNovaAvioneta(int aviaoId, int areaMinimaDescolagem, decimal valorFrete)
        {
            string connectionString = @"Data Source=Data/AeroMilsDatabase.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO Avioneta (id_aviao, area_minima_descolagem, valor_frete) VALUES (@aviaoId, @areaMinimaDescolagem, @valorFrete);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@areaMinimaDescolagem", areaMinimaDescolagem);
                    command.Parameters.AddWithValue("@valorFrete", valorFrete);

                    command.ExecuteNonQuery();
                }
            }
        }

        static void InserirNovaAeronaveMercadorias(int aviaoId, int capacidadeCarga, decimal valorFrete)
        {
            string connectionString = @"Data Source=Data/AeroMilsDatabase.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO AeronaveMercadorias (id_aviao, capacidade_carga, valor_frete) VALUES (@aviaoId, @capacidadeCarga, @valorFrete);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@capacidadeCarga", capacidadeCarga);
                    command.Parameters.AddWithValue("@valorFrete", valorFrete);

                    command.ExecuteNonQuery();
                }
            }
        }

        static void InserirNovaAeronaveComercial(int aviaoId, int numVoosDiarios, decimal companhiaArea)
        {
            string connectionString = @"Data Source=Data/AeroMilsDatabase.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO AeronavesComerciais (id_aviao, num_voos_diarios, companhia_area) VALUES (@aviaoId, @numVoosDiarios, @companhiaArea);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@numVoosDiarios", numVoosDiarios);
                    command.Parameters.AddWithValue("@companhiaArea", companhiaArea);

                    command.ExecuteNonQuery();
                }
            }
        }

        static void InserirNovaAeronaveParticular(int aviaoId, int numProprietarios, decimal valorFrete)
        {
            string connectionString = @"Data Source=Data/AeroMilsDatabase.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO AeronavesParticulares (id_aviao, num_proprietarios, valor_frete) VALUES (@aviaoId, @numProprietarios, @valorFrete);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@numProprietarios", numProprietarios);
                    command.Parameters.AddWithValue("@valorFrete", valorFrete);

                    command.ExecuteNonQuery();
                }
            }
        }


        public DataTable GetAvioesData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Avioes", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }

    }
}
