using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace AzulClaro
{
    enum CondPartida : int
    {
        acabou, naoMinhaVez, minhaVez
    }
    public partial class frmTabuleiro : Form
    {
        public string erro { get; set; }
        public int vez { get; set; }
        public Partida partida { get; set; }
        public Jogador jogador { get; set; }
        public Compra compra { get; set; }
        public List<Compra> listaCompras { get; set; }
        public List<Compra> listaCompraColuna { get; set; }
        public bool pausado { get; set; }

        BackgroundWorker workerThread = null;
        

        delegate void Bot();//////////////////


        public frmTabuleiro(Partida partida, Jogador jogador)
        {
            this.partida = partida;
            this.jogador = jogador;
            this.Location = new Point(0, 0);

            InitializeComponent();

            InstantiateWorkerThread();
        }//Construtor: preenche os objetos partida e jogador
        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            lblCabecalho.Text = "Partida: " + partida.nome + "Jogador: " + jogador.id + " " + jogador.nome;

            if (verificaLogin().Equals("ERRO"))//Confere senha do jogador
            {
                this.Close();
                tmrRefresh.Enabled = false;
            }
            else
            {
                //tmrRefresh.Enabled = jogador.bot;

                //Preenche Tudo
                configurarFabricas();
                desenharCentro();
                desenharFabricas();
                desenharTabuleiro();

                workerThread.RunWorkerAsync();
            }
        }//Load do form: Verifica senha e Desenha Tudo
        private void frmTabuleiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            workerThread.CancelAsync();
        }

        /////////////////////////////////////////////////////////////

        public string verificaLogin()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txtF.Equals("")) { return "NAODEUERRO"; }
            else if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);
                this.Close();
                return "ERRO";
            }
            return "NAODEUERRO";
        }//Verifica senha do Jogador

        /////////////////////////////////////////////////////////////

        public void configurarFabricas()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txtF.Equals("")) { }
            else if (txtF == "ERRO:Partida não está em jogo\r\n")
            {
                fimDeJogo();
            }
            else if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);

                this.Close();
                return;
            }
            partida.preencherFabricas(txtF);//Preenche as fábricas do obj partida
           
        }//Configura Texto das fábricas e chama preencher fabricas da partida
        public void desenharFabricas()
        {
            int i;
            int ang = 0;

            definePos(partida.qtdFabricas);

            foreach (Fabrica fab in partida.fabricas) //Para cada fabrica na aprtida
            {
                i = 0; //Qual é o azulejo, vai de 0 a 3
                ang = 0; //Qual o angulo, será usado para definir se fica em cima ou em baixo

                foreach (Azulejo azul in fab.azulejos) //Para cada azulejo da fabrica
                {
                    for (int j = 0; j < azul.quantidade; j++) //Ver a quantidade de azulejos
                    {
                        if (i % 2 == 0) // Ver se é o 1º, 2º, 3º ou 4º e coloca um angulo pra cima ou baixo;
                            ang = 90;
                        else
                            ang = 270;

                        PictureBox pcbAzul = new PictureBox(); //Azulejo
                        pcbAzul.Image = azul.image;
                        int x = fab.x - 60;                    //Pega o centro da fabrica e volta 50
                        if (i > 1) x += 52;                    //Se for o 3º e 4º azulejo, move eles pro lado
                        pcbAzul.Location = new Point(x, fab.y + 26 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 55); //Define a posição do azulejo x -> calculado anteriomente, y -> y da fabrica + ou - sen do ang
                        i++;
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcbAzul.Name = "pcbFabricas" + fab.id + "" + i;

                        pcbAzul.AccessibleName = "F" + fab.id + azul.id + azul.quantidade;//Informações para o carrinho
                        pcbAzul.Click += azulejo_Click;

                        Invoke((MethodInvoker)delegate
                        {
                            this.Controls.Add(pcbAzul);            //Adiciona no form
                            pcbAzul.BringToFront();                //Puxa pra frente
                        });
                        
                    }
                }
            }
        }//Chama definePos e desenha seus azulejos
        public void desenharCentro()
        {
            string txtC;
            txtC = Jogo.LerCentro(jogador.id, jogador.senha);

            if (txtC.Substring(0, 4) == "ERRO")
            {
                this.erro = txtC.Substring(5);
                Close();
                return;
            }

            partida.preencherCentro(txtC);
            //Desenhar centro controla i e j
            //Vai do canto superior esquerdo e somando +50 (altura e largura)
            //Quando atingir um certo numero no horizontal, incrementar 1 na altura e zerar horizontal e ir até acabar
            Point[] points = partida.centro.organizarEmLinhas();
            int w = 0;

            foreach(Azulejo azul in partida.centro.azulejos)
            {
                for(int i = 0; i < azul.quantidade; i++)
                {
                    PictureBox pcbAzul = new PictureBox(); //Azulejo
                    pcbAzul.Image = azul.image;

                    //pcbAzul.Location = new Point(190 + 50 * Xcentro, 265 + 50 * Ycentro);
                    pcbAzul.Location = points[w++];

                    pcbAzul.Width = 50;
                    pcbAzul.Height = 50;
                    pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                    pcbAzul.Name = "pcbCentro" + "" + i;

                    pcbAzul.AccessibleName = "c0" + azul.id + azul.quantidade;//Informações para o carrinho
                    pcbAzul.Click += azulejo_Click;

                    Invoke((MethodInvoker)delegate
                    {
                        this.Controls.Add(pcbAzul);//Adiciona no form
                        pcbAzul.BringToFront();//Puxa pra frente
                    });

                    //if (qtdAzul++ > 4)
                    //{
                    //    Xcentro = 0;
                    //    Ycentro++;
                    //    qtdAzul = 0;
                    //}
                    //else
                    //    Xcentro++;
                }
            }
        }//Configura Texto do centro, chama preencher centro e desenha seus azulejos
        public void desenharTabuleiro()
        {
            jogador.preencherTabuleiro(jogador.id, jogador.senha);
            //C9C4F5

            /* ======= MODELO ======= */
            //superior esquerdo 1 do modelo 1 - 1025,100
            for (int i = 0; i < jogador.tabuleiro.modelo.Length; i++)
            {
                if (jogador.tabuleiro.modelo[i] != null)
                {
                    for (int j = 0; j < jogador.tabuleiro.modelo[i].quantidade; j++)
                    {
                        PictureBox pcbAzul = new PictureBox(); //Azulejo
                        pcbAzul.Image = jogador.tabuleiro.modelo[i].image;
                        pcbAzul.Location = new Point(1025 - 50 * j, 100 + (50 * i));
                        Console.WriteLine(i + " " + jogador.tabuleiro.modelo[i].id + " x= " + (1025 - 50 * j) + " y= " + (100 + 50 * i));
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcbAzul.Name = "pcbModelo" + "" + i + "" + jogador.tabuleiro.modelo[i].id + "" + j;

                        Invoke((MethodInvoker)delegate
                        {
                            this.Controls.Add(pcbAzul);            //Adiciona no form
                            pcbAzul.BringToFront();                //Puxa pra frente
                        });
                    }
                }
            }

            /* ======= PAREDE ======= */
            List<PictureBox> paredeAzs = Controls.OfType<PictureBox>().ToList().Where(az => az.Name.StartsWith("pcbParede")).ToList();
            paredeAzs.Remove(paredeAzs.Find(pcb => pcb.Name.Equals("pcbParede")));

            for(int lp = 0; lp < 5; lp++)
            {
                for(int cp = 0; cp < 5; cp++)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        paredeAzs.Find(azul => azul.Name.Equals("pcbParede" + lp + cp)).Visible = jogador.tabuleiro.parede[lp, cp];
                    });
                }
            }

            /* ======= CHÃO ======= */
            int c = 0;
            foreach (Azulejo azul in jogador.tabuleiro.chao)
            {
                PictureBox pcbAzul = new PictureBox(); //Azulejo
                pcbAzul.Image = azul.image;
                pcbAzul.Location = new Point(715 + 50 * c, 410);
                pcbAzul.Width = 50;
                pcbAzul.Height = 50;
                pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbAzul.Name = "pcbChao" + "" + c;
                c++;

                Invoke((MethodInvoker)delegate
                {
                    this.Controls.Add(pcbAzul);            //Adiciona no form
                    pcbAzul.BringToFront();                //Puxa pra frente
                });
                
            }
        }
        public void definePos(int qtd)
        {
            int[] posX = { }; //Array dos Xs dos centros das fabricas
            int[] posY = { }; //Array dos Ys dos centros das fabricas
            switch (qtd)
            {
                case 5:
                    pcbFabricas.Image = Properties.Resources.f5; //5 fabricas
                    posX = new int[] { 345, 577, 505, 183, 113 };
                    posY = new int[] { 185, 397, 667, 667, 397 };
                    break;
                case 7:
                    pcbFabricas.Image = Properties.Resources.f7; //7 fabricas
                    posX = new int[] { 345, 555, 590, 460, 230, 103, 135 };
                    posY = new int[] { 185, 290, 505, 665, 665, 505, 290 };
                    break;
                case 9:
                    pcbFabricas.Image = Properties.Resources.f9; //9 fabricas
                    posX = new int[] { 345, 518, 592, 574, 426, 245, 122, 102, 174 };
                    posY = new int[] { 175, 223, 388, 548, 672, 672, 548, 388, 223 };
                    break;
            }

            //Define as posições    
            for (int i = 0; i < qtd; i++)
            {
                partida.fabricas[i].x = posX[i];
                partida.fabricas[i].y = posY[i];
            }
        }//Define a posição das fábricas

        /////////////////////////////////////////////////////////////

        public void atualizarAzulejos()
        {
            tirarAzulejos();

            configurarFabricas();
            desenharCentro();
            desenharFabricas();
            desenharTabuleiro();
        }//Função que tira os azulejos da tela a coloca de novo
        public void tirarAzulejos()
        {
            List<PictureBox> pcbs = Controls.OfType<PictureBox>().Where(pcb => pcb.Name.StartsWith("pcbFabricas") || pcb.Name.StartsWith("pcbModelo") || pcb.Name.StartsWith("pcbChao") || pcb.Name.StartsWith("pcbCentro")).ToList();

            pcbs.Remove(pcbs.Find(pcb => pcb.Name.Equals("pcbFabricas"))); //Remove o PictureBox do fundo (Fabricas)

            for (int i = 0; i < pcbs.Count; i++)
            {
                Invoke((MethodInvoker)delegate
                {
                    Controls.Remove(pcbs[i]);//Remove do Form
                    pcbs[i].Image = null;//Deixa null a PictureBox
                    pcbs[i] = null;
                });
            }
            //pcbs = null;
            GC.Collect();
        }//Tira os PictureBoxes dos azulejos da tela e atribui null a eles (e torce para o GC fazer o resto);
        public void listarPontos()
        {
            string txt = Jogo.ListarJogadores(partida.id);
            Invoke((MethodInvoker)delegate
            {
                lblPontos.Text = txt;
            });
        }

        /////////////////////////////////////////////////////////////
        public void Jogar(Compra c)
        {
            string txt = Jogo.Jogar(jogador.id, jogador.senha, c.tipo, c.fabrica, c.azulejo, c.modelo);
            Invoke((MethodInvoker)delegate
            {
                lblErro.Text = txt;
            });
            atualizarAzulejos();
        }//Manda um pedido de compra

        /////////////////////////////////////////////////////////////

        private void btnVez_Click(object sender, EventArgs e)
        {
            lblVez.Text = Jogo.VerificarVez(jogador.id, jogador.senha);
        }//Botão Vez: printa a vez
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            jogarAutomatico();
            atualizarAzulejos();
        }//Recarrega azulejos (REMOVER)        
        private void azulejo_Click(object sender, EventArgs e)
        {
            compra = new Compra();//Instacia o objeto compra

            PictureBox pcb = (PictureBox)sender;//Recebe a picturebox que mandou o evento

            //Preence o objeto compra
            compra.tipo = pcb.AccessibleName.Substring(0,1);
            compra.fabrica = Convert.ToInt32(pcb.AccessibleName.Substring(1, 1));
            compra.azulejo = Convert.ToInt32(pcb.AccessibleName.Substring(2, 1));
            compra.qtd = Convert.ToInt32(pcb.AccessibleName.Substring(3, 1));

            string cor = Azulejo.LembraCor(compra.azulejo, compra.qtd > 1);//Pega a cor na função da classe azulejo, essa comparação diz se é plural ou não
            string azu = "azulejo";//Pego o plural ou o singular de Azulejos
            if (compra.qtd > 1)
                azu += "s";
            string dx;//Vê se a compra é da fábrica ou do centro
            if (compra.tipo == "F")
                dx = "da fábrica " + compra.fabrica;
            else
                dx = "do centro";

            lblCompra.Text = "Compra: " + compra.qtd + " " + azu + " " + cor + " " + dx;//Escreve a corrinho de compras na tela

        }//Clique em um azulejo das fábricas e centro: adiciona o azulejo no carrinho     
        private void btnModelo1_Click(object sender, EventArgs e)
        {
            compra.modelo = 1;
            //Jogar();
        }//Botão modelo 1: Chama jogar mandando 1 como modelo
        private void btnModelo2_Click(object sender, EventArgs e)
        {
            compra.modelo = 2;
            //Jogar();
        }//Botão modelo 2: Chama jogar mandando 2 como modelo
        private void btnModelo3_Click(object sender, EventArgs e)
        {
            compra.modelo = 3;
            //Jogar();
        }//Botão modelo 3: Chama jogar mandando 3 como modelo
        private void btnModelo4_Click(object sender, EventArgs e)
        {
            compra.modelo = 4;
            //Jogar();
        }//Botão modelo 4: Chama jogar mandando 4 como modelo
        private void btnModelo5_Click(object sender, EventArgs e)
        {
            compra.modelo = 5;
            //Jogar();
        }//Botão modelo 5: Chama jogar mandando 5 como modelo
        
        /////////////////////////////////////////////////////////////
        
        //Dicionário (principal) que guarda <Quantidade de azulejos que quer, DicionarioCor>  ----> DicionarioCor<Id do azulejo (Cor) , Lista de compras possíveis >
        Dictionary<int, Dictionary<int, List<Compra>>> azulPorQtd;
        //Para recuperar um valor (Lista de compras) desse monstrinho usar tipo matriz azulPorQtd[Int de quantidade][Int de cor]

        private CondPartida verVez()
        {
            string txt = Jogo.VerificarVez(jogador.id, jogador.senha);

            string[] v = txt.Split(',');
            this.vez = Convert.ToInt32(v[1]);
            if (v[0].Equals("E"))
                return CondPartida.acabou;
            else if (this.vez == jogador.id)
                return CondPartida.minhaVez;
            else
                return CondPartida.naoMinhaVez;
        }
        private void jogarAutomatico()
        {
            compra = new Compra();

            atualizarAzulejos();
            separaPorQuantidade();

            //Analisa os modelos e diz se falta algo para completa-los
            listaCompras = new List<Compra>();
            listaComprasModelos();
            listaComprasModelosVazios();

            listaCompras = listaCompras.OrderByDescending(l => l.qtd).ToList();

            //Analisar os azulejos das fabricas
            //ver em qual modelo não tem nada, cabe ou completa
            //ou 
            //Ver as linhas do modelo e ver qual dos azulejos das fabricas
            //cabe(m) ou completa(m)
            if (semOpcaoCores())
            {
                //azulPorQtd[3][1].
                //Aqui vc é obrigado a comprar pro chão, buscas a compra menos pior
                for(int qtd = 1; qtd <= 6; qtd++)
                {
                    for(int cor = 1; cor <= 5; cor++)
                    {
                        if (azulPorQtd[qtd][cor].Count > 0)
                        {
                            azulPorQtd[qtd][cor].First().modelo = 0;
                            Jogar(azulPorQtd[qtd][cor].First());
                            return;
                        }
                    }
                }
            }

            //int[] maisComum = corMaisComum();

            //if (maisComum[1] > 5)
            //{
            //    for (int qtd = 5; qtd < 0; qtd--)
            //    {
            //        if (azulPorQtd[qtd][maisComum[0]].Count > 0)
            //        {
            //            compra.fabrica = azulPorQtd[c.qtd][c.azulejo].First().fabrica;
            //            compra.tipo = azulPorQtd[c.qtd][c.azulejo].First().tipo;
            //            compra.azulejo = c.azulejo;
            //            compra.qtd = c.qtd;
            //            compra.modelo = c.modelo;
            //            Jogar();
            //            return;
            //        }
            //        else
            //        {
            //            for (int i = 0; i < 5; i++)
            //            {
            //                compra.fabrica = azulPorQtd[c.qtd][c.azulejo].First().fabrica;
            //                compra.tipo = azulPorQtd[c.qtd][c.azulejo].First().tipo;
            //                compra.azulejo = c.azulejo;
            //                compra.qtd = c.qtd;
            //                compra.modelo = c.modelo;
            //                Jogar();
            //                return;
            //            }
            //        }
            //    }
            //}
            if(listaCompraColuna.Count > 0)
            {
                foreach (Compra c in listaCompraColuna)//Compra comum
                {
                    if (azulPorQtd[c.qtd][c.azulejo].Count > 0)
                    {
                        Compra com = new Compra(azulPorQtd[c.qtd][c.azulejo].First().tipo, azulPorQtd[c.qtd][c.azulejo].First().fabrica, c.azulejo, c.modelo, c.qtd);
                        Jogar(com);
                        return;
                    }
                }
            }

            foreach (Compra c in listaCompras)//Compra comum
            {
                if (azulPorQtd[c.qtd][c.azulejo].Count > 0)
                {
                    Compra com = new Compra(azulPorQtd[c.qtd][c.azulejo].First().tipo, azulPorQtd[c.qtd][c.azulejo].First().fabrica, c.azulejo, c.modelo, c.qtd);
                    Jogar(com);
                    return;
                }
            }
        

            if (jogaComOqTem())
            {
                return;
            }                

            lidaComABaldada();

            //jogador.tabuleiro.modelo 000000000000000000000000 listaCompras.OrderBy(l => l.qtd);
        }
        private void listaComprasModelos()
        {
            for (int i = 0; i < 5; i++)
            {
                if (jogador.tabuleiro.verificaSeLinhaPreenchidaNaoCompleta(i))//confere se a linha tá prenchida mas não completa
                {
                    int qtd = (i + 1) - jogador.tabuleiro.modelo[i].quantidade;
                    while (qtd >= 1)
                    {
                        Compra compra = new Compra();
                        compra.azulejo = jogador.tabuleiro.modelo[i].id;
                        compra.modelo = i+1;
                        compra.qtd = qtd;
                        listaCompras.Add(compra);

                        qtd--;
                    }

                    Invoke((MethodInvoker)delegate
                    {
                        textBox1.Text += compra.qtd.ToString() + Azulejo.LembraCor(compra.azulejo, false) + " modelo " + (i + 1).ToString() + "\r\n";
                    });
                    
                }
            }
        }//Busca Linhas de Modelo incompletas
        private void listaComprasModelosVazios()
        {
            listaCompraColuna = new List<Compra>();
            for (int l = 0; l < 5; l++)
            {
                Compra MelhorCorLinha = new Compra();

                if (jogador.tabuleiro.verificaSeLinhaVazia(l))
                {
                    int maisPontos = 0;
                    for (int c = 0; c < 5; c++)
                    {
                        
                        if (!jogador.tabuleiro.parede[l,c])
                        {
                            int p = checarPontosAzul(l, c);
                            if(p >= 10)
                            {
                                MelhorCorLinha.azulejo = Azulejo.VerCorNaParede(l, c);


                                MelhorCorLinha.modelo = l + 1;
                                MelhorCorLinha.qtd = l + 1;

                                int qtdColuna = MelhorCorLinha.qtd;
                                while (qtdColuna+3 >= 1)
                                {
                                    Compra com = new Compra();
                                    com.azulejo = MelhorCorLinha.azulejo;
                                    com.modelo = MelhorCorLinha.modelo;
                                    com.qtd = qtdColuna;
                                    listaCompraColuna.Add(com);
                                    qtdColuna--;
                                }
                            }

                            if (p >= maisPontos)
                            {
                                maisPontos = p;


                                MelhorCorLinha.azulejo = Azulejo.VerCorNaParede(l, c);


                                MelhorCorLinha.modelo = l +1;
                                MelhorCorLinha.qtd = l + 1;

                            }
                        }
                    }
                    int qtd = MelhorCorLinha.qtd;
                    while (qtd >= 1)
                    {
                        Compra c = new Compra();
                        c.azulejo = MelhorCorLinha.azulejo;
                        c.modelo = MelhorCorLinha.modelo;
                        c.qtd = qtd;
                        listaCompras.Add(c);
                        qtd--;
                    }

                    Invoke((MethodInvoker)delegate
                    {
                        textBox1.Text += Azulejo.LembraCor(MelhorCorLinha.azulejo, false) + " modelo " + (l + 1).ToString() + "\r\n";
                    });
                    
                }
            }
        }//Busca a melhor cor pra cada linha de modelo vazia
        private int checarPontosAzul(int linha, int coluna)
        {
            int pontos = 1;
            int vizinhos = 0;
            bool conectado = false;
            int pontosLinha = 0;

            for (int i = 0; i < 5; i++)//Checa os pontos na linha
            {
                if (i < coluna)
                {
                    if (jogador.tabuleiro.parede[linha, i])
                    {
                        vizinhos++;
                    }
                    else
                    {
                        vizinhos = 0;
                    }
                }
                else if (i == coluna)
                {
                    pontos += vizinhos;
                    vizinhos = 0;
                    conectado = true;
                }
                else if (i > coluna)
                {
                    if (jogador.tabuleiro.parede[linha, i])
                    {
                        vizinhos++;
                        if (conectado && i == 4)//Verifica se os vizinhos do final estão conectados ao azulejo  //i == 4 && vizinhos == 4 - coluna
                        {
                            pontos += vizinhos;
                        }
                    }
                    else
                    {
                        if (conectado)
                            pontos += vizinhos;
                        
                        vizinhos = 0;
                        conectado = false;
                    }
                }
            }

            conectado = false;
            vizinhos = 0;
            pontosLinha = pontos;

            for (int i = 0; i < 5; i++)//Checa os pontos na coluna
            {
                if (i < linha)
                {
                    if (jogador.tabuleiro.parede[i, coluna])
                    {
                        vizinhos++;
                    }
                    else
                    {
                        vizinhos = 0;
                    }
                }
                else if (i == linha)
                {
                    pontos += vizinhos;
                    conectado = true;
                    vizinhos = 0;
                }
                else if (i > linha)
                {
                    if (jogador.tabuleiro.parede[i, coluna])
                    {
                        vizinhos++;
                        if (conectado && i == 4) //i == 4 && vizinhos == 4 - linha
                        {
                            pontos += vizinhos;
                        }
                    }
                    else
                    {
                        if(conectado)
                            pontos += vizinhos;

                        vizinhos = 0;
                        conectado = false;
                    }
                }
            }

            if (pontos - pontosLinha >= 4) pontos += 10;

            return pontos;
        }//Diz quantos pontos a linha vai fazer


        //private void completaCor()
        //{
        //    for (int cor = 0; cor < 5; cor++)
        //    {
        //        int qtd = 0;
        //        int linhaModelo = 0;
        //        for (int l = 0; l < 5; l++)
        //        {
        //            if (jogador.tabuleiro.parede[l, checaPos(l, cor)])
        //            {
        //                qtd++;
        //            }
        //            else { linhaModelo = l; }
        //        }
        //        if (qtd == 4)
        //        {
        //            cor++;
        //            linhaModelo = linhaModelo;
        //            //eu tenho a cor e a linha que falta
        //        }


        //        //bool a0 = parede[0,checaPos(0,cor)];
        //        //bool a1 = parede[1,checaPos(1,cor)];
        //        //bool a2 = parede[2,checaPos(2,cor)];
        //        //bool a3 = parede[3,checaPos(3,cor)];
        //        //bool a4 = parede[4,checaPos(4,cor)];
        //    }
        //}

        private bool completaCor(int l, int c)
        {
            int cor = Azulejo.VerCorNaParede(l, c);
                
            int qtd = 0;
            //int linhaModelo = 0;
            for (int i = 0; i < 5; i++)
            {
                if (jogador.tabuleiro.parede[i, checaPos(i, cor-1)])
                {
                    qtd++;
                }
            }

            if (qtd == 4)
            {
                return true;
            }

            return false;
            
        }

        private int checaPos(int pos, int cons)
        {
            if ((pos + cons) <= 4)
            {
                return (pos + cons);
            }
            else
            {
                return ((pos + cons) - 5);
            }
        }

        private int[] corMaisComum()
        {
            int[] cores = new int[5];
            int[] aux = new int[5];

            foreach (Fabrica fabrica in partida.fabricas)
            {
                foreach (Azulejo azulejo in fabrica.azulejos)
                {
                    cores[azulejo.id - 1] += azulejo.quantidade;
                }
            }

            foreach (Azulejo azulejo in this.partida.centro.azulejos)
            {
                cores[azulejo.id - 1] += azulejo.quantidade;
            }

            aux = (int[])cores.Clone();
            Array.Sort(cores);
            for (int i = 0; i < 5; i++)
            {
                cores[i] = Array.IndexOf(aux, cores[i]);
                aux[cores[i]] = 42;
            }

            return cores;
        }
        private bool semOpcaoCores()
        {
            List<int> Ids = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                if(jogador.tabuleiro.verificaSeLinhaVazia(i))//Verifica as linhas vazias se ela pode colocar alguma das cores a venda
                {
                    for (int cor = 1; cor < 6; cor++)
                    {
                        if (partida.CorDisponível(cor))
                        {
                            if(jogador.tabuleiro.podeColocar(cor, i))
                            {
                                return false;
                            }
                        }
                    }                    
                }
                
                if (jogador.tabuleiro.verificaSeLinhaPreenchidaNaoCompleta(i))//Verifica as cores usadas nas linhas preenchidas não completas
                {
                    if (partida.CorDisponível(jogador.tabuleiro.modelo[i].id))
                    {
                        return false;
                    }

                }
            }

            return true;

        }//Diz se você tem ainda como comprar algo
        private bool jogaComOqTem()
        {
            // partida.fabricas;
            // partida.centro;
            List<Compra> lc = new List<Compra>();

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(azulPorQtd[i][j].Count > 0)
                    {
                        lc.Add(azulPorQtd[i][j].First());
                    }
                }
            }

            List<Compra> lcFiltrada = new List<Compra>();

            for (int l = 4; l >= 0; l--)
            {
                foreach (Compra c in lc)
                {
                    if (jogador.tabuleiro.verificaSeLinhaPreenchidaNaoCompleta(l) && jogador.tabuleiro.modelo[l].id == c.azulejo || jogador.tabuleiro.verificaSeLinhaVazia(l) && jogador.tabuleiro.podeColocar(c.azulejo, l))
                    {
                        Compra c2 = new Compra();
                        c2.fabrica = c.fabrica;
                        c2.tipo = c.tipo;
                        c2.azulejo = c.azulejo;
                        c2.qtd = c.qtd;
                        c2.modelo = l + 1;
                        int qtdNoModelo;
                        if (jogador.tabuleiro.verificaSeLinhaVazia(l))
                        {
                            qtdNoModelo = 0;
                        }
                        else
                        {
                            qtdNoModelo = jogador.tabuleiro.modelo[l].quantidade;
                        }
                        c2.perda = (l + 1) - qtdNoModelo - c.qtd;
                        lcFiltrada.Add(c2);
                        //Jogar();
                        //return true;
                    }
                }
            }

            lcFiltrada = lcFiltrada.OrderBy(h => h.perda).ToList();

            if (lcFiltrada.Count > 0)
            {
                List<Compra> lista = new List<Compra>();
                lista = lcFiltrada.Where(y => y.perda == 0).ToList();

                if (lista.Count > 0)
                {
                    Jogar(lista.First());
                    return true;
                }

                for (int i = -1; i < -3; i--)
                {
                    lista = new List<Compra>();
                    lista = lcFiltrada.Where(y => y.perda == i).ToList();
                    if (lista.Count > 0)
                    {
                        Jogar(lista.First());
                        return true;
                    }
                }

                for (int i = 1; i <= 3; i++)
                {
                    lista = new List<Compra>();
                    lista = lcFiltrada.Where(y => y.perda == i).ToList();
                    if (lista.Count > 0)
                    {
                        Jogar(lista.First());
                        return true;
                    }
                }

                Jogar(lcFiltrada.First());
                return true;
            }
            else
            {
                return false;
            }                
        }
        private void lidaComABaldada()
        {
            List<Compra> baldadas = new List<Compra>();

            for (int i = 1; i < 6; i++)
            {

                if (azulPorQtd[6][i].Count > 0)
                {
                    baldadas.Add(azulPorQtd[6][i].First());
                }

            }

            baldadas = baldadas.OrderBy(l => l.qtd).ToList();

            foreach (Compra baldada in baldadas)
            {
                for (int i = 4; i >= 0; i--)
                {
                    if (jogador.tabuleiro.verificaSeLinhaVazia(i) && jogador.tabuleiro.podeColocar(baldada.azulejo, i)) 
                    {
                        Compra c = new Compra(baldada.tipo, baldada.fabrica, baldada.azulejo, (i + 1), baldada.qtd);
                        Jogar(c);
                        return;
                    }
                    if (jogador.tabuleiro.verificaSeLinhaPreenchidaNaoCompleta(i) && jogador.tabuleiro.modelo[i].id == baldada.azulejo)
                    {
                        Compra c = new Compra(baldada.tipo, baldada.fabrica, baldada.azulejo, (i + 1), baldada.qtd);
                        Jogar(c);
                        return;
                    }

                }
            }
        }

        /////////////////////////////////////////////////////////////

        private void InstantiateWorkerThread()
        {
            workerThread = new BackgroundWorker();
            workerThread.DoWork += WorkerThread_DoWork;
            workerThread.WorkerSupportsCancellation = true;
        }
        private void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!pausado)
            {
                Thread.Sleep(1000);

                CondPartida est = verVez();
                if (est == CondPartida.acabou)
                {                    
                    fimDeJogo();                    
                }
                else if (est == CondPartida.minhaVez)
                {
                    jogarAutomatico();
                    listarPontos();
                }

                if (workerThread.CancellationPending)
                {
                    // this is important as it set the cancelled property of RunWorkerCompletedEventArgs to true
                    e.Cancel = true;
                    break;
                }
            }
        }
        private void fimDeJogo()
        {
            Invoke((MethodInvoker)delegate
            {
                textBox1.Text = " ACABOU É TETRA\r\n";
                string txt = Jogo.ListarJogadores(partida.id);
                textBox1.Text += txt;
                pausado = true;
            });
        }

        /////////////////////////////////////////////////////////////

        //Pega os valores de partida.centro e partida.fabricas e separa em listas por quantidade
        void separaPorQuantidade()
        {
            azulPorQtd = new Dictionary<int, Dictionary<int, List<Compra>>>();

            //Para a quantidade padrão de azulejos que cabem no modelo ( de 1 a 5 )
            for (int quatidadeDeAzulejosPorFabrica = 1; quatidadeDeAzulejosPorFabrica <= 5; quatidadeDeAzulejosPorFabrica++)
            {
                //Pega os azulejosId e fabricasId com determinda quantidade
                var centro1 = (from cen in partida.centro.azulejos where cen.quantidade == quatidadeDeAzulejosPorFabrica select new { fabId = 0, azulId = cen.id, qtd = cen.quantidade }).ToList();
                var fabs1 = (from fabs in partida.fabricas
                             from azs in fabs.azulejos
                             where azs.quantidade == quatidadeDeAzulejosPorFabrica
                             select new { fabId = fabs.id, azulId = azs.id, qtd = azs.quantidade }).ToList();

                //Lista de compras possiveis
                List<Compra> listCompra = new List<Compra>();

                //Trata os valores recebidos e adiciona na lista de compras possiveis
                foreach (var a in centro1)
                {
                    Compra compra = new Compra();
                    compra.fabrica = a.fabId;
                    compra.azulejo = a.azulId;
                    compra.qtd = a.qtd;
                    compra.tipo = "c";

                    // compra.modelo
                    listCompra.Add(compra);
                }

                //Trata os valores recebidos e adiciona na lista de compras possiveis
                foreach (var a in fabs1)
                {
                    Compra compra = new Compra();
                    compra.fabrica = a.fabId;
                    compra.azulejo = a.azulId;
                    compra.qtd = a.qtd;
                    compra.tipo = "f";
                    // compra.modelo
                    listCompra.Add(compra);
                }

                //pega a lista de compras possiveis e separa elas por cor para colocar no dicionario principal
                separaPorCor(quatidadeDeAzulejosPorFabrica, listCompra);
            }

            var centro6Mais = (from cen in partida.centro.azulejos where cen.quantidade > 5 select new { fabId = 0, azulId = cen.id, qtd = cen.quantidade }).ToList();
            List<Compra> listCompra6 = new List<Compra>();
            foreach (var a in centro6Mais)
            {
                Compra compra = new Compra();
                compra.fabrica = a.fabId;
                compra.azulejo = a.azulId;
                compra.qtd = a.qtd;
                compra.tipo = "c";

                // compra.modelo
                listCompra6.Add(compra);
            }
            //pega a lista de compras possiveis e separa elas por cor para colocar no dicionario principal
            separaPorCor(6, listCompra6);
        }

        //Recebe a quantidade e a lista de compras separadas por quantidade e 
        //Adiciona no DicionarioCor<Id do azulejo (Cor) , Lista de compras possíveis > no id do azulejo a lista de compras com aquela quantidade e cor
        void separaPorCor(int quatidadeDeAzulejosPorFabrica, List<Compra> listCompra)
        {
            //DicionarioCor<Id do azulejo (Cor) , Lista de compras possíveis >
            Dictionary<int, List<Compra>> azulPorCor = new Dictionary<int, List<Compra>>();

            //Para cada cor dos azulejos
            for(int i = 1; i <= 5; i++)
            {
                azulPorCor.Add(i,listCompra.Where(c => c.azulejo == i).ToList());
            }

            //Adiciona no dicionario principal
            azulPorQtd.Add(quatidadeDeAzulejosPorFabrica, azulPorCor);
        }        
    }
}


//O porquê do cos(270) retornar -1
//https://stackoverflow.com/questions/9652695/why-does-math-cos90-math-pi-180-yield-6-123031769111-and-not-zero
//https://stackoverflow.com/questions/6082632/math-cos-math-sin-in-c-sharp
/* Define posição antigo, deixava os azulejos em cruz
           pcbAzul.Location = new Point(fab.x + 50 * Convert.ToInt32(Math.Round(Math.Cos((ang * Math.PI)/180))), fab.y + 50 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 50);
           ang += 90;
*/
