using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Jogador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public int pontos { get; set; }
        public bool bot { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public void preencherTabuleiro(int id, string senha)
        {
            this.tabuleiro = new Tabuleiro();
            this.tabuleiro.modelo = new Azulejo[5];
            this.tabuleiro.chao = new List<Azulejo>();
            this.tabuleiro.parede = new bool[5, 5];


            string txt = Jogo.LerTabuleiro(id, senha, this.id);

            txt = txt.Replace("\r", "");//corta o caracter /r do retorno
            string[] txtTabuleiro = txt.Split('\n');//Separa as linhas do retorno

            int l = 1;//Começa em 1 pra pular o texto modelo
            while (txtTabuleiro[l].Substring(0,1) != "p")
            {
                string[] linha = txtTabuleiro[l].Split(',');
                Azulejo a = new Azulejo();
                a.id = Convert.ToInt32(linha[1]);
                a.DefinirCor();
                a.quantidade = Convert.ToInt32(linha[2]);

                this.tabuleiro.modelo[Convert.ToInt32(linha[0]) - 1] = a;
                l++;
            }

            l++; //Pula o texto parede

            while (txtTabuleiro[l].Substring(0,1) != "c")
            {
                string[] linha = txtTabuleiro[l].Split(',');

                this.tabuleiro.parede[Convert.ToInt32(linha[0]) - 1, Convert.ToInt32(linha[1]) - 1] = true;
                l++;
            }

            l++; //Pula o texto chão
     
            while (!txtTabuleiro[l].Equals(""))
            {
                string[] linha = txtTabuleiro[l].Split(',');
                Azulejo a = new Azulejo();
                a.id = Convert.ToInt32(linha[1]);
                a.DefinirCor();

                this.tabuleiro.chao.Add(a);
                l++;
            }
        }
    }
}
