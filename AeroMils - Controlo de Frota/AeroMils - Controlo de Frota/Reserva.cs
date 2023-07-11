using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota
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
            this._dataInicio = dataInicio;
            this._dataFim = dataFim;
            this._valorFreteTotal = valorFreteTotal;
        }
    }
}
