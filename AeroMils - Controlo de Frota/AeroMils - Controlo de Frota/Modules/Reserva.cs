using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Modules
{
    internal class Reserva
    {
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private double _valorFreteTotal;

        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public double valorFreteTotal { get; set; }

        public Reserva(DateTime dataInicio, DateTime dataFim, double valorFreteTotal)
        {
            _dataInicio = dataInicio;
            _dataFim = dataFim;
            _valorFreteTotal = valorFreteTotal;
        }
    }
}
