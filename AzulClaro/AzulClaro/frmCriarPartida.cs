using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace AzulClaro
{    
    public partial class frmCriarPartida : Form
    {
        public string senha { get; set; }
        public int idPartidaCriada { get; set; }

        public frmCriarPartida()
        {
            InitializeComponent();

            lblErro.Text = "";

            BackColor = Color.Lime;
            TransparencyKey = Color.Lime;
        }//Construtor
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;//Lê nome e senha da nova partida
            string erro;//Recebe a mensagem de erro do servidor
            senha = txtSenhaPartida.Text;
            if (nome != "" && senha != "")//Cria a nova partida caso ambos estejam preenchidos
            {
                erro = Jogo.CriarPartida(nome, senha);

                if (erro.Length <= 4)
                {
                    this.idPartidaCriada = Convert.ToInt32(erro);
                    Close();
                }
                else
                {
                    lblErro.Text = erro.Substring(5);
                }
            }
            else
            {
                lblErro.Text = "Preencha ambos os campos!";
            }
        }//Botão Criar Partida: se os campos estiverem preenchidos e sem erro na criação, cria a partida e retorna o id da partida criada         
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            senha = "";
            Close();
        }//Botão Cancelar: cancela a criação e não retorna nada pra tela anterior

        /////////////////////////////////////////////////////////////
        
        private void pcbCancelar_MouseEnter(object sender, EventArgs e)
        {
            pcbCancelar.Image = Properties.Resources.btnCancelarAlt;
            lblCancelar.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }
        private void pcbCancelar_MouseLeave(object sender, EventArgs e)
        {
            pcbCancelar.Image = Properties.Resources.btnCancelar;
            lblCancelar.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
        private void lblCancelar_MouseEnter(object sender, EventArgs e)
        {
            pcbCancelar.Image = Properties.Resources.btnCancelarAlt;
            lblCancelar.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }

        private void pcbCriar_MouseEnter(object sender, EventArgs e)
        {
            pcbCriar.Image = Properties.Resources.btnCriarAlt;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }
        private void pcbCriar_MouseLeave(object sender, EventArgs e)
        {
            pcbCriar.Image = Properties.Resources.btnCriar;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
        private void lblCriarPartida_MouseEnter(object sender, EventArgs e)
        {
            pcbCriar.Image = Properties.Resources.btnCriarAlt;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#A7F9FE");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pcbCancelar.Image = Properties.Resources.btnCancelar;
            lblCancelar.BackColor = ColorTranslator.FromHtml("#21e0f2");

            pcbCriar.Image = Properties.Resources.btnCriar;
            lblCriarPartida.BackColor = ColorTranslator.FromHtml("#21e0f2");
        }
    }
}          
