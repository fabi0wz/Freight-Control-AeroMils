using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Model
{
    internal static class tempDB
    {
        public static void criarAeronaveComercial(int instancesAeronaveComercial, Random AeronaveComercialRand)
        {
            for (int i = 0; i < instancesAeronaveComercial; i++)
            {

                //int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado,
                //int qtdMotores, string marca, string modelo, DateTime anoFabrico, int numeroVoosDia, string companhiaAerea

                int capacidade_passageiros = AeronaveComercialRand.Next(100, 1000);
                int autonomia = AeronaveComercialRand.Next(400, 2000);
                string data_ult_manutencao = GenerateRandomDate(AeronaveComercialRand);
                bool estado = AeronaveComercialRand.Next(0, 2) == 1 ? true : false;
                int qtdMotores = AeronaveComercialRand.Next(1, 4);
                string marca = $"Aviao Comercial# {i}";
                string modelo = $"AC00{i}";
                string anoFabrico = GenerateRandomDate(AeronaveComercialRand);
                int numeroVoosDia = AeronaveComercialRand.Next(5000, 10000);
                string companhiaAerea = $"voo# {i}";

                AeronaveMercadorias aeronavemercadorias = new AeronaveMercadorias(capacidade_passageiros, autonomia, Convert.ToDateTime(data_ult_manutencao), estado, qtdMotores, marca, modelo, Convert.ToDateTime(anoFabrico), numeroVoosDia, companhiaAerea);
            }
        }
        public static void criarAeronavesMercadorias(int instancesAeronaveMercadorias, Random AeronaveMercadoriasRand)
        {
            for (int i = 0; i < instancesAeronaveMercadorias; i++)
            {

                //int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores, string marca,
                //string modelo, DateTime anoFabrico, int capacidadeCarga, double valorFrete

                int capacidade_passageiros = AeronaveMercadoriasRand.Next(100, 1000);
                int autonomia = AeronaveMercadoriasRand.Next(400, 2000);
                string data_ult_manutencao = GenerateRandomDate(AeronaveMercadoriasRand);
                bool estado = AeronaveMercadoriasRand.Next(0, 2) == 1 ? true : false;
                int qtdMotores = AeronaveMercadoriasRand.Next(1, 4);
                string marca = $"Aviao Mercadorias# {i}";
                string modelo = $"AM00{i}";
                string anoFabrico = GenerateRandomDate(AeronaveMercadoriasRand);
                int capacidadeCarga = AeronaveMercadoriasRand.Next(5000, 10000);
                double valorFrete = AeronaveMercadoriasRand.NextDouble() * (1000 - 50) + 50;

                AeronaveMercadorias aeronavemercadorias = new AeronaveMercadorias(capacidade_passageiros, autonomia, Convert.ToDateTime(data_ult_manutencao), estado, qtdMotores, marca, modelo, Convert.ToDateTime(anoFabrico), capacidadeCarga, valorFrete);
            }
        }

        public static void criarAeronavesParticulares(int instancesAeronaveParticular, Random AeronaveParticularRand)
        {
            for (int i = 0; i < instancesAeronaveParticular; i++)
            {

                //int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado, int qtdMotores,
                //string marca, string modelo, DateTime anoFabrico, int numProprietarios, double valorFrete

                int capacidade_passageiros = AeronaveParticularRand.Next(100, 1000);
                int autonomia = AeronaveParticularRand.Next(400, 2000);
                string data_ult_manutencao = GenerateRandomDate(AeronaveParticularRand);
                bool estado = AeronaveParticularRand.Next(0, 2) == 1 ? true : false;
                int qtdMotores = AeronaveParticularRand.Next(1, 4);
                string marca = $"Aviao Pessoal# {i}";
                string modelo = $"AP00{i}";
                string anoFabrico = GenerateRandomDate(AeronaveParticularRand);
                int numProprietarios = AeronaveParticularRand.Next(1, 10);
                double valorFrete = AeronaveParticularRand.NextDouble() * (1000 - 50) + 50;

                AeronaveParticular aeronaveparticular = new AeronaveParticular(capacidade_passageiros, autonomia, Convert.ToDateTime(data_ult_manutencao), estado, qtdMotores, marca, modelo, Convert.ToDateTime(anoFabrico), numProprietarios, valorFrete);
            }
        }

        public static void criarAvionetas(int instancesAvioneta, Random avionetaRnd)
        {
            for (int i = 0; i < instancesAvioneta; i++)
            {
                //int capacidade_passageiros, int autonomia, DateTime data_ult_manutencao, bool estado,
                //int qtdMotores, string marca, string modelo, DateTime anoFabrico, int areaDescolagem, int areaPouso, double valorFrete

                int capacidade_passageiros = avionetaRnd.Next(100, 1000);
                int autonomia = avionetaRnd.Next(400, 2000);
                string data_ult_manutencao = GenerateRandomDate(avionetaRnd);
                bool estado = avionetaRnd.Next(0, 2) == 1 ? true : false;
                int qtdMotores = avionetaRnd.Next(1, 4);
                string marca = $"Avioneta# {i}";
                string modelo = $"AV00{i}";
                string anoFabrico = GenerateRandomDate(avionetaRnd);
                int areaDescolagem = avionetaRnd.Next(100, 200);
                int areaPouso = avionetaRnd.Next(50, 100);
                double valorFrete = avionetaRnd.NextDouble() * (1000 - 50) + 50;

                Avioneta avioneta = new Avioneta(capacidade_passageiros, autonomia, Convert.ToDateTime(data_ult_manutencao), estado, qtdMotores, marca, modelo, Convert.ToDateTime(anoFabrico), areaDescolagem, areaPouso, valorFrete);
            }
        }
        public static void CreateDefaults()
        {
            

            Random rand = new Random();
            criarAeronavesParticulares(100, rand);
            criarAeronavesMercadorias(100, rand);
            criarAeronaveComercial(100, rand);
            criarAvionetas(100, rand);
        }

        public static string GenerateRandomDate(Random random)
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - startDate).Days;
            DateTime randomDate = startDate.AddDays(random.Next(range));
            return randomDate.ToString("dd/MM/yyyy");
        }
    }
}