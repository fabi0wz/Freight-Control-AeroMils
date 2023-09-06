using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Modules
{
    public class Manutencoes
    {
        private DateTime _data_inicio;
        private DateTime _data_fim;
        private int _id_aviao;
        private int _id_manutencao;

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
        public double valorFreteTotal { get; set; }
        public int id_aviao { get; set; }
        public int id_manutencao { get; set; }


        public Manutencoes(int id_aviao, int id_manutencao, string data_inicio, string data_fim)
        {
            this.id_aviao = id_aviao;
            this.id_manutencao = id_manutencao;
            this.data_inicio = data_inicio;
            this.data_fim = data_fim;
        }
    }
}
