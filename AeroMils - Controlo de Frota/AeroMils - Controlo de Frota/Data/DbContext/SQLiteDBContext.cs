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
using System.Reflection;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using AeroMils___Controlo_de_Frota.Modules;
using AeroMils___Controlo_de_Frota.Views;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace AeroMils___Controlo_de_Frota.Data.DbContext
{
    public class SQLiteDBContext
    {
        private SQLiteConnection connection;
        private static readonly string connectionString = "Data Source=../../../Data/AeroMilsDatabase.db";

        public SQLiteDBContext()
        {
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

        public int InserirNovoAviao(string modelo, string marca, int capacidade, int autonomia, DateTime manutencao, string tipo, DateTime ano, int quantidade)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQLite command to insert data into the database
                    string query = "INSERT INTO Avioes (modelo, capacidade_passageiros, autonomia, data_ult_manutencao, tipo_aviao, estado, marca, ano_fabrico, qtd_motores) " +
                                   "VALUES (@Modelo, @Capacidade, @Autonomia, @Manutencao, @Tipo, @Estado, @Marca, @Ano, @Quantidade);" +
                                   "SELECT last_insert_rowid();"; // Retrieve the last inserted row ID

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Modelo", modelo);
                        command.Parameters.AddWithValue("@Capacidade", capacidade);
                        command.Parameters.AddWithValue("@Autonomia", autonomia);
                        command.Parameters.AddWithValue("@Manutencao", manutencao);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Estado", 0);
                        command.Parameters.AddWithValue("@Marca", marca);
                        command.Parameters.AddWithValue("@Ano", ano);
                        command.Parameters.AddWithValue("@Quantidade", quantidade);

                        // Execute the SQL command to insert the data and retrieve the last inserted ID
                        int insertedId = Convert.ToInt32(command.ExecuteScalar());

                        // Check if the insertion was successful and the ID was retrieved
                        if (insertedId > 0)
                        {
                            // Now, you can run any additional logic here if needed
                        }

                        return insertedId;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database interaction
                    Console.WriteLine("Error: " + ex.Message);
                    return -1; // Return a value to indicate failure
                }
            }
        }

        

        public void InserirNovaAvioneta(int aviaoId, int areaMinimaDescolagem, double valorFrete)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO Avionetas (id_aviao, area_minima_descolagem, valor_frete) VALUES (@aviaoId, @areaMinimaDescolagem, @valorFrete);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@areaMinimaDescolagem", areaMinimaDescolagem);
                    command.Parameters.AddWithValue("@valorFrete", valorFrete);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InserirNovaAeronaveMercadorias(int aviaoId, int capacidadeCarga, double valorFrete)
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

        public void InserirNovaAeronaveComercial(int aviaoId, int numVoosDiarios, string companhiaArea)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string query = "INSERT INTO AeronavesComerciais (id_aviao, num_voos_diarios, companhia_aerea) VALUES (@aviaoId, @numVoosDiarios, @companhiaArea);";

                    command.CommandText = query;
                    command.Parameters.AddWithValue("@aviaoId", aviaoId);
                    command.Parameters.AddWithValue("@numVoosDiarios", numVoosDiarios);
                    command.Parameters.AddWithValue("@companhiaArea", companhiaArea);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InserirNovaAeronaveParticular(int aviaoId, int numProprietarios, double valorFrete)
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

        public void InserirNovaReserva(int id_Aviao, string nomeCliente, string origem, string destino, DateTime dataPartida, DateTime dataRetorno)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQLite command to insert data into the database
                    string query = "INSERT INTO Reservas (id_aviao, nome_cliente, data_inicio, data_fim, localPartida, localDestino)" +
                                   "VALUES (@idAviao, @nomeCliente, @dataInicio, @dataFim, @localPartida, @localDestino);";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idAviao", id_Aviao);
                        command.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                        command.Parameters.AddWithValue("@dataInicio", dataPartida);
                        command.Parameters.AddWithValue("@dataFim", dataRetorno);
                        command.Parameters.AddWithValue("@localPartida", origem);
                        command.Parameters.AddWithValue("@localDestino", destino);
                        command.ExecuteNonQuery();
                       
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database interaction
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void ChangePlaneStatus(int planeID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT estado FROM Avioes WHERE id_aviao = @PlaneID", connection))
                {
                    command.Parameters.AddWithValue("@PlaneID", planeID);
                    int currentStatus = Convert.ToInt32(command.ExecuteScalar());

                    int newStatus = currentStatus == 0 ? 1 : 0;

                    using (SQLiteCommand updateCommand = new SQLiteCommand("UPDATE Avioes SET estado = @NewStatus WHERE id_aviao = @PlaneID", connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewStatus", newStatus);
                        updateCommand.Parameters.AddWithValue("@PlaneID", planeID);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
        }


        public Modules.Empresa GetAvioesData()
        {
            Modules.Empresa AeroMills = new Modules.Empresa();
                OpenConnection();
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Avioes ORDER BY id_aviao DESC", connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            {
                                string tipo_aviao = reader["tipo_aviao"].ToString();
                                int id = Convert.ToInt32(reader["id_aviao"]);
                                int capacidade_passageiros = Convert.ToInt32(reader["capacidade_passageiros"]);
                                int autonomia = Convert.ToInt32(reader["autonomia"]);
                                DateTime dataUltimaManutencao = Convert.ToDateTime(reader["data_ult_manutencao"]);
                                bool estado = Convert.ToBoolean(reader["estado"]);
                                int qtdMotores = Convert.ToInt32(reader["qtd_motores"]);
                                string marca = reader["marca"].ToString();
                                string modelo = reader["modelo"].ToString();
                                DateTime anoFabrico = Convert.ToDateTime(reader["ano_fabrico"]);


                                switch (tipo_aviao)
                                {
                                    case "AeronaveComercial":
                                        AeronaveComercial aeronavecomercial = GetAeronavesComerciaisData(id);
                                        aeronavecomercial.capacidade_passageiros = capacidade_passageiros;
                                        aeronavecomercial.autonomia = autonomia;
                                        aeronavecomercial.dataUltimaManutencao = dataUltimaManutencao;
                                        aeronavecomercial.estado = estado;
                                        aeronavecomercial.qtdMotores = qtdMotores;
                                        aeronavecomercial.marca = marca;
                                        aeronavecomercial.modelo = modelo;
                                        aeronavecomercial.anoFabrico = anoFabrico;
                                        aeronavecomercial.Tipo = "Aeronave Comercial";
                                        AeroMills.AddAviao(aeronavecomercial);
                                        break;
                                    case "AeronaveMercadorias":
                                        AeronaveMercadorias aeronavemercadorias = GetAeronavesMercadoriasData(id);
                                        aeronavemercadorias.capacidade_passageiros = capacidade_passageiros;
                                        aeronavemercadorias.autonomia = autonomia;
                                        aeronavemercadorias.dataUltimaManutencao = dataUltimaManutencao;
                                        aeronavemercadorias.estado = estado;
                                        aeronavemercadorias.qtdMotores = qtdMotores;
                                        aeronavemercadorias.marca = marca;
                                        aeronavemercadorias.modelo = modelo;
                                        aeronavemercadorias.anoFabrico = anoFabrico;
                                        aeronavemercadorias.Tipo = "Aeronave de Mercadorias";  
                                        AeroMills.AddAviao(aeronavemercadorias);
                                        break;
                                    case "AeronaveParticular":
                                        AeronaveParticular aeronaveparticular = GetAeroNaveParticularData(id);
                                        aeronaveparticular.capacidade_passageiros = capacidade_passageiros;
                                        aeronaveparticular.autonomia = autonomia;
                                        aeronaveparticular.dataUltimaManutencao = dataUltimaManutencao;
                                        aeronaveparticular.estado = estado;
                                        aeronaveparticular.qtdMotores = qtdMotores;
                                        aeronaveparticular.marca = marca;
                                        aeronaveparticular.modelo = modelo;
                                        aeronaveparticular.anoFabrico = anoFabrico;
                                        aeronaveparticular.Tipo = "Aeronave Particular";
                                        AeroMills.AddAviao(aeronaveparticular);
                                        break;
                                    case "Avioneta":
                                        Avioneta avioneta = GetAvionetaData(id);
                                        avioneta.capacidade_passageiros = capacidade_passageiros;
                                        avioneta.autonomia = autonomia;
                                        avioneta.dataUltimaManutencao = dataUltimaManutencao;
                                        avioneta.estado = estado;
                                        avioneta.qtdMotores = qtdMotores;
                                        avioneta.marca = marca;
                                        avioneta.modelo = modelo;
                                        avioneta.anoFabrico = anoFabrico;
                                        avioneta.Tipo = "Avioneta";
                                        AeroMills.AddAviao(avioneta);
                                        break;
                                    default:
                                        // Handle invalid type
                                        break;
                                }
                            }
                        }
                    
                }

                catch (Exception ex)
                {
                    // Display the exception details in a message box
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
            CloseConnection(); // Ensure the connection is closed in case of an exception
            return AeroMills;
        }


    

        public void getAvailablePlanes(ComboBox combobox, string currentPlane)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQLite command to insert data into the database
                    string query = "SELECT id_aviao, modelo, marca FROM Avioes WHERE tipo_aviao LIKE @tipo_aviao"; 


                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Set the parameters using the SQLiteParameter objects and add them to the command
                        command.Parameters.AddWithValue("@tipo_aviao", currentPlane);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string planeInfo = $"{reader["id_aviao"]} - {reader["modelo"]} - {reader["marca"]}";
                                combobox.Items.Add(planeInfo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database interaction
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            connection.Close();
        }

        public Avioneta GetAvionetaData(int id)
        {
            Avioneta avioneta = null;
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand("SELECT area_minima_descolagem, valor_frete FROM Avionetas WHERE id_aviao = @id_aviao", connection))
            {
                command.Parameters.AddWithValue("@id_aviao", id);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int areaMinimaDescolagem = Convert.ToInt32(reader["area_minima_descolagem"]);
                        double valorFrete = Convert.ToDouble(reader["valor_frete"]);

                        avioneta = new Avioneta(id, areaMinimaDescolagem, valorFrete); // Only set areaDescolagem and valorFrete
                    }
                }
            }

            return avioneta;
        }


        public AeronaveParticular GetAeroNaveParticularData(int id)
        {
            AeronaveParticular aeronaveparticular = null;
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand("SELECT num_proprietarios, valor_frete FROM AeronavesParticulares WHERE id_aviao = @id_aviao", connection))
            {
                command.Parameters.AddWithValue("@id_aviao", id);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int num_proprietarios = Convert.ToInt32(reader["num_proprietarios"]);
                        double valorFrete = Convert.ToDouble(reader["valor_frete"]);

                        aeronaveparticular = new AeronaveParticular(id, num_proprietarios, valorFrete);
                    }
                }
            }

            return aeronaveparticular;
        }

        public AeronaveComercial GetAeronavesComerciaisData(int id)
        {
            AeronaveComercial aeronaveComercial = null;
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand("SELECT num_voos_diarios, companhia_aerea FROM AeronavesComerciais WHERE id_aviao = @id_aviao", connection))
            {
                command.Parameters.AddWithValue("@id_aviao", id);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int num_voos_diarios = Convert.ToInt32(reader["num_voos_diarios"]);
                        string companhia_aerea = reader["companhia_aerea"].ToString();

                        aeronaveComercial = new AeronaveComercial(id, num_voos_diarios, companhia_aerea);
                    }
                }
            }


            return aeronaveComercial;
        }

        public AeronaveMercadorias GetAeronavesMercadoriasData(int id)
        {
            AeronaveMercadorias aeronaveMercadorias = null;
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand("SELECT capacidade_carga, valor_frete FROM AeronavesMercadorias WHERE id_aviao = @id_aviao", connection))
            {
                command.Parameters.AddWithValue("@id_aviao", id);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int capacidade_carga = Convert.ToInt32(reader["capacidade_carga"]);
                        double valor_frete = Convert.ToDouble(reader["valor_frete"]);

                        aeronaveMercadorias = new AeronaveMercadorias(id, capacidade_carga, valor_frete);
                    }
                }
            }


            return aeronaveMercadorias;
        }

        public Aviao GetAviaoById(int idaviao)
        {
            OpenConnection();
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Avioes WHERE id_aviao = @id_aviao", connection))
                {
                    command.Parameters.AddWithValue("@id_aviao", idaviao);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tipo_aviao = reader["tipo_aviao"].ToString();
                            int id = Convert.ToInt32(reader["id_aviao"]);
                            int capacidade_passageiros = Convert.ToInt32(reader["capacidade_passageiros"]);
                            int autonomia = Convert.ToInt32(reader["autonomia"]);
                            DateTime dataUltimaManutencao = Convert.ToDateTime(reader["data_ult_manutencao"]);
                            bool estado = Convert.ToBoolean(reader["estado"]);
                            int qtdMotores = Convert.ToInt32(reader["qtd_motores"]);
                            string marca = reader["marca"].ToString();
                            string modelo = reader["modelo"].ToString();
                            DateTime anoFabrico = Convert.ToDateTime(reader["ano_fabrico"]);


                            switch (tipo_aviao)
                            {
                                case "AeronaveComercial":
                                    AeronaveComercial aeronavecomercial = GetAeronavesComerciaisData(id);
                                    aeronavecomercial.capacidade_passageiros = capacidade_passageiros;
                                    aeronavecomercial.autonomia = autonomia;
                                    aeronavecomercial.dataUltimaManutencao = dataUltimaManutencao;
                                    aeronavecomercial.estado = estado;
                                    aeronavecomercial.qtdMotores = qtdMotores;
                                    aeronavecomercial.marca = marca;
                                    aeronavecomercial.modelo = modelo;
                                    aeronavecomercial.anoFabrico = anoFabrico;
                                    aeronavecomercial.Tipo = "Aeronave Comercial";
                                    return aeronavecomercial;
                                    break;
                                case "AeronaveMercadorias":
                                    AeronaveMercadorias aeronavemercadorias = GetAeronavesMercadoriasData(id);
                                    aeronavemercadorias.capacidade_passageiros = capacidade_passageiros;
                                    aeronavemercadorias.autonomia = autonomia;
                                    aeronavemercadorias.dataUltimaManutencao = dataUltimaManutencao;
                                    aeronavemercadorias.estado = estado;
                                    aeronavemercadorias.qtdMotores = qtdMotores;
                                    aeronavemercadorias.marca = marca;
                                    aeronavemercadorias.modelo = modelo;
                                    aeronavemercadorias.anoFabrico = anoFabrico;
                                    aeronavemercadorias.Tipo = "Aeronave de Mercadorias";
                                    return aeronavemercadorias;
                                    break;
                                case "AeronaveParticular":
                                    AeronaveParticular aeronaveparticular = GetAeroNaveParticularData(id);
                                    aeronaveparticular.capacidade_passageiros = capacidade_passageiros;
                                    aeronaveparticular.autonomia = autonomia;
                                    aeronaveparticular.dataUltimaManutencao = dataUltimaManutencao;
                                    aeronaveparticular.estado = estado;
                                    aeronaveparticular.qtdMotores = qtdMotores;
                                    aeronaveparticular.marca = marca;
                                    aeronaveparticular.modelo = modelo;
                                    aeronaveparticular.anoFabrico = anoFabrico;
                                    aeronaveparticular.Tipo = "Aeronave Particular";
                                    return aeronaveparticular;
                                    break;
                                case "Avioneta":
                                    Avioneta avioneta = GetAvionetaData(id);
                                    avioneta.capacidade_passageiros = capacidade_passageiros;
                                    avioneta.autonomia = autonomia;
                                    avioneta.dataUltimaManutencao = dataUltimaManutencao;
                                    avioneta.estado = estado;
                                    avioneta.qtdMotores = qtdMotores;
                                    avioneta.marca = marca;
                                    avioneta.modelo = modelo;
                                    avioneta.anoFabrico = anoFabrico;
                                    avioneta.Tipo = "Avioneta";
                                    return avioneta;
                                    break;
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                // Display the exception details in a message box
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            CloseConnection(); // Ensure the connection is closed in case of an exception
            return null;
        }

        public Modules.Empresa GetReservasData()
        {
            Modules.Empresa AeroMills = new Modules.Empresa();
            OpenConnection();
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Reservas ORDER BY id_reserva DESC", connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id_reserva = Convert.ToInt32(reader["id_reserva"]);
                        int id_aviao = Convert.ToInt32(reader["id_aviao"]);
                        string nome_cliente = reader["nome_cliente"].ToString();
                        string data_inicio = reader["data_inicio"].ToString();
                        string data_fim = reader["data_fim"].ToString();

                        Reserva reserva = new Reserva(id_aviao, id_reserva, nome_cliente, data_inicio, data_fim);
                        
                        
                        AeroMills.AddReserva(reserva);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the exception details in a message box
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CloseConnection(); // Ensure the connection is closed in case of an exception
            return AeroMills;
        }

        public DataTable GetPreviousReservasData()
        {
           
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand(
                               "SELECT * " +
                               "FROM Reservas " +
                               "WHERE data_fim < DATE('now') " +
                               "ORDER BY data_fim DESC", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnection(); // Close the connection after using it
            return dataTable;
        }

        public Modules.Empresa GetManutencoesData()
        {
            Modules.Empresa AeroMills = new Modules.Empresa();
            OpenConnection();
            try
            {
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Manutencoes ORDER BY id_manutencao DESC", connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id_aviao = Convert.ToInt32(reader["id_aviao"]);
                        int id_manutencao = Convert.ToInt32(reader["id_manutencao"]);
                        string data_inicio = reader["data_inicio"].ToString();
                        string data_fim = reader["data_fim"].ToString();

                        Manutencoes manutencoes = new Manutencoes(id_aviao, id_manutencao, data_inicio, data_fim);


                        AeroMills.AddManutencao(manutencoes);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the exception details in a message box
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CloseConnection(); // Ensure the connection is closed in case of an exception
            return AeroMills;
        }

        public DataTable GetPreviousManutencoesData()
        {
            DataTable dataTable = new DataTable();

            OpenConnection(); // Open the connection before using it

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT * " +
                "FROM Manutencoes " +
                "WHERE data_fim < DATE('now') " +
                "ORDER BY data_fim DESC", connection))
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
                "WHERE estado = 1 " +
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
