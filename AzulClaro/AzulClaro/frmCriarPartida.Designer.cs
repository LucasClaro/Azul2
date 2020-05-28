namespace AzulClaro
{
    partial class frmCriarPartida
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
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.pcbCriar = new System.Windows.Forms.PictureBox();
            this.pcbCancelar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCriar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaPartida.Location = new System.Drawing.Point(103, 103);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(188, 23);
            this.txtSenhaPartida.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePartida.Location = new System.Drawing.Point(103, 77);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(188, 23);
            this.txtNomePartida.TabIndex = 0;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblErro.Location = new System.Drawing.Point(57, 129);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(14, 13);
            this.lblErro.TabIndex = 15;
            this.lblErro.Text = "A";
            // 
            // pcbCriar
            // 
            this.pcbCriar.Image = global::AzulClaro.Properties.Resources.btnCriar;
            this.pcbCriar.Location = new System.Drawing.Point(64, 206);
            this.pcbCriar.Name = "pcbCriar";
            this.pcbCriar.Size = new System.Drawing.Size(222, 48);
            this.pcbCriar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCriar.TabIndex = 19;
            this.pcbCriar.TabStop = false;
            this.pcbCriar.Click += new System.EventHandler(this.btnCriarPartida_Click);
            this.pcbCriar.MouseEnter += new System.EventHandler(this.pcbCriar_MouseEnter);
            this.pcbCriar.MouseLeave += new System.EventHandler(this.pcbCriar_MouseLeave);
            // 
            // pcbCancelar
            // 
            this.pcbCancelar.Image = global::AzulClaro.Properties.Resources.btnCancelar;
            this.pcbCancelar.Location = new System.Drawing.Point(45, 168);
            this.pcbCancelar.Name = "pcbCancelar";
            this.pcbCancelar.Size = new System.Drawing.Size(260, 32);
            this.pcbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCancelar.TabIndex = 18;
            this.pcbCancelar.TabStop = false;
            this.pcbCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.pcbCancelar.MouseEnter += new System.EventHandler(this.pcbCancelar_MouseEnter);
            this.pcbCancelar.MouseLeave += new System.EventHandler(this.pcbCancelar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AzulClaro.Properties.Resources.criar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblCriarPartida.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarPartida.Location = new System.Drawing.Point(116, 219);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(117, 23);
            this.lblCriarPartida.TabIndex = 61;
            this.lblCriarPartida.Text = "Criar Partida";
            this.lblCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            this.lblCriarPartida.MouseEnter += new System.EventHandler(this.lblCriarPartida_MouseEnter);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.lblCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.Location = new System.Drawing.Point(132, 174);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(86, 23);
            this.lblCancelar.TabIndex = 62;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.lblCancelar.MouseEnter += new System.EventHandler(this.lblCancelar_MouseEnter);
            // 
            // frmCriarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(350, 305);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.pcbCriar);
            this.Controls.Add(this.pcbCancelar);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCriarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar Partida";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCriar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbCancelar;
        private System.Windows.Forms.PictureBox pcbCriar;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.Label lblCancelar;
    }
}