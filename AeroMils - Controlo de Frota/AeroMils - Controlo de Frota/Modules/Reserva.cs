using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Modules
{
    public class Reserva
    {
        private DateTime _data_inicio;
        private DateTime _data_fim;
        private string _nome_cliente;
        private int _id_aviao;
        private int _id_reserva;

        public string data_inicio
        {
            get
            {
                return _data_inicio.ToString("dd/MM/yyyy");
            }
            set
            {
                this._data_inicio = DateTime.Parse(value);
            }
        }
        public string data_fim
        {
            get
            {
                return _data_fim.ToString("dd/MM/yyyy");
            }
            set
            {
                this._data_fim = DateTime.Parse(value);
            }
        }

        public int id_aviao { get; set; }
        public int id_reserva { get; set; }
        public string nome_cliente { get; set; }


        public Reserva(int id_aviao, int id_reserva, string nome_cliente, string data_inicio, string data_fim)
        {
            this.id_aviao = id_aviao;
            this.id_reserva = id_reserva;
            this.nome_cliente = nome_cliente;
            this.data_inicio = data_inicio;
            this.data_fim = data_fim;
        }

    }
}
