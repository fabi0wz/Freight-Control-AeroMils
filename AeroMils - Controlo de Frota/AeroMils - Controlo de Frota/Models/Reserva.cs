using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    internal class Reserva
    {
        private int id_aviao;
        private string nome_cliente;
        private DateTime data_inicio;
        private DateTime data_fim;

        public int Id_aviao { get => id_aviao; set => id_aviao = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public DateTime Data_inicio { get => data_inicio; set => data_inicio = value; }
        public DateTime Data_fim { get => data_fim; set => data_fim = value; }

        public Reserva(int id_aviao, string nome_cliente, DateTime data_inicio, DateTime data_fim)
        {
            this.id_aviao = id_aviao;
            this.nome_cliente = nome_cliente;
            this.data_inicio = data_inicio;
            this.data_fim = data_fim;
        }
    }
}
