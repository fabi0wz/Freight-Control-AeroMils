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
            if (aviao != null)
            {
                avioes.Add(aviao);
            }
            else
            {
                throw new ArgumentNullException("aviao", "Aviao cannot be null.");
            }
        }

        public void AddReserva(Reserva reserva)
        {
            if (reserva != null)
            {
                reservas.Add(reserva);
            }
            else
            {
                throw new ArgumentNullException("reserva", "Reserva cannot be null.");
            }
        }

        public void AddManutencao(Manutencoes manutencoes)
        {
            if (manutencoes != null)
            {
                manutencao.Add(manutencoes);
            }
            else
            {
                throw new ArgumentNullException("manutencoes", "Manutencoes cannot be null.");
            }
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
