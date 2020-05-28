using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Tabuleiro
    {
        public bool[,] parede { get; set; }
        public Azulejo[] modelo { get; set; }
        public List<Azulejo> chao { get; set; }        

        public bool verificaSeLinhaVazia(int i)
        {
            return this.modelo[i] == null ||this.modelo[i].quantidade == 0;
        }

        public bool verificaSeLinhaPreenchidaNaoCompleta(int i)
        {
            return this.modelo[i] != null && this.modelo[i].quantidade > 0 && this.modelo[i].quantidade != i + 1;
        }

        public bool podeColocar(int azulejo, int modelo)
        {

            for (int i = 0; i < 5; i++)
            {
                if (this.parede[modelo, i])
                {
                    if (azulejo == Azulejo.VerCorNaParede(modelo, i))
                        return false;
                }
            }
            return true;
        }

        public int corMaisComum()
        {
            //int[] cores = new int[5];
            return 1;
        }
    }
}
