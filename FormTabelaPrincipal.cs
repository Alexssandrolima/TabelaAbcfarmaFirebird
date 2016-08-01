using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace TabelaAbcfarmaFirebird
{
    public partial class FormTabelaPrincipal : Form
    {

        string USERNAME = Environment.ExpandEnvironmentVariables("%USERNAME%");
        string USERDOMAIN = Environment.ExpandEnvironmentVariables("%USERDOMAIN%");
        string varSourcePath = Environment.CurrentDirectory + "\\";
        public string Descicao { get; set; }
        public static string strquantosdiasfalta { get; set; }
        public string receberDadosTabela = "tabela_dbf";
        public int contando { get; set; }
        public string arquivoserialPath { get; set; }
        public DateTime DATAAGORA { get; set; }
        public string DATAFINAL { get; set; }

        public FormTabelaPrincipal()
        {
 
            InitializeComponent();
        }

        private void tabelaAbcfarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodoVisibletrue();
        }

        ClsUsuarioComputador dadosCliente = new ClsUsuarioComputador();

        private void FormTabelaPrincipal_Load(object sender, EventArgs e)
        {
                dadosCliente = Cls.Decrypt.LerArquivocriptografadoRetornar();
                LbUSERNAME.Text = "Usuário: " + USERNAME;
                LbUSERDOMAIN.Text = "Computador: " + USERDOMAIN;
                LbSystemDrive.Text = "Local: " + varSourcePath;
                LbNomeEmpresa.Text = dadosCliente.Nome;
                DATAFINAL = dadosCliente.Datafinal.ToShortDateString();
                LbCnpjEmpresa.Text = dadosCliente.Cnpj + " | Até: " + DATAFINAL;
                DATAAGORA = DateTime.Now;
                strquantosdiasfalta = Cls.BuscarValidarDataquantosDiasFalta.getvalidarDataquantosdiasfalta(DATAFINAL);

                int numerodedias = Convert.ToInt32(strquantosdiasfalta);

                if (numerodedias > -2)
                {
                    if (numerodedias > -1 && numerodedias < 10)
                    {
                        string textoparatela = " O prazo Esta Espirando \n" +
                                            " \n Falta: " + numerodedias + " Dias. ";
                        MetodoEnviarMensagemnaTela(textoparatela, numerodedias);
                    }
                    this.Text += " | Instalado para " + dadosCliente.Nome + " | " + dadosCliente.Cnpj + " | Até: " + dadosCliente.Datafinal.ToShortDateString();

                    if (numerodedias < 0)
                    {
                        string textoparatela = "Opa! \n Acabou o prazo de validade do Sistema: " + DATAFINAL;
                        MetodoEnviarMensagemnaTela(textoparatela, numerodedias);
                    }
                    preencheGrid();
                }
                
        }

        private void MetodoEnviarMensagemnaTela(string textoparatela, int numerodedias)
        {
            MessageBox.Show(textoparatela +

                " \n \n Entre em contato com Alexssandro Dutra de Lima, \n E-mail: alexssandrolima@gmail.com " +
                " \n ou pelos Fones: Tim (83) 9 9993-8638, Oi (83) 9 87870934"
                ,"Entre em Contato com o Administrador do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void preencheGrid()
        {
            string colunasdatabela = Properties.Settings.Default.tbtabela;
            string tabeladbf = Properties.Settings.Default.bancodedados;
            try
            {
                dataGridViewTabelaAbcfarma.DataSource = Dao.DaoAcessoDbf.Fb_GetSepararDados(colunasdatabela).DefaultView;
                contando =  dataGridViewTabelaAbcfarma.RowCount;
                labelCount.Text = "N°: " + Convert.ToString( contando);
                textBoxDescicao.Focus();
                textBoxDescicao.Select();
            }
            catch (Exception ex)
            {
#if DEBUG
                {
                    MessageBox.Show("\n " + ex, "Erro preencher Grid", MessageBoxButtons.OK,MessageBoxIcon.Warning);                    
                }
#else
                {
                    MessageBox.Show("\n \n Olá, ao buscar dados, ocorreu um Erro! \n Lique Alex, Fone: (83) 9 9993-8638 \n \n" + ex.Message, "Erro de Acesso a Tabela ao preencher Grid", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                }
#endif
                Close();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodoVisiblefalso();
            groupBoxPesquisa.Visible = true;
        }

        private void metodoVisibletrue()
        {
            groupBoxPesquisa.Visible = true;
            dataGridViewTabelaAbcfarma.Visible = true;
            buttonSair.Visible = true;
        }

        private void metodoVisiblefalso()
        {
            groupBoxPesquisa.Visible = false;
            dataGridViewTabelaAbcfarma.Visible = false;
            buttonSair.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodoVisiblefalso();
            FormConfiguracao configurar = new FormConfiguracao();
            configurar.ShowDialog();
            metodoVisibletrue();
        }
        private void executarpesquisa()
        {
            ClsObjetoTabela dadosdatabela = new ClsObjetoTabela();
            try
            {
                Descicao = textBoxDescicao.Text;

                if (Descicao != string.Empty)
                {

                    dataGridViewTabelaAbcfarma.DataSource = Dao.DaoAcessoDbf.MySql_ProcuraArrayDadosOrdNome(receberDadosTabela, Descicao, "MED_DES");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r \n Ao Procurar na pesquisa! ", "Retorno de Pesquisa ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pesquisaDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            executarpesquisa(textBoxDescicao.Text);
        }

        private void executarpesquisa(string pesquisarletrasDescricao)
        {
            ClsObjetoTabela dadosdatabela = new ClsObjetoTabela();
            try
            {
                if (pesquisarletrasDescricao != string.Empty)
                {
                    dataGridViewTabelaAbcfarma.DataSource = Dao.DaoAcessoDbf.Fb_ProcuraArrayDadosOrdNome(receberDadosTabela, pesquisarletrasDescricao, "MED_DES");
                    contando = dataGridViewTabelaAbcfarma.RowCount;
                    labelCount.Text = "N°: " + Convert.ToString(contando);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r \n Ao Procurar pela pesquisa ", "Retorno da Pesquisa ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void keyUpDatagrid(object sender, KeyEventArgs e)
        {
//            textBoxDescicao.Focus();
//            textBoxDescicao.Select();
        }

    }
}
