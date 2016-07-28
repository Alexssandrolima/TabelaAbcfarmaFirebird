namespace TabelaAbcfarmaFirebird
{
    partial class FormConfiguracao
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
            this.groupBoxConfigurarDados = new System.Windows.Forms.GroupBox();
            this.labelComputador = new System.Windows.Forms.Label();
            this.textBoxComputador = new System.Windows.Forms.TextBox();
            this.buttonGravarDadosCliente = new System.Windows.Forms.Button();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labelcep = new System.Windows.Forms.Label();
            this.textBoxcep = new System.Windows.Forms.TextBox();
            this.labelnumero = new System.Windows.Forms.Label();
            this.textBoxnumero = new System.Windows.Forms.TextBox();
            this.labelendereco = new System.Windows.Forms.Label();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.labelcnpj = new System.Windows.Forms.Label();
            this.textBoxcnpj = new System.Windows.Forms.TextBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.groupBoxserial = new System.Windows.Forms.GroupBox();
            this.buttonAtivarKey = new System.Windows.Forms.Button();
            this.labelkey = new System.Windows.Forms.Label();
            this.textBoxkey = new System.Windows.Forms.TextBox();
            this.buttonCopiarArquivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelconnuser = new System.Windows.Forms.Label();
            this.txtConnuser = new System.Windows.Forms.TextBox();
            this.labelconnBase = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxConfigurarDados.SuspendLayout();
            this.groupBoxserial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfigurarDados
            // 
            this.groupBoxConfigurarDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfigurarDados.Controls.Add(this.labelComputador);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxComputador);
            this.groupBoxConfigurarDados.Controls.Add(this.buttonGravarDadosCliente);
            this.groupBoxConfigurarDados.Controls.Add(this.labelemail);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxemail);
            this.groupBoxConfigurarDados.Controls.Add(this.labelcep);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxcep);
            this.groupBoxConfigurarDados.Controls.Add(this.labelnumero);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxnumero);
            this.groupBoxConfigurarDados.Controls.Add(this.labelendereco);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxendereco);
            this.groupBoxConfigurarDados.Controls.Add(this.labelcnpj);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxcnpj);
            this.groupBoxConfigurarDados.Controls.Add(this.labelnome);
            this.groupBoxConfigurarDados.Controls.Add(this.textBoxnome);
            this.groupBoxConfigurarDados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfigurarDados.Name = "groupBoxConfigurarDados";
            this.groupBoxConfigurarDados.Size = new System.Drawing.Size(599, 148);
            this.groupBoxConfigurarDados.TabIndex = 0;
            this.groupBoxConfigurarDados.TabStop = false;
            this.groupBoxConfigurarDados.Text = "Configuração";
            // 
            // labelComputador
            // 
            this.labelComputador.AutoSize = true;
            this.labelComputador.Location = new System.Drawing.Point(6, 50);
            this.labelComputador.Name = "labelComputador";
            this.labelComputador.Size = new System.Drawing.Size(67, 13);
            this.labelComputador.TabIndex = 3;
            this.labelComputador.Text = "Computador:";
            // 
            // textBoxComputador
            // 
            this.textBoxComputador.Enabled = false;
            this.textBoxComputador.Location = new System.Drawing.Point(79, 47);
            this.textBoxComputador.Name = "textBoxComputador";
            this.textBoxComputador.Size = new System.Drawing.Size(179, 20);
            this.textBoxComputador.TabIndex = 3;
            // 
            // buttonGravarDadosCliente
            // 
            this.buttonGravarDadosCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonGravarDadosCliente.Location = new System.Drawing.Point(462, 108);
            this.buttonGravarDadosCliente.Name = "buttonGravarDadosCliente";
            this.buttonGravarDadosCliente.Size = new System.Drawing.Size(131, 23);
            this.buttonGravarDadosCliente.TabIndex = 8;
            this.buttonGravarDadosCliente.Text = "&Gravar dados Arquivo";
            this.buttonGravarDadosCliente.UseVisualStyleBackColor = true;
            this.buttonGravarDadosCliente.Click += new System.EventHandler(this.buttonGravarDadosCliente_Click);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(6, 108);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(38, 13);
            this.labelemail.TabIndex = 6;
            this.labelemail.Text = "E-mail:";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(54, 105);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(269, 20);
            this.textBoxemail.TabIndex = 7;
            // 
            // labelcep
            // 
            this.labelcep.AutoSize = true;
            this.labelcep.Location = new System.Drawing.Point(417, 80);
            this.labelcep.Name = "labelcep";
            this.labelcep.Size = new System.Drawing.Size(29, 13);
            this.labelcep.TabIndex = 5;
            this.labelcep.Text = "Cep:";
            // 
            // textBoxcep
            // 
            this.textBoxcep.Location = new System.Drawing.Point(452, 77);
            this.textBoxcep.Name = "textBoxcep";
            this.textBoxcep.Size = new System.Drawing.Size(115, 20);
            this.textBoxcep.TabIndex = 6;
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(329, 80);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(19, 13);
            this.labelnumero.TabIndex = 4;
            this.labelnumero.Text = "N°";
            // 
            // textBoxnumero
            // 
            this.textBoxnumero.Location = new System.Drawing.Point(364, 77);
            this.textBoxnumero.Name = "textBoxnumero";
            this.textBoxnumero.Size = new System.Drawing.Size(48, 20);
            this.textBoxnumero.TabIndex = 5;
            // 
            // labelendereco
            // 
            this.labelendereco.AutoSize = true;
            this.labelendereco.Location = new System.Drawing.Point(6, 80);
            this.labelendereco.Name = "labelendereco";
            this.labelendereco.Size = new System.Drawing.Size(29, 13);
            this.labelendereco.TabIndex = 4;
            this.labelendereco.Text = "End:";
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Location = new System.Drawing.Point(54, 77);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(269, 20);
            this.textBoxendereco.TabIndex = 4;
            // 
            // labelcnpj
            // 
            this.labelcnpj.AutoSize = true;
            this.labelcnpj.Location = new System.Drawing.Point(265, 22);
            this.labelcnpj.Name = "labelcnpj";
            this.labelcnpj.Size = new System.Drawing.Size(31, 13);
            this.labelcnpj.TabIndex = 2;
            this.labelcnpj.Text = "Cnpj:";
            // 
            // textBoxcnpj
            // 
            this.textBoxcnpj.Location = new System.Drawing.Point(313, 19);
            this.textBoxcnpj.Name = "textBoxcnpj";
            this.textBoxcnpj.Size = new System.Drawing.Size(204, 20);
            this.textBoxcnpj.TabIndex = 2;
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(6, 22);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(38, 13);
            this.labelnome.TabIndex = 1;
            this.labelnome.Text = "Nome:";
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(54, 19);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(204, 20);
            this.textBoxnome.TabIndex = 1;
            // 
            // groupBoxserial
            // 
            this.groupBoxserial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxserial.Controls.Add(this.buttonAtivarKey);
            this.groupBoxserial.Controls.Add(this.labelkey);
            this.groupBoxserial.Controls.Add(this.textBoxkey);
            this.groupBoxserial.Location = new System.Drawing.Point(12, 166);
            this.groupBoxserial.Name = "groupBoxserial";
            this.groupBoxserial.Size = new System.Drawing.Size(596, 156);
            this.groupBoxserial.TabIndex = 1;
            this.groupBoxserial.TabStop = false;
            this.groupBoxserial.Text = "Serial para Liberação";
            // 
            // buttonAtivarKey
            // 
            this.buttonAtivarKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAtivarKey.Location = new System.Drawing.Point(459, 73);
            this.buttonAtivarKey.Name = "buttonAtivarKey";
            this.buttonAtivarKey.Size = new System.Drawing.Size(131, 23);
            this.buttonAtivarKey.TabIndex = 2;
            this.buttonAtivarKey.Text = "&Ativar Key CPU";
            this.buttonAtivarKey.UseVisualStyleBackColor = true;
            this.buttonAtivarKey.Click += new System.EventHandler(this.buttonAtivarKey_Click);
            // 
            // labelkey
            // 
            this.labelkey.AutoSize = true;
            this.labelkey.Location = new System.Drawing.Point(6, 32);
            this.labelkey.Name = "labelkey";
            this.labelkey.Size = new System.Drawing.Size(28, 13);
            this.labelkey.TabIndex = 0;
            this.labelkey.Text = "Key:";
            // 
            // textBoxkey
            // 
            this.textBoxkey.Location = new System.Drawing.Point(54, 29);
            this.textBoxkey.Multiline = true;
            this.textBoxkey.Name = "textBoxkey";
            this.textBoxkey.Size = new System.Drawing.Size(376, 121);
            this.textBoxkey.TabIndex = 1;
            // 
            // buttonCopiarArquivo
            // 
            this.buttonCopiarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopiarArquivo.Location = new System.Drawing.Point(9, 48);
            this.buttonCopiarArquivo.Name = "buttonCopiarArquivo";
            this.buttonCopiarArquivo.Size = new System.Drawing.Size(131, 23);
            this.buttonCopiarArquivo.TabIndex = 0;
            this.buttonCopiarArquivo.Text = "&Copiar Tabela Abcfarma";
            this.buttonCopiarArquivo.UseVisualStyleBackColor = true;
            this.buttonCopiarArquivo.Click += new System.EventHandler(this.buttonVerArquivo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelDatabase);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.labelconnuser);
            this.groupBox1.Controls.Add(this.txtConnuser);
            this.groupBox1.Controls.Add(this.buttonCopiarArquivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura Arquivo Tabela";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(163, 68);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(87, 13);
            this.labelDatabase.TabIndex = 6;
            this.labelDatabase.Text = "Nome Database:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Enabled = false;
            this.txtDatabase.Location = new System.Drawing.Point(256, 65);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(235, 20);
            this.txtDatabase.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(163, 42);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Nome Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(256, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // labelconnuser
            // 
            this.labelconnuser.AutoSize = true;
            this.labelconnuser.Location = new System.Drawing.Point(163, 16);
            this.labelconnuser.Name = "labelconnuser";
            this.labelconnuser.Size = new System.Drawing.Size(63, 13);
            this.labelconnuser.TabIndex = 2;
            this.labelconnuser.Text = "Nome User:";
            // 
            // txtConnuser
            // 
            this.txtConnuser.Enabled = false;
            this.txtConnuser.Location = new System.Drawing.Point(256, 13);
            this.txtConnuser.Name = "txtConnuser";
            this.txtConnuser.Size = new System.Drawing.Size(235, 20);
            this.txtConnuser.TabIndex = 3;
            // 
            // labelconnBase
            // 
            this.labelconnBase.AutoSize = true;
            this.labelconnBase.Location = new System.Drawing.Point(9, 424);
            this.labelconnBase.Name = "labelconnBase";
            this.labelconnBase.Size = new System.Drawing.Size(10, 13);
            this.labelconnBase.TabIndex = 3;
            this.labelconnBase.Text = ".";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(474, 452);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(128, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(340, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.labelconnBase);
            this.Controls.Add(this.groupBoxserial);
            this.Controls.Add(this.groupBoxConfigurarDados);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de dados";
            this.Load += new System.EventHandler(this.FormConfiguracao_Load);
            this.groupBoxConfigurarDados.ResumeLayout(false);
            this.groupBoxConfigurarDados.PerformLayout();
            this.groupBoxserial.ResumeLayout(false);
            this.groupBoxserial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfigurarDados;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label labelcep;
        private System.Windows.Forms.TextBox textBoxcep;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.TextBox textBoxnumero;
        private System.Windows.Forms.Label labelendereco;
        private System.Windows.Forms.TextBox textBoxendereco;
        private System.Windows.Forms.Label labelcnpj;
        private System.Windows.Forms.TextBox textBoxcnpj;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.GroupBox groupBoxserial;
        private System.Windows.Forms.Label labelkey;
        private System.Windows.Forms.TextBox textBoxkey;
        private System.Windows.Forms.Button buttonCopiarArquivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGravarDadosCliente;
        private System.Windows.Forms.Button buttonAtivarKey;
        private System.Windows.Forms.Label labelComputador;
        private System.Windows.Forms.TextBox textBoxComputador;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelconnuser;
        private System.Windows.Forms.TextBox txtConnuser;
        private System.Windows.Forms.Label labelconnBase;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
    }
}