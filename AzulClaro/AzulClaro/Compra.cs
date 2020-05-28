using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzulClaro
{
    public class Compra
    {
        public string tipo { get; set; }
        public int fabrica { get; set; }
        public int azulejo { get; set; }
        public int qtd { get; set; }
        public int modelo { get; set; }
        public int perda { get; set; }

        public Compra() { }
        public Compra(string tipo, int fabrica, int azulejo, int modelo, int qtd)
        {
            this.tipo = tipo;
            this.fabrica = fabrica;
            this.azulejo = azulejo;
            this.modelo = modelo;
            this.qtd = qtd;
        }
    }
}
