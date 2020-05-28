using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace AzulClaro
{
    public partial class frmLobby : Form
    {
        Partida partida;//Objeto partida. Será usado para desenhar o jogo
        Jogador jogador;//Objeto jogador. Será usado para jogar

        public frmLobby()
        {
            InitializeComponent();            

            lblVersao.Text = "Versão: " + Jogo.Versao;//Exibe a versão da dll            

            ListarPartidas();//Já inicia o cliente com as partidas preenchidas

            lblErroIniciar.Text = "";
            lblErroEntrarPartida.Text = "";

            //Configura a DataGridView
            dgvPartidas.RowHeadersVisible = false;
            dgvPartidas.ReadOnly = true;
            dgvPartidas.Columns[0].Visible = false;
            dgvPartidas.Columns[1].Width = 135;
            dgvPartidas.Columns[2].Width = 57;
            dgvPartidas.Columns[3].Visible = false;
            dgvPartidas.Columns[4].Visible = false;
            dgvPartidas.AllowUserToResizeRows = false;
            dgvPartidas.AllowUserToResizeColumns = false;
            dgvPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartidas.MultiSelect = false;
            dgvPartidas.Font = new Font("Bahnschrift Light", 12);
            dgvPartidas.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#A9AFBA"); 
            dgvPartidas.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#949AA3"); 

            //gvwPartidas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //gvwPartidas.Columns[4].Width = 100;
            //gvwPartidas.Columns[5].Width = 75;
        }//Configura as lbls e a dgv

        /////////////////////////////////////////////////////////////

        public void ListarPartidas()
        {
            string status = "";
            if (rdbTodos.Checked)
                status = "T";
            else if (rdbAbertas.Checked)
                status = "A";
            else
                status = "E";

            dgvPartidas.DataSource = Partida.ListarPartidas(status);

            /*if (dgvPartidas.Rows.Count > 0)
            {
                dgvPartidas.Rows[0].Selected = true;//Seleciona a linha mais nova
                partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
                txtIdPartida.Text = partida.id.ToString();
                ListarJogadores();
            }*/

        }//Lista partidas, preenche o dgv, preenche o objeto partida e lista os jogadores da partida 1
        public void ListarJogadores()
        {
            lstJogadores.Items.Clear();//Limpa a combo box para preencher novamente
            if (partida != null)
            {
                partida.ListarJogadores();
            }            

            bool existe = false;
            foreach (Jogador jogador in partida.jogadores)
            {
                existe = true;
                lstJogadores.Items.Add(jogador.nome);//Adiciona os textos na List Box
            }
            if (!existe)
            {
                lstJogadores.Items.Add("[Sem Jogadores]");
            }
        }//Lista os jogadores do objeto partida e Preenche a lst Jogadores

        /////////////////////////////////////////////////////////////

        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            txtIdPartida.Text = partida.id.ToString();
            ListarJogadores();
            if (partida.status == "A")
            {
                lblIniciarPartida.Text = "Iniciar Partida";
            }
            else
            {
                lblIniciarPartida.Text = "Abrir Tabuleiro";
            }
        }//Clicar na DataGridView: troca o objeto partida

        /////////////////////////////////////////////////////////////             

        private void btnListPartidas_Click(object sender, EventArgs e)
        {
            ListarPartidas();//Só chama essa função para ela poder ser acessada por outros lugares
            txtIdPartida.Text = "";
            txtSenhaEntrar.Text = "";
            lstJogadores.Items.Clear();
            partida = null;
        }//Clicar em Listar Partida: Lista as partidas e limpa os campos   
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            this.Opacity = 25.0;
            frmCriarPartida frmCriarPartida = new frmCriarPartida();//Chama o formulário de nova partida
            frmCriarPartida.ShowDialog();
            int IdPartidaCriada = frmCriarPartida.idPartidaCriada;//Lê o id e a senha criada nesse form    
            string senha = frmCriarPartida.senha;
            this.Opacity = 100.0;

            ListarPartidas();//Atualiza as partidas

            if (IdPartidaCriada != 0)
            {
                txtSenhaEntrar.Text = senha;//Coloca a senha da partida criada no campo de senha para jogar

                dgvPartidas.Rows[dgvPartidas.Rows.Count - 1].Selected = true;//Seleciona a linha mais nova

                partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
                txtIdPartida.Text = partida.id.ToString();
                ListarJogadores();
            }


        }//Botão Criar Partida: Chama o formulário de nova partida, Atualiza as partidas e preenche algumas coisas       
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if (txtIdPartida.Text != "")//Confere se o Id está preenchido
            {
                string txt;
                string[] txtRecortado;
                int id = Convert.ToInt32(txtIdPartida.Text);//Lê os dados requeridos para entrar na partida
                string nome = txtNomeJogador.Text;
                string senha = txtSenhaEntrar.Text;
                if (nome != "" && senha != "")//Tenta adicionar o jogador
                {
                    txt = Jogo.EntrarPartida(id, nome, senha);//Cria o jogador e lê see Id e senha

                    if (txt.Substring(0, 4) != "ERRO")//Confere se não houve erro ao entrar na Partida
                    {
                        txtRecortado = txt.Split(',');//Formata o retorno para colocar no Objeto


                        jogador = new Jogador();
                        jogador.nome = txtNomeJogador.Text;//Preenche o Objeto jogador
                        jogador.id = Convert.ToInt32(txtRecortado[0]);
                        jogador.senha = txtRecortado[1];
                        jogador.bot = chkBot.Checked;

                        txtIdjogador.Text = txtRecortado[0];//Preenche os campos da tela
                        txtSenhaJogador.Text = txtRecortado[1];

                        lblErroEntrarPartida.Text = "";//Remove a mensagem de Erro
                    }
                    else//Exibe a mensagem de erro do servidor
                    {
                        lblErroEntrarPartida.Text = txt.Substring(5);
                        tmrMsgErro.Enabled = true;
                    }
                }
                else//Ou exibe essa mensagem de erro
                {
                    lblErroEntrarPartida.Text = "Preencha seu nome e a senha da partida";
                    tmrMsgErro.Enabled = true;
                }
            }
            else//Ou exibe essa mensagem de erro caso o Id esteja vazio
            {
                lblErroEntrarPartida.Text = "Preencha o Id da partida";
                tmrMsgErro.Enabled = true;
            }
            ListarJogadores();//Atualiza os jogadores
        }//Botão Entrar na Partida
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (txtIdjogador.Text != "" && txtSenhaJogador.Text != "")
            {

                if (VerificaInicializacao(partida))//Caso o jogador iniciando a partida não esteja na partida selecionada, busca a partida desse jogador
                {                    

                    //Vê se a partida tá aberta
                    if (partida.status == "A")
                    {
                        string txt = Jogo.IniciarPartida(Convert.ToInt32(txtIdjogador.Text), txtSenhaJogador.Text);
                        if (txt.Length <= 4)
                        {
                            partida.status = "J";
                        }
                    }

                    string vez = Jogo.VerificarVez(Convert.ToInt32(txtIdjogador.Text), txtSenhaJogador.Text);
                    vez = vez.Substring(0, 1);
                    partida.status = vez;

                    if (partida.status == "J")//Abre o Tabuleiro
                    {
                        if (jogador == null)//Preenche o jogado caso ele esteja vazio para mandar para o Tabuleiro
                        {
                            jogador = new Jogador();
                            jogador.id = Convert.ToInt32(txtIdjogador.Text);
                            jogador.senha = txtSenhaJogador.Text;
                            jogador.nome = BuscarJogById(jogador.id);
                            jogador.bot = chkBot.Checked;
                        }

                        partida.ListarJogadores();

                        frmTabuleiro tabuleiro = new frmTabuleiro(partida, jogador);
                        tabuleiro.ShowDialog();

                        lblErroIniciar.Text = tabuleiro.erro;
                        tmrMsgErro.Enabled = true;
                    }
                    else
                    {
                        lblErroIniciar.Text = "Partida ja encerrou";
                        tmrMsgErro.Enabled = true;
                    }
                }
                else
                {
                    lblErroIniciar.Text = "Esse Jogador não está nessa partida";
                    tmrMsgErro.Enabled = true;
                    return;//Sai da função ao falhar em iniciar a partida;
                }
            }
            else
            {
                lblErroIniciar.Text = "Preencha o Id e a Senha do Jogador";
                tmrMsgErro.Enabled = true;
                return;//Sai da função ao falhar em iniciar a partida;
            }

            jogador = null;

            ListarPartidas();
        }//Botão Iniciar partida: Faz muitos testes, inicia a partida se ela estiver aberta e abre o tabuleiro
        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores();
        }

        /////////////////////////////////////////////////////////////

        private void tmrMsgErro_Tick(object sender, EventArgs e)
        {
            lblErroEntrarPartida.Text = "";
            lblErroIniciar.Text = "";
            tmrMsgErro.Enabled = false;            
        }//10 segundos com a mesma mensagem de Erro      

        /////////////////////////////////////////////////////////////

        public string BuscarJogById(int id)
        {
            foreach (Jogador jogador in partida.jogadores)
            {
                if (jogador.id == id)
                {
                    return jogador.nome;
                }
            }

            return "";
        }//Usado no iniciar partida
        public bool VerificaInicializacao(Partida p)
        {
            if (partida == null)
            {
                lblErroIniciar.Text = "Selecione uma partida";
                tmrMsgErro.Enabled = true;
            }
            else if (p.jogadores != null)
            {
                foreach (Jogador j in p.jogadores)
                {
                    if (Convert.ToInt32(txtIdjogador.Text) == j.id)
                    {
                        return true;
                    }
                }
            }

            return false;
        }//Verifica se o jogador que está iniciando a partida está na partida selecionada

        /////////////////////////////////////////////////////////////

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }//Botão Minimizar
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Botão Fechar

        /////////////////////////////////////////////////////////////

        private Point downPoint = Point.Empty;//Cria um objeto ponto para mover a tela

        private void pnlBarraWindows_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }//Sair do clique no painel de mover a tela
        private void pnlBarraWindows_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }//Mover do mouse no painel de mover a tela
        private void pnlBarraWindows_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                downPoint = new Point(e.X, e.Y);
            }
        }//Entrar do clique no painel de mover a tela                                                                

        /////////////////////////////////////////////////////////////

        //Configura o Hover do "Botão" criar partida
        private void pcbCriarPartida_MouseEnter(object sender, EventArgs e)
        {
            pcbCriarPartida.Image = Properties.Resources.btn1Alt;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }
        private void pcbCriarPartida_MouseLeave(object sender, EventArgs e)
        {
            pcbCriarPartida.Image = Properties.Resources.btn1;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");            
        }
        private void lblCriarPartida_MouseEnter(object sender, EventArgs e)
        {
            pcbCriarPartida.Image = Properties.Resources.btn1Alt;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }

        //Configura o Hover do "Botão" entrar na partida
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.btn1Alt;
            lblEntrarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.btn1;
            lblEntrarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
        private void lblEntrarPartida_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.btn1Alt;
            lblEntrarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }

        //Configura o Hover do "Botão" listar partidas
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.btn2Alt;
            lblListarPartidas.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.btn2;
            lblListarPartidas.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
        private void lblListarPartidas_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.btn2Alt;
            lblListarPartidas.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }

        //Configura o Hover do "Botão" iniciar partida
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.btn3Alt;
            lblIniciarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.btn3;
            lblIniciarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
        private void lblIniciarPartida_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.btn3Alt;
            lblIniciarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }

        private void frmLobby_MouseEnter(object sender, EventArgs e)
        {
            pcbCriarPartida.Image = Properties.Resources.btn1;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
            pictureBox2.Image = Properties.Resources.btn1;
            lblEntrarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
            pictureBox3.Image = Properties.Resources.btn2;
            lblListarPartidas.BackColor = ColorTranslator.FromHtml("#21e0f2");
            pictureBox4.Image = Properties.Resources.btn3;
            lblIniciarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
    }
}
