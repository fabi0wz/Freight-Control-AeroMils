using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Models;
using AeroMils___Controlo_de_Frota.Views;

namespace AeroMils___Controlo_de_Frota.Modules
{
    public class Empresa
    {
        private List<Aviao> avioes;
        private List<Reserva> reservas;
        private List<Manutencoes> manutencao;

        public Empresa()
        {
            avioes = new List<Aviao>();
            reservas = new List<Reserva>();
            manutencao = new List<Manutencoes>();
        }

        public void AddAviao(Aviao aviao)
        {
            avioes.Add(aviao);
        }

        public void AddReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }
        
        public void AddManutencao(Manutencoes manutencoes)
        {
            manutencao.Add(manutencoes);
        }

        public List<Aviao> GetAvioes()
        {
            return avioes;
        }

        public List<Reserva> GetReservas()
        {
            return reservas;
        }
        
        public List<Manutencoes> GetManutencoes()
        {
            return manutencao;
        }
    }
}
