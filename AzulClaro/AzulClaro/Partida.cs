using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string status { get; set; }
        public int qtdFabricas { get; set; }

        public List<Jogador> jogadores { get; set; }
        public List<Fabrica> fabricas { get; set; }
        public Centro centro { get; set; }

        public static List<Partida> ListarPartidas(string status) {

            List<Partida> partidas = new List<Partida>();

            string txt = Jogo.ListarPartidas(status);//Recebe todas as partidas filtrando pelo status

            txt = txt.Replace("\r", "");//corta o caracter /r do retorno
            string[] txtPartidas = txt.Split('\n');//Separa as linhas do retorno

            foreach (string txtPartida in txtPartidas)//preenche a combo box
            {
                if (txtPartida != "")//Resolve o bug do elemento fantasma no fim
                {
                    Partida partida = new Partida();

                    string[] txtPicotado = txtPartida.Split(',');

                    partida.id = Convert.ToInt32(txtPicotado[0]);
                    partida.nome = txtPicotado[1];
                    partida.status = txtPicotado[3];
                    //partida.ListarJogadores();

                    partidas.Add(partida);
                }
            }

            return partidas;
        }

        public void ListarJogadores()
        {
            this.jogadores = new List<Jogador>();
            string txt = Jogo.ListarJogadores(this.id);//Recebe todas as partidas filtrando pelo status
            txt = txt.Replace("\r", "");//corta o caracter /r do retorno
            string[] jogadores = txt.Split('\n');//Separa as linhas do retorno              

            foreach (string jogador in jogadores)//preenche a lista de jogadores
            {
                if (jogador != "")//Resolve o bug do elemento fantasma no fim
                {
                    string[] jogadorFormatado = jogador.Split(',');//Separa cada elemento do jogador

                    Jogador j = new Jogador();//Cria os jogadores que vão ser inseridos no Objeto Partida
                    j.id = Convert.ToInt32(jogadorFormatado[0]);//Preenche os Objetos
                    j.nome = jogadorFormatado[1];
                    j.pontos = Convert.ToInt32(jogadorFormatado[2]);

                    this.jogadores.Add(j);//Adiciona os objetos na partida                        
                }
            }

            this.qtdFabricas = (this.jogadores.Count * 2) + 1;
        }

        public void preencherFabricas(string txt)
            {
                this.fabricas = new List<Fabrica>();
                txt = txt.Replace("\r", "");//corta o caracter /r do retorno
                string[] fabs = txt.Split('\n');//Separa as linhas do retorno    

                fabs = fabs.Take(fabs.Count() - 1).ToArray();//Remove o elemento fantasma
                
                int p = 0;

                for (int i = 1; i <= this.qtdFabricas; i++)//Controla as fábricas
                {
                    Fabrica fabrica = new Fabrica();
                    fabrica.azulejos = new List<Azulejo>();
                    fabrica.id = i;

                    while (p != fabs.Length && i == Convert.ToInt32(fabs[p].Substring(0, 1)))//Controla o azulejo
                    {
                        Azulejo azul = new Azulejo();
                        azul.id = Convert.ToInt32(fabs[p].Substring(2, 1));
                        azul.quantidade = Convert.ToInt32(fabs[p].Substring(fabs[p].Length - 1, 1));//Lê o último caractere e pega a quantidade

                        azul.DefinirCor();//Define a imagem do Azulejo                        

                        p++;

                        fabrica.azulejos.Add(azul);
                    }

                    //Definir o x y das fábricas aqui

                    this.fabricas.Add(fabrica);
                }
            }

        public void preencherCentro(string txt)
        {
            this.centro = new Centro();
            txt = txt.Replace("\r", "");//corta o caracter /r do retorno
            string[] cent = txt.Split('\n');//Separa as linhas do retorno   

            this.centro.azulejos = new List<Azulejo>();

            cent = cent.Take(cent.Count() - 1).ToArray();//Remove o elemento fantasma

            string[] checa1 = cent[0].Split(',');

            if(Convert.ToBoolean(Convert.ToInt16(checa1[3])))
            {
                Azulejo a = new Azulejo();
                a.id = 0;
                a.quantidade = 1;
                //this.centro.marca1 = Convert.ToBoolean(Convert.ToInt16(itens[3]));
                a.DefinirCor();
                this.centro.azulejos.Add(a);
            }

            for (int i = 0; i < 5; i++)
            {
                string[] itens = cent[i].Split(',');
                Azulejo a = new Azulejo();
                a.id = Convert.ToInt32(itens[0]);
                a.quantidade = Convert.ToInt32(itens[2]);
                //this.centro.marca1 = Convert.ToBoolean(Convert.ToInt16(itens[3]));
                a.DefinirCor();
                this.centro.azulejos.Add(a);
            }

        }

        public bool CorDisponível(int id)
        {

            foreach (Fabrica fabrica in this.fabricas)
            {
                foreach (Azulejo azulejo in fabrica.azulejos)
                {
                    if (azulejo.id == id)
                    {
                        return true;
                    }
                }
            }

            foreach (Azulejo azulejo in this.centro.azulejos)
            {
                if (azulejo.id == id && azulejo.quantidade > 0)
                {
                    return true;
                }
            }

            return false;


        }//Vê se tal cor está disponível        
    }
}
