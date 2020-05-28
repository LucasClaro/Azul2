namespace AzulClaro
{
    partial class frmLobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobby));
            this.pnlBarraWindows = new System.Windows.Forms.Panel();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblErroIniciar = new System.Windows.Forms.Label();
            this.lblErroEntrarPartida = new System.Windows.Forms.Label();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.rdbEncerradas = new System.Windows.Forms.RadioButton();
            this.rdbAbertas = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.txtSenhaEntrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrMsgErro = new System.Windows.Forms.Timer(this.components);
            this.txtIdjogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.pcbCriarPartida = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.lblEntrarPartida = new System.Windows.Forms.Label();
            this.lblListarPartidas = new System.Windows.Forms.Label();
            this.lblIniciarPartida = new System.Windows.Forms.Label();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.pnlBarraWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCriarPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraWindows
            // 
            this.pnlBarraWindows.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarraWindows.Controls.Add(this.pcbMinimizar);
            this.pnlBarraWindows.Controls.Add(this.pcbFechar);
            this.pnlBarraWindows.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraWindows.Name = "pnlBarraWindows";
            this.pnlBarraWindows.Size = new System.Drawing.Size(479, 71);
            this.pnlBarraWindows.TabIndex = 0;
            this.pnlBarraWindows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseDown);
            this.pnlBarraWindows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseMove);
            this.pnlBarraWindows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarraWindows_MouseUp);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pcbMinimizar.Image = global::AzulClaro.Properties.Resources.mini;
            this.pcbMinimizar.Location = new System.Drawing.Point(412, 0);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pcbMinimizar.TabIndex = 57;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbFechar
            // 
            this.pcbFechar.BackColor = System.Drawing.Color.Transparent;
            this.pcbFechar.Image = global::AzulClaro.Properties.Resources.close;
            this.pcbFechar.Location = new System.Drawing.Point(441, 0);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(32, 32);
            this.pcbFechar.TabIndex = 56;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.Black;
            this.lblVersao.Location = new System.Drawing.Point(12, 602);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(99, 23);
            this.lblVersao.TabIndex = 15;
            this.lblVersao.Text = "Versão: 0.0";
            // 
            // lblErroIniciar
            // 
            this.lblErroIniciar.AutoSize = true;
            this.lblErroIniciar.BackColor = System.Drawing.Color.Transparent;
            this.lblErroIniciar.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblErroIniciar.Location = new System.Drawing.Point(243, 559);
            this.lblErroIniciar.Name = "lblErroIniciar";
            this.lblErroIniciar.Size = new System.Drawing.Size(30, 13);
            this.lblErroIniciar.TabIndex = 31;
            this.lblErroIniciar.Text = "ERRO";
            // 
            // lblErroEntrarPartida
            // 
            this.lblErroEntrarPartida.AutoSize = true;
            this.lblErroEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblErroEntrarPartida.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroEntrarPartida.Location = new System.Drawing.Point(290, 458);
            this.lblErroEntrarPartida.Name = "lblErroEntrarPartida";
            this.lblErroEntrarPartida.Size = new System.Drawing.Size(30, 13);
            this.lblErroEntrarPartida.TabIndex = 32;
            this.lblErroEntrarPartida.Text = "ERRO";
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.dgvPartidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPartidas.EnableHeadersVisualStyles = false;
            this.dgvPartidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPartidas.Location = new System.Drawing.Point(12, 99);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.Size = new System.Drawing.Size(212, 405);
            this.dgvPartidas.TabIndex = 33;
            this.dgvPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            // 
            // rdbEncerradas
            // 
            this.rdbEncerradas.AutoSize = true;
            this.rdbEncerradas.BackColor = System.Drawing.Color.Transparent;
            this.rdbEncerradas.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEncerradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.rdbEncerradas.Location = new System.Drawing.Point(144, 561);
            this.rdbEncerradas.Name = "rdbEncerradas";
            this.rdbEncerradas.Size = new System.Drawing.Size(83, 17);
            this.rdbEncerradas.TabIndex = 38;
            this.rdbEncerradas.Text = "Encerradas";
            this.rdbEncerradas.UseVisualStyleBackColor = false;
            // 
            // rdbAbertas
            // 
            this.rdbAbertas.AutoSize = true;
            this.rdbAbertas.BackColor = System.Drawing.Color.Transparent;
            this.rdbAbertas.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAbertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.rdbAbertas.Location = new System.Drawing.Point(74, 561);
            this.rdbAbertas.Name = "rdbAbertas";
            this.rdbAbertas.Size = new System.Drawing.Size(65, 17);
            this.rdbAbertas.TabIndex = 37;
            this.rdbAbertas.Text = "Abertas";
            this.rdbAbertas.UseVisualStyleBackColor = false;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.BackColor = System.Drawing.Color.Transparent;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.rdbTodos.Location = new System.Drawing.Point(12, 561);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(53, 17);
            this.rdbTodos.TabIndex = 36;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BackColor = System.Drawing.Color.White;
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Enabled = false;
            this.txtIdPartida.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPartida.Location = new System.Drawing.Point(310, 99);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(36, 23);
            this.txtIdPartida.TabIndex = 39;
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 19;
            this.lstJogadores.Location = new System.Drawing.Point(289, 138);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(180, 99);
            this.lstJogadores.TabIndex = 41;
            // 
            // txtSenhaEntrar
            // 
            this.txtSenhaEntrar.BackColor = System.Drawing.Color.White;
            this.txtSenhaEntrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaEntrar.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEntrar.Location = new System.Drawing.Point(394, 99);
            this.txtSenhaEntrar.Name = "txtSenhaEntrar";
            this.txtSenhaEntrar.Size = new System.Drawing.Size(75, 23);
            this.txtSenhaEntrar.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Senha";
            // 
            // tmrMsgErro
            // 
            this.tmrMsgErro.Interval = 10000;
            this.tmrMsgErro.Tick += new System.EventHandler(this.tmrMsgErro_Tick);
            // 
            // txtIdjogador
            // 
            this.txtIdjogador.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdjogador.Location = new System.Drawing.Point(344, 478);
            this.txtIdjogador.Name = "txtIdjogador";
            this.txtIdjogador.Size = new System.Drawing.Size(125, 23);
            this.txtIdjogador.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Id";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaJogador.Location = new System.Drawing.Point(344, 507);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(125, 23);
            this.txtSenhaJogador.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Senha";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.Location = new System.Drawing.Point(344, 353);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(125, 23);
            this.txtNomeJogador.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nome";
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.BackColor = System.Drawing.Color.Transparent;
            this.chkBot.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBot.Location = new System.Drawing.Point(293, 389);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(162, 20);
            this.chkBot.TabIndex = 55;
            this.chkBot.Text = "Esse jogador é um Bot?";
            this.chkBot.UseVisualStyleBackColor = false;
            // 
            // pcbCriarPartida
            // 
            this.pcbCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.pcbCriarPartida.Image = ((System.Drawing.Image)(resources.GetObject("pcbCriarPartida.Image")));
            this.pcbCriarPartida.Location = new System.Drawing.Point(289, 240);
            this.pcbCriarPartida.Name = "pcbCriarPartida";
            this.pcbCriarPartida.Size = new System.Drawing.Size(190, 40);
            this.pcbCriarPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCriarPartida.TabIndex = 56;
            this.pcbCriarPartida.TabStop = false;
            this.pcbCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            this.pcbCriarPartida.MouseEnter += new System.EventHandler(this.pcbCriarPartida_MouseEnter);
            this.pcbCriarPartida.MouseLeave += new System.EventHandler(this.pcbCriarPartida_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(289, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 510);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(224, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnListPartidas_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(246, 575);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(239, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblCriarPartida.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.Location = new System.Drawing.Point(311, 248);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(146, 25);
            this.lblCriarPartida.TabIndex = 60;
            this.lblCriarPartida.Text = "Criar Partida...";
            this.lblCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            this.lblCriarPartida.MouseEnter += new System.EventHandler(this.lblCriarPartida_MouseEnter);
            // 
            // lblEntrarPartida
            // 
            this.lblEntrarPartida.AutoSize = true;
            this.lblEntrarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblEntrarPartida.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrarPartida.Location = new System.Drawing.Point(299, 421);
            this.lblEntrarPartida.Name = "lblEntrarPartida";
            this.lblEntrarPartida.Size = new System.Drawing.Size(174, 25);
            this.lblEntrarPartida.TabIndex = 61;
            this.lblEntrarPartida.Text = "Entrar na Partida";
            this.lblEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            this.lblEntrarPartida.MouseEnter += new System.EventHandler(this.lblEntrarPartida_MouseEnter);
            // 
            // lblListarPartidas
            // 
            this.lblListarPartidas.AutoSize = true;
            this.lblListarPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblListarPartidas.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarPartidas.Location = new System.Drawing.Point(44, 516);
            this.lblListarPartidas.Name = "lblListarPartidas";
            this.lblListarPartidas.Size = new System.Drawing.Size(150, 25);
            this.lblListarPartidas.TabIndex = 62;
            this.lblListarPartidas.Text = "Listar Partidas";
            this.lblListarPartidas.Click += new System.EventHandler(this.btnListPartidas_Click);
            this.lblListarPartidas.MouseEnter += new System.EventHandler(this.lblListarPartidas_MouseEnter);
            // 
            // lblIniciarPartida
            // 
            this.lblIniciarPartida.AutoSize = true;
            this.lblIniciarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblIniciarPartida.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarPartida.Location = new System.Drawing.Point(273, 588);
            this.lblIniciarPartida.Name = "lblIniciarPartida";
            this.lblIniciarPartida.Size = new System.Drawing.Size(184, 33);
            this.lblIniciarPartida.TabIndex = 63;
            this.lblIniciarPartida.Text = "Iniciar Partida";
            this.lblIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            this.lblIniciarPartida.MouseEnter += new System.EventHandler(this.lblIniciarPartida_MouseEnter);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(310, 286);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(163, 23);
            this.btnListarJogadores.TabIndex = 64;
            this.btnListarJogadores.Text = "ListarJogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AzulClaro.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(477, 630);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.lblIniciarPartida);
            this.Controls.Add(this.lblListarPartidas);
            this.Controls.Add(this.lblEntrarPartida);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcbCriarPartida);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdjogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.rdbEncerradas);
            this.Controls.Add(this.rdbAbertas);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.lblErroEntrarPartida);
            this.Controls.Add(this.lblErroIniciar);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pnlBarraWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLobby";
            this.Text = "frmLobby";
            this.MouseEnter += new System.EventHandler(this.frmLobby_MouseEnter);
            this.pnlBarraWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCriarPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraWindows;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblErroIniciar;
        private System.Windows.Forms.Label lblErroEntrarPartida;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.RadioButton rdbEncerradas;
        private System.Windows.Forms.RadioButton rdbAbertas;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.TextBox txtSenhaEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrMsgErro;
        private System.Windows.Forms.TextBox txtIdjogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbFechar;
        private System.Windows.Forms.PictureBox pcbCriarPartida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.Label lblEntrarPartida;
        private System.Windows.Forms.Label lblListarPartidas;
        private System.Windows.Forms.Label lblIniciarPartida;
        private System.Windows.Forms.Button btnListarJogadores;
    }
}