using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;
using AeroMils___Controlo_de_Frota.Models;
using System.Numerics;

namespace AeroMils___Controlo_de_Frota.Data.DbContext
{
    public class SQLiteDBContext
    {
        private SQLiteConnection connection;
        private static string connectionString = @"Data Source=C:\Users\Fabi0\Desktop\Freight-Control-AeroMils\AeroMils - Controlo de Frota\AeroMils - Controlo de Frota\Data\AeroMilsDatabase.db";

        public SQLiteDBContext()
        {
            // Initialize your connection in the constructor
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

        static void InserirNovaReserva(int aviaoId, string nome_cliente, DateTime data_inicio, DateTime data_fim)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO Reservas (id_aviao, nome_cliente, data_inicio, data_fim) VALUES (@aviaoId, @nome_cliente, @data_inicio, @data_fim);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@nome_cliente", nome_cliente);
                    command.Parameters.AddWithValue("@data_inicio", data_inicio);
                    command.Parameters.AddWithValue("@data_fim", data_fim);

                    command.ExecuteNonQuery();
                }
            }   
        }

        public static void ChangePlaneStatus(int planeID)
        {
            using (SQLiteConnection connection = new SQLiteConnection("your_connection_string_here"))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT Status FROM Avioes WHERE ID = @PlaneID", connection))
                {
                    command.Parameters.AddWithValue("@PlaneID", planeID);
                    int currentStatus = Convert.ToInt32(command.ExecuteScalar());

                    int newStatus = currentStatus == 0 ? 1 : 0;

                    using (SQLiteCommand updateCommand = new SQLiteCommand("UPDATE Avioes SET Status = @NewStatus WHERE ID = @PlaneID", connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewStatus", newStatus);
                        updateCommand.Parameters.AddWithValue("@PlaneID", planeID);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
        }


        public static int GetLastPlaneID()
        {
            int highestID = -1;

            using (SQLiteConnection connection = new SQLiteConnection("your_connection_string_here"))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT MAX(id_aviao) FROM Avioes", connection))
                {
                    highestID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return highestID;
        }


        public List<Plane> GetAvioesData()
        {
            List<Plane> planes = new List<Plane>();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Avioes", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Plane plane = new Plane

                        //private int _capacidade_passageiros;
                        //private int _autonomia;
                        //private DateTime _dataUltimaManutencao;
                        //private bool _estado;
                        //private int _qtdMotores;
                        //private string _marca;
                        //private string _modelo;
                        //private DateTime _anoFabrico;
                        {
                            ID = Convert.ToInt32(reader["id_aviao"]),
                            Model = reader["Model"].ToString(),
                            // Set other properties here
                        };
                        planes.Add(plane);
                    }
                }
            }

            CloseConnection(); // Close the connection after using it

            return planes;
        }

        public DataTable getAvailablePlanes()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Avioes WHERE Status = 0", connection)) // status 0 é disponivel 1 em viagem
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it
                   
            return dataTable;
        }   

        public DataTable GetAvionetasData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Avionetas", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }


        public DataTable GetAeronavesParticularesData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM AeronavesParticulares", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }

        public DataTable GetAeronavesComerciaisData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM AeronavesComerciais", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }

        public DataTable GetAeronavesMercadoriasData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM AeronavesMercadorias", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }

        public DataTable GetReservasData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Reservas", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }

        public DataTable GetManutencoesData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Manutencoes", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it

            return dataTable;
        }

        public DataTable GetAvioesEmViagem()
        {
            DataTable dataTable = new DataTable();
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT * " +
                "FROM Avioes " +
                "WHERE Status = 1 " +
                "LIMIT 5", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            CloseConnection();
            return dataTable;
        }

        public DataTable GetFretesATerminar()
        {
            DataTable dataTable = new DataTable();
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT * " +
                "FROM Reservas " +
                "WHERE data_fim >= DATE('now') " +
                "ORDER BY data_fim ASC " +
                "LIMIT 5", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            CloseConnection();
            return dataTable;
        }

        public DataTable GetManutencoesEmBreve()
        {
            DataTable dataTable = new DataTable();
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT Avioes.id_aviao, modelo, data_ult_manutencao AS Data_da_Ultima_Manutencao, data_fim AS Validade_Manutenção " +
                "FROM Avioes, Manutencoes " +
                "WHERE Avioes.id_aviao = Manutencoes.id_aviao " +
                "AND Manutencoes.data_fim >= DATE('now') " +
                "ORDER BY data_fim ASC " +
                "LIMIT 5", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            CloseConnection();
            return dataTable;
        }

    }
}
