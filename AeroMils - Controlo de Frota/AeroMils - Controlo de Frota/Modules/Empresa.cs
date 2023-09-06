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

        public Empresa()
        {
            avioes = new List<Aviao>();
        }

        public void AddAviao(Aviao aviao)
        {
            avioes.Add(aviao);
        }

        public List<Aviao> GetAvioes()
        {
            return avioes;
        }
    }
}
