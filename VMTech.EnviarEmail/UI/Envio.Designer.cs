namespace VMTech.EnviarEmail
{
    partial class Envio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.dgvAnexos = new System.Windows.Forms.DataGridView();
            this.btSelecioneDe = new System.Windows.Forms.Button();
            this.btSelecionePara = new System.Windows.Forms.Button();
            this.pnDe = new System.Windows.Forms.Panel();
            this.btAcao2 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAcao = new System.Windows.Forms.Button();
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.txtPortaConfig = new System.Windows.Forms.TextBox();
            this.txtSMTPConfig = new System.Windows.Forms.TextBox();
            this.txtSenhaConfig = new System.Windows.Forms.TextBox();
            this.txtEmailConfig = new System.Windows.Forms.TextBox();
            this.ckCredencialConfig = new System.Windows.Forms.CheckBox();
            this.ckSSLConfig = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConfirmarConfig = new System.Windows.Forms.Button();
            this.btCancelaConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbQtd = new System.Windows.Forms.Label();
            this.lbEnv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).BeginInit();
            this.pnDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assunto:";
            // 
            // txtDe
            // 
            this.txtDe.Enabled = false;
            this.txtDe.Location = new System.Drawing.Point(64, 6);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(361, 20);
            this.txtDe.TabIndex = 3;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(64, 34);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(361, 20);
            this.txtPara.TabIndex = 4;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(64, 63);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(614, 20);
            this.txtAssunto.TabIndex = 5;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(13, 99);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(665, 236);
            this.txtMensagem.TabIndex = 6;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(603, 351);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 7;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(12, 351);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(97, 23);
            this.btnAnexar.TabIndex = 8;
            this.btnAnexar.Text = "Anexar Arquivo";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // dgvAnexos
            // 
            this.dgvAnexos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnexos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnexos.Location = new System.Drawing.Point(126, 351);
            this.dgvAnexos.Name = "dgvAnexos";
            this.dgvAnexos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnexos.Size = new System.Drawing.Size(460, 150);
            this.dgvAnexos.TabIndex = 9;
            this.dgvAnexos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnexos_CellClick);
            // 
            // btSelecioneDe
            // 
            this.btSelecioneDe.Location = new System.Drawing.Point(431, 4);
            this.btSelecioneDe.Name = "btSelecioneDe";
            this.btSelecioneDe.Size = new System.Drawing.Size(112, 23);
            this.btSelecioneDe.TabIndex = 10;
            this.btSelecioneDe.Text = "Selecione De...";
            this.btSelecioneDe.UseVisualStyleBackColor = true;
            this.btSelecioneDe.Click += new System.EventHandler(this.btSelecioneDe_Click);
            // 
            // btSelecionePara
            // 
            this.btSelecionePara.Location = new System.Drawing.Point(431, 32);
            this.btSelecionePara.Name = "btSelecionePara";
            this.btSelecionePara.Size = new System.Drawing.Size(112, 23);
            this.btSelecionePara.TabIndex = 11;
            this.btSelecionePara.Text = "Selecione Para...";
            this.btSelecionePara.UseVisualStyleBackColor = true;
            this.btSelecionePara.Click += new System.EventHandler(this.btSelecionePara_Click);
            // 
            // pnDe
            // 
            this.pnDe.Controls.Add(this.btAcao2);
            this.pnDe.Controls.Add(this.btLimpar);
            this.pnDe.Controls.Add(this.btAcao);
            this.pnDe.Controls.Add(this.dgvConfig);
            this.pnDe.Controls.Add(this.txtPortaConfig);
            this.pnDe.Controls.Add(this.txtSMTPConfig);
            this.pnDe.Controls.Add(this.txtSenhaConfig);
            this.pnDe.Controls.Add(this.txtEmailConfig);
            this.pnDe.Controls.Add(this.ckCredencialConfig);
            this.pnDe.Controls.Add(this.ckSSLConfig);
            this.pnDe.Controls.Add(this.label8);
            this.pnDe.Controls.Add(this.label7);
            this.pnDe.Controls.Add(this.label6);
            this.pnDe.Controls.Add(this.label5);
            this.pnDe.Controls.Add(this.btConfirmarConfig);
            this.pnDe.Controls.Add(this.btCancelaConfig);
            this.pnDe.Controls.Add(this.label4);
            this.pnDe.Location = new System.Drawing.Point(405, 380);
            this.pnDe.Name = "pnDe";
            this.pnDe.Size = new System.Drawing.Size(665, 497);
            this.pnDe.TabIndex = 12;
            this.pnDe.Visible = false;
            // 
            // btAcao2
            // 
            this.btAcao2.Location = new System.Drawing.Point(417, 140);
            this.btAcao2.Name = "btAcao2";
            this.btAcao2.Size = new System.Drawing.Size(75, 23);
            this.btAcao2.TabIndex = 16;
            this.btAcao2.Text = "Apagar";
            this.btAcao2.UseVisualStyleBackColor = true;
            this.btAcao2.Click += new System.EventHandler(this.btAcao2_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(579, 140);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAcao
            // 
            this.btAcao.Location = new System.Drawing.Point(498, 140);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(75, 23);
            this.btAcao.TabIndex = 14;
            this.btAcao.Text = "Adicionar";
            this.btAcao.UseVisualStyleBackColor = true;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // dgvConfig
            // 
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfig.Location = new System.Drawing.Point(16, 169);
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.Size = new System.Drawing.Size(638, 276);
            this.dgvConfig.TabIndex = 13;
            this.dgvConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellClick);
            // 
            // txtPortaConfig
            // 
            this.txtPortaConfig.Location = new System.Drawing.Point(553, 95);
            this.txtPortaConfig.Name = "txtPortaConfig";
            this.txtPortaConfig.Size = new System.Drawing.Size(101, 20);
            this.txtPortaConfig.TabIndex = 12;
            this.txtPortaConfig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortaConfig_KeyPress);
            // 
            // txtSMTPConfig
            // 
            this.txtSMTPConfig.Location = new System.Drawing.Point(116, 95);
            this.txtSMTPConfig.Name = "txtSMTPConfig";
            this.txtSMTPConfig.Size = new System.Drawing.Size(381, 20);
            this.txtSMTPConfig.TabIndex = 11;
            // 
            // txtSenhaConfig
            // 
            this.txtSenhaConfig.Location = new System.Drawing.Point(60, 63);
            this.txtSenhaConfig.Name = "txtSenhaConfig";
            this.txtSenhaConfig.PasswordChar = '*';
            this.txtSenhaConfig.Size = new System.Drawing.Size(290, 20);
            this.txtSenhaConfig.TabIndex = 10;
            this.txtSenhaConfig.UseSystemPasswordChar = true;
            // 
            // txtEmailConfig
            // 
            this.txtEmailConfig.Location = new System.Drawing.Point(60, 34);
            this.txtEmailConfig.Name = "txtEmailConfig";
            this.txtEmailConfig.Size = new System.Drawing.Size(437, 20);
            this.txtEmailConfig.TabIndex = 9;
            // 
            // ckCredencialConfig
            // 
            this.ckCredencialConfig.AutoSize = true;
            this.ckCredencialConfig.Location = new System.Drawing.Point(116, 134);
            this.ckCredencialConfig.Name = "ckCredencialConfig";
            this.ckCredencialConfig.Size = new System.Drawing.Size(76, 17);
            this.ckCredencialConfig.TabIndex = 8;
            this.ckCredencialConfig.Text = "Credêncial";
            this.ckCredencialConfig.UseVisualStyleBackColor = true;
            // 
            // ckSSLConfig
            // 
            this.ckSSLConfig.AutoSize = true;
            this.ckSSLConfig.Location = new System.Drawing.Point(16, 134);
            this.ckSSLConfig.Name = "ckSSLConfig";
            this.ckSSLConfig.Size = new System.Drawing.Size(46, 17);
            this.ckSSLConfig.TabIndex = 7;
            this.ckSSLConfig.Text = "SSL";
            this.ckSSLConfig.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Porta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Servidor de SMTP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-mail:";
            // 
            // btConfirmarConfig
            // 
            this.btConfirmarConfig.Location = new System.Drawing.Point(498, 461);
            this.btConfirmarConfig.Name = "btConfirmarConfig";
            this.btConfirmarConfig.Size = new System.Drawing.Size(75, 23);
            this.btConfirmarConfig.TabIndex = 2;
            this.btConfirmarConfig.Text = "Confirmar";
            this.btConfirmarConfig.UseVisualStyleBackColor = true;
            this.btConfirmarConfig.Click += new System.EventHandler(this.btConfirmarConfig_Click);
            // 
            // btCancelaConfig
            // 
            this.btCancelaConfig.Location = new System.Drawing.Point(579, 461);
            this.btCancelaConfig.Name = "btCancelaConfig";
            this.btCancelaConfig.Size = new System.Drawing.Size(75, 23);
            this.btCancelaConfig.TabIndex = 1;
            this.btCancelaConfig.Text = "Cancelar";
            this.btCancelaConfig.UseVisualStyleBackColor = true;
            this.btCancelaConfig.Click += new System.EventHandler(this.btCancelaConfig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(191, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gerenciar Dados de Saída";
            // 
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.lbQtd);
            this.pnStatus.Controls.Add(this.lbEnv);
            this.pnStatus.Location = new System.Drawing.Point(259, 168);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(200, 100);
            this.pnStatus.TabIndex = 13;
            // 
            // lbQtd
            // 
            this.lbQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbQtd.Location = new System.Drawing.Point(3, 59);
            this.lbQtd.Name = "lbQtd";
            this.lbQtd.Size = new System.Drawing.Size(194, 20);
            this.lbQtd.TabIndex = 1;
            this.lbQtd.Text = "0 de 0";
            this.lbQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEnv
            // 
            this.lbEnv.AutoSize = true;
            this.lbEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbEnv.Location = new System.Drawing.Point(60, 18);
            this.lbEnv.Name = "lbEnv";
            this.lbEnv.Size = new System.Drawing.Size(83, 20);
            this.lbEnv.TabIndex = 0;
            this.lbEnv.Text = "Enviando";
            // 
            // Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 522);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnDe);
            this.Controls.Add(this.btSelecionePara);
            this.Controls.Add(this.btSelecioneDe);
            this.Controls.Add(this.dgvAnexos);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(706, 561);
            this.MinimumSize = new System.Drawing.Size(706, 561);
            this.Name = "Envio";
            this.Text = "Envio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).EndInit();
            this.pnDe.ResumeLayout(false);
            this.pnDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.DataGridView dgvAnexos;
        private System.Windows.Forms.Button btSelecioneDe;
        private System.Windows.Forms.Button btSelecionePara;
        private System.Windows.Forms.Panel pnDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btConfirmarConfig;
        private System.Windows.Forms.Button btCancelaConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckCredencialConfig;
        private System.Windows.Forms.CheckBox ckSSLConfig;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.TextBox txtPortaConfig;
        private System.Windows.Forms.TextBox txtSMTPConfig;
        private System.Windows.Forms.TextBox txtSenhaConfig;
        private System.Windows.Forms.TextBox txtEmailConfig;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.Button btAcao2;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbQtd;
        private System.Windows.Forms.Label lbEnv;
    }
}