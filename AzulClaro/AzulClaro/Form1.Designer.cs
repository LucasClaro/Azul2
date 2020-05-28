namespace AzulClaro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnListPartidas = new System.Windows.Forms.Button();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblErroEntrarPartida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdjogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrMsgErro = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.lblErroIniciar = new System.Windows.Forms.Label();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbAbertas = new System.Windows.Forms.RadioButton();
            this.rdbEncerradas = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlBarraWindows = new System.Windows.Forms.Panel();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBarraWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListPartidas
            // 
            this.btnListPartidas.BackColor = System.Drawing.Color.White;
            this.btnListPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPartidas.Font = new System.Drawing.Font("Oxanium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPartidas.Location = new System.Drawing.Point(243, 52);
            this.btnListPartidas.Name = "btnListPartidas";
            this.btnListPartidas.Size = new System.Drawing.Size(138, 48);
            this.btnListPartidas.TabIndex = 0;
            this.btnListPartidas.Text = "Listar Partidas";
            this.btnListPartidas.UseVisualStyleBackColor = false;
            this.btnListPartidas.Click += new System.EventHandler(this.btnListPartidas_Click);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BackColor = System.Drawing.Color.White;
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Enabled = false;
            this.txtIdPartida.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtIdPartida.Location = new System.Drawing.Point(268, 171);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(36, 24);
            this.txtIdPartida.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oxanium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(98)))), ((int)(((byte)(204)))));
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Oxanium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.White;
            this.btnCriarPartida.Location = new System.Drawing.Point(243, 106);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(229, 37);
            this.btnCriarPartida.TabIndex = 7;
            this.btnCriarPartida.Text = "Criar Partida...";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.White;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.Font = new System.Drawing.Font("Oxanium", 12F);
            this.btnListarJogadores.Location = new System.Drawing.Point(243, 201);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(229, 33);
            this.btnListarJogadores.TabIndex = 10;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Oxanium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 20;
            this.lstJogadores.Location = new System.Drawing.Point(243, 240);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(229, 84);
            this.lstJogadores.TabIndex = 11;
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.BackColor = System.Drawing.Color.White;
            this.txtSenhaEntrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaEntrar.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtSenhaEntrar.Location = new System.Drawing.Point(354, 171);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(118, 24);
            this.txtSenhaEntrar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oxanium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Oxanium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(366, 9);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(107, 24);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "Versão: 0.0";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtNomeJogador.Location = new System.Drawing.Point(348, 351);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(124, 24);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.label3.Location = new System.Drawing.Point(243, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(98)))), ((int)(((byte)(204)))));
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Oxanium", 12F);
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.White;
            this.btnEntrarPartida.Location = new System.Drawing.Point(243, 407);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(229, 31);
            this.btnEntrarPartida.TabIndex = 19;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblErroEntrarPartida
            // 
            this.lblErroEntrarPartida.AutoSize = true;
            this.lblErroEntrarPartida.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroEntrarPartida.Location = new System.Drawing.Point(240, 441);
            this.lblErroEntrarPartida.Name = "lblErroEntrarPartida";
            this.lblErroEntrarPartida.Size = new System.Drawing.Size(35, 14);
            this.lblErroEntrarPartida.TabIndex = 20;
            this.lblErroEntrarPartida.Text = "ERRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.label2.Location = new System.Drawing.Point(265, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Jogador";
            // 
            // txtIdjogador
            // 
            this.txtIdjogador.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtIdjogador.Location = new System.Drawing.Point(348, 476);
            this.txtIdjogador.Name = "txtIdjogador";
            this.txtIdjogador.Size = new System.Drawing.Size(53, 24);
            this.txtIdjogador.TabIndex = 22;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(348, 506);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(124, 24);
            this.txtSenhaJogador.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.label5.Location = new System.Drawing.Point(243, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Senha Jogador";
            // 
            // tmrMsgErro
            // 
            this.tmrMsgErro.Interval = 10000;
            this.tmrMsgErro.Tick += new System.EventHandler(this.tmrMsgErro_Tick);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(98)))), ((int)(((byte)(204)))));
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Oxanium", 12F);
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPartida.Location = new System.Drawing.Point(246, 536);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(226, 31);
            this.btnIniciarPartida.TabIndex = 25;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.Font = new System.Drawing.Font("Oxanium", 9.75F);
            this.chkBot.Location = new System.Drawing.Point(246, 381);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(170, 20);
            this.chkBot.TabIndex = 26;
            this.chkBot.Text = "Esse jogador é um Bot?";
            this.chkBot.UseVisualStyleBackColor = true;
            // 
            // lblErroIniciar
            // 
            this.lblErroIniciar.AutoSize = true;
            this.lblErroIniciar.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroIniciar.Location = new System.Drawing.Point(243, 570);
            this.lblErroIniciar.Name = "lblErroIniciar";
            this.lblErroIniciar.Size = new System.Drawing.Size(35, 14);
            this.lblErroIniciar.TabIndex = 30;
            this.lblErroIniciar.Text = "ERRO";
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Location = new System.Drawing.Point(12, 52);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.Size = new System.Drawing.Size(225, 532);
            this.dgvPartidas.TabIndex = 31;
            this.dgvPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(61)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblVersao);
            this.panel1.Location = new System.Drawing.Point(-1, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 42);
            this.panel1.TabIndex = 32;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(392, 52);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(56, 18);
            this.rdbTodos.TabIndex = 33;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbAbertas
            // 
            this.rdbAbertas.AutoSize = true;
            this.rdbAbertas.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAbertas.Location = new System.Drawing.Point(392, 67);
            this.rdbAbertas.Name = "rdbAbertas";
            this.rdbAbertas.Size = new System.Drawing.Size(64, 18);
            this.rdbAbertas.TabIndex = 34;
            this.rdbAbertas.Text = "Abertas";
            this.rdbAbertas.UseVisualStyleBackColor = true;
            // 
            // rdbEncerradas
            // 
            this.rdbEncerradas.AutoSize = true;
            this.rdbEncerradas.Font = new System.Drawing.Font("Oxanium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEncerradas.Location = new System.Drawing.Point(392, 82);
            this.rdbEncerradas.Name = "rdbEncerradas";
            this.rdbEncerradas.Size = new System.Drawing.Size(81, 18);
            this.rdbEncerradas.TabIndex = 35;
            this.rdbEncerradas.Text = "Encerradas";
            this.rdbEncerradas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(243, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 1);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(243, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 1);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(243, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 1);
            this.panel4.TabIndex = 38;
            // 
            // pnlBarraWindows
            // 
            this.pnlBarraWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.pnlBarraWindows.Controls.Add(this.pcbMinimizar);
            this.pnlBarraWindows.Controls.Add(this.pcbFechar);
            this.pnlBarraWindows.Location = new System.Drawing.Point(-1, 0);
            this.pnlBarraWindows.Name = "pnlBarraWindows";
            this.pnlBarraWindows.Size = new System.Drawing.Size(485, 46);
            this.pnlBarraWindows.TabIndex = 39;
            this.pnlBarraWindows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseDown);
            this.pnlBarraWindows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseMove);
            this.pnlBarraWindows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseUp);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pcbMinimizar.Image = global::AzulClaro.Properties.Resources.mini;
            this.pcbMinimizar.Location = new System.Drawing.Point(403, 6);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pcbMinimizar.TabIndex = 41;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbFechar
            // 
            this.pcbFechar.BackColor = System.Drawing.Color.Transparent;
            this.pcbFechar.Image = global::AzulClaro.Properties.Resources.close;
            this.pcbFechar.Location = new System.Drawing.Point(441, 6);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(32, 32);
            this.pcbFechar.TabIndex = 40;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(477, 630);
            this.Controls.Add(this.pnlBarraWindows);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rdbEncerradas);
            this.Controls.Add(this.rdbAbertas);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.lblErroIniciar);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdjogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErroEntrarPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.btnListPartidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBarraWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListPartidas;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblErroEntrarPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdjogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrMsgErro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.Label lblErroIniciar;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbAbertas;
        private System.Windows.Forms.RadioButton rdbEncerradas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlBarraWindows;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbFechar;
    }
}