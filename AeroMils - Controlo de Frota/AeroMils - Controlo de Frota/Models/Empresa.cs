using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMils___Controlo_de_Frota.Models
{
    public class Empresa
    {
        private List<IAviao> avioes;

        public Empresa()
        {
            avioes = new List<IAviao>();
        }

        public void AddAviao(IAviao aviao)
        {
            avioes.Add(aviao);
        }

        public List<IAviao> GetAvioes()
        {
            return avioes;
        }
    }
}
