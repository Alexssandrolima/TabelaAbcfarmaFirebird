namespace TabelaAbcfarmaFirebird
{
    partial class FormTabelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.statusStripRodape = new System.Windows.Forms.StatusStrip();
            this.LbUSERNAME = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbUSERDOMAIN = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbSystemDrive = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBarra = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbNomeEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbCnpjEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescicao = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.dataGridViewTabelaAbcfarma = new System.Windows.Forms.DataGridView();
            this.MED_ABC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_DES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_APR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_PLA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_PCO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_FRA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_PRINCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_BARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAB_NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.tabelaAbcfarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            this.statusStripRodape.SuspendLayout();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaAbcfarma)).BeginInit();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.statusStripRodape);
            this.panelPrincipal.Controls.Add(this.groupBoxPesquisa);
            this.panelPrincipal.Controls.Add(this.buttonSair);
            this.panelPrincipal.Controls.Add(this.dataGridViewTabelaAbcfarma);
            this.panelPrincipal.Controls.Add(this.menuStripPrincipal);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1054, 514);
            this.panelPrincipal.TabIndex = 0;
            // 
            // statusStripRodape
            // 
            this.statusStripRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbUSERNAME,
            this.LbUSERDOMAIN,
            this.LbSystemDrive,
            this.toolStripStatusLabelBarra,
            this.LbNomeEmpresa,
            this.toolStripStatusLabel2,
            this.LbCnpjEmpresa,
            this.toolStripStatusLabel4,
            this.labelCount});
            this.statusStripRodape.Location = new System.Drawing.Point(0, 492);
            this.statusStripRodape.Name = "statusStripRodape";
            this.statusStripRodape.Size = new System.Drawing.Size(1054, 22);
            this.statusStripRodape.TabIndex = 6;
            this.statusStripRodape.Text = "statusStrip1";
            // 
            // LbUSERNAME
            // 
            this.LbUSERNAME.Name = "LbUSERNAME";
            this.LbUSERNAME.Size = new System.Drawing.Size(81, 17);
            this.LbUSERNAME.Text = "LbUSERNAME";
            // 
            // LbUSERDOMAIN
            // 
            this.LbUSERDOMAIN.Name = "LbUSERDOMAIN";
            this.LbUSERDOMAIN.Size = new System.Drawing.Size(95, 17);
            this.LbUSERDOMAIN.Text = "LbUSERDOMAIN";
            // 
            // LbSystemDrive
            // 
            this.LbSystemDrive.Name = "LbSystemDrive";
            this.LbSystemDrive.Size = new System.Drawing.Size(85, 17);
            this.LbSystemDrive.Text = "LbSystemDrive";
            // 
            // toolStripStatusLabelBarra
            // 
            this.toolStripStatusLabelBarra.Name = "toolStripStatusLabelBarra";
            this.toolStripStatusLabelBarra.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabelBarra.Text = "|";
            // 
            // LbNomeEmpresa
            // 
            this.LbNomeEmpresa.Name = "LbNomeEmpresa";
            this.LbNomeEmpresa.Size = new System.Drawing.Size(98, 17);
            this.LbNomeEmpresa.Text = "LbNomeEmpresa";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // LbCnpjEmpresa
            // 
            this.LbCnpjEmpresa.Name = "LbCnpjEmpresa";
            this.LbCnpjEmpresa.Size = new System.Drawing.Size(90, 17);
            this.LbCnpjEmpresa.Text = "LbCnpjEmpresa";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // labelCount
            // 
            this.labelCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(24, 17);
            this.labelCount.Text = "N°:";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.labelDescricao);
            this.groupBoxPesquisa.Controls.Add(this.textBoxDescicao);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(12, 27);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(1030, 56);
            this.groupBoxPesquisa.TabIndex = 4;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Pesquisa";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 24);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(294, 13);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "Descrição / Apresentação / Principio / Laboratório / Código:";
            // 
            // textBoxDescicao
            // 
            this.textBoxDescicao.Location = new System.Drawing.Point(306, 21);
            this.textBoxDescicao.Name = "textBoxDescicao";
            this.textBoxDescicao.Size = new System.Drawing.Size(718, 20);
            this.textBoxDescicao.TabIndex = 4;
            this.textBoxDescicao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaDescricao_KeyUp);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.Location = new System.Drawing.Point(967, 466);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sai&r";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // dataGridViewTabelaAbcfarma
            // 
            this.dataGridViewTabelaAbcfarma.AllowUserToAddRows = false;
            this.dataGridViewTabelaAbcfarma.AllowUserToDeleteRows = false;
            this.dataGridViewTabelaAbcfarma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabelaAbcfarma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelaAbcfarma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MED_ABC,
            this.MED_DES,
            this.MED_APR,
            this.MED_PLA1,
            this.MED_PCO1,
            this.MED_FRA1,
            this.MED_PRINCI,
            this.MED_BARRA,
            this.LAB_NOM});
            this.dataGridViewTabelaAbcfarma.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewTabelaAbcfarma.Name = "dataGridViewTabelaAbcfarma";
            this.dataGridViewTabelaAbcfarma.ReadOnly = true;
            this.dataGridViewTabelaAbcfarma.Size = new System.Drawing.Size(1030, 371);
            this.dataGridViewTabelaAbcfarma.TabIndex = 1;
            this.dataGridViewTabelaAbcfarma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpDatagrid);
            // 
            // MED_ABC
            // 
            this.MED_ABC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MED_ABC.DataPropertyName = "MED_ABC";
            this.MED_ABC.HeaderText = "Codigo";
            this.MED_ABC.Name = "MED_ABC";
            this.MED_ABC.ReadOnly = true;
            this.MED_ABC.Width = 65;
            // 
            // MED_DES
            // 
            this.MED_DES.DataPropertyName = "MED_DES";
            this.MED_DES.HeaderText = "Descrição";
            this.MED_DES.Name = "MED_DES";
            this.MED_DES.ReadOnly = true;
            this.MED_DES.Width = 200;
            // 
            // MED_APR
            // 
            this.MED_APR.DataPropertyName = "MED_APR";
            this.MED_APR.HeaderText = "Apresentação";
            this.MED_APR.Name = "MED_APR";
            this.MED_APR.ReadOnly = true;
            this.MED_APR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MED_APR.Width = 200;
            // 
            // MED_PLA1
            // 
            this.MED_PLA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MED_PLA1.DataPropertyName = "MED_PLA1";
            this.MED_PLA1.HeaderText = "Preço Compra";
            this.MED_PLA1.Name = "MED_PLA1";
            this.MED_PLA1.ReadOnly = true;
            this.MED_PLA1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MED_PLA1.Width = 99;
            // 
            // MED_PCO1
            // 
            this.MED_PCO1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MED_PCO1.DataPropertyName = "MED_PCO1";
            this.MED_PCO1.HeaderText = "Preço Venda";
            this.MED_PCO1.Name = "MED_PCO1";
            this.MED_PCO1.ReadOnly = true;
            this.MED_PCO1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MED_PCO1.Width = 94;
            // 
            // MED_FRA1
            // 
            this.MED_FRA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MED_FRA1.DataPropertyName = "MED_FRA1";
            this.MED_FRA1.HeaderText = "Valor Fração";
            this.MED_FRA1.Name = "MED_FRA1";
            this.MED_FRA1.ReadOnly = true;
            this.MED_FRA1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MED_FRA1.Width = 92;
            // 
            // MED_PRINCI
            // 
            this.MED_PRINCI.DataPropertyName = "MED_PRINCI";
            this.MED_PRINCI.HeaderText = "Principio Ativo";
            this.MED_PRINCI.Name = "MED_PRINCI";
            this.MED_PRINCI.ReadOnly = true;
            this.MED_PRINCI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MED_PRINCI.Width = 400;
            // 
            // MED_BARRA
            // 
            this.MED_BARRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MED_BARRA.DataPropertyName = "MED_BARRA";
            this.MED_BARRA.HeaderText = "Cod Barra";
            this.MED_BARRA.Name = "MED_BARRA";
            this.MED_BARRA.ReadOnly = true;
            this.MED_BARRA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MED_BARRA.Width = 79;
            // 
            // LAB_NOM
            // 
            this.LAB_NOM.DataPropertyName = "LAB_NOM";
            this.LAB_NOM.HeaderText = "Laboratório";
            this.LAB_NOM.Name = "LAB_NOM";
            this.LAB_NOM.ReadOnly = true;
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaAbcfarmaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1054, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStripPrincipal";
            // 
            // tabelaAbcfarmaToolStripMenuItem
            // 
            this.tabelaAbcfarmaToolStripMenuItem.Name = "tabelaAbcfarmaToolStripMenuItem";
            this.tabelaAbcfarmaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.tabelaAbcfarmaToolStripMenuItem.Text = "&Tabela Abcfarma";
            this.tabelaAbcfarmaToolStripMenuItem.Click += new System.EventHandler(this.tabelaAbcfarmaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Con&figuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormTabelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 514);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormTabelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela Abcfarma Local";
            this.Load += new System.EventHandler(this.FormTabelaPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.statusStripRodape.ResumeLayout(false);
            this.statusStripRodape.PerformLayout();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaAbcfarma)).EndInit();
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tabelaAbcfarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescicao;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridView dataGridViewTabelaAbcfarma;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_ABC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_DES;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_APR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_PLA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_PCO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_FRA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_PRINCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_BARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAB_NOM;
        private System.Windows.Forms.StatusStrip statusStripRodape;
        private System.Windows.Forms.ToolStripStatusLabel labelCount;
        private System.Windows.Forms.ToolStripStatusLabel LbUSERNAME;
        private System.Windows.Forms.ToolStripStatusLabel LbSystemDrive;
        private System.Windows.Forms.ToolStripStatusLabel LbUSERDOMAIN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBarra;
        private System.Windows.Forms.ToolStripStatusLabel LbNomeEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel LbCnpjEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

