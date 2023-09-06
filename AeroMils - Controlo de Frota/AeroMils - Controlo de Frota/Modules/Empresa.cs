using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroMils___Controlo_de_Frota.Models;

namespace AeroMils___Controlo_de_Frota.Modules
{
    public class Empresa
    {
        private List<Aviao> avioes;
        private List<Reserva> reservas;

        public Empresa()
        {
            avioes = new List<Aviao>();
            reservas = new List<Reserva>();
        }

        public void AddAviao(Aviao aviao)
        {
            avioes.Add(aviao);
        }

        public void AddReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public List<Aviao> GetAvioes()
        {
            return avioes;
        }

        public List<Reserva> GetReservas()
        {
            return reservas;
        }
    }
}
