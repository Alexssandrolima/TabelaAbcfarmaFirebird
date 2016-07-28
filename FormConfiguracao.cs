using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;  //usar banco de dados dbf.


using System.Configuration;
using TabelaAbcfarmaFirebird.Cls; //usando configuração.
//using System.ComponentModel.DataAnnotations; //chegar os text box.




namespace TabelaAbcfarmaFirebird
{
    public partial class FormConfiguracao : Form
    {
        string USERIP = Environment.ExpandEnvironmentVariables("%USERNAME%");
        string USERNAME = Environment.ExpandEnvironmentVariables("%USERNAME%");

        string USERDOMAIN = Environment.ExpandEnvironmentVariables("%USERDOMAIN%");

        string varSourcePath = Environment.CurrentDirectory + "\\DADOS\\";


        public string arquivoserialPath { get; set; }
        public DataGridView dv { get; set; }

        public FormConfiguracao()
        {
            InitializeComponent();
            arquivoserialPath = Environment.CurrentDirectory + "\\serial.txt";
            txtConnuser.Text = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.User"].ToString();
            txtPassword.Text = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Password"].ToString();
            txtDatabase.Text = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Database"].ToString();

            if (txtConnuser.Text == string.Empty) txtConnuser.Text = "User=SYSDBA";
            if (txtPassword.Text == string.Empty) txtPassword.Text = "Password=masterkey";
            if (txtDatabase.Text == string.Empty) txtDatabase.Text = "DADOS_tabela.FDB";

            labelconnBase.Text = "Database=" + varSourcePath + txtDatabase.Text + ";" + txtConnuser.Text + ";" + txtPassword.Text;
        }

        public FormConfiguracao(string _arquivoserialPath)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.arquivoserialPath = _arquivoserialPath;
            if (txtConnuser.Text == string.Empty) txtConnuser.Text = "User=SYSDBA";
            if (txtPassword.Text == string.Empty) txtPassword.Text = "Password=masterkey";
            if (txtDatabase.Text == string.Empty) txtDatabase.Text = "DADOS_tabela.FDB";

            labelconnBase.Text = "Database=" + varSourcePath + txtDatabase.Text + ";" + txtConnuser.Text + ";" + txtPassword.Text;

        }

        private void buttonVerArquivo_Click(object sender, EventArgs e)
        {
            metodonaoimplementado();
//            OdbcConnection oConn = new OdbcConnection();
//            oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
//                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
//            oConn.Open();
//            OdbcCommand oCmd = oConn.CreateCommand();
//            oCmd.CommandText = @"SELECT MED_ABC FROM c:\dados\tabela.dbf";
//            DataTable dt = new DataTable();
//            dt.Load(oCmd.ExecuteReader());
//            oConn.Close();

            //dv = ClsDbf.GetArquivoDbf();
            
            //dataGridViewTabelaAbcfarma.DataSource = ClsDbf.GetArquivoDbf();

            //dataGridViewTabelaAbcfarma.DataSource = dt;
        }

        private void metodonaoimplementado()
        {
            MessageBox.Show("Não implementado, entre em contato com: \n \r alexssandrolima@gmail.com  \n \r (83) 9 9993 8638 ", " Não Configurado a Implementação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormConfiguracao_Load(object sender, EventArgs e)
        {

            //string nome = Dns.GetHostName();
            //IPAddress[] ip = Dns.GetHostAddresses(nome);
            //MessageBox.Show(ip[1].ToString());
            textBoxnome.Text = USERNAME;
            textBoxComputador.Text = USERDOMAIN;
            //textBoxendereco.Text = ip[1].ToString();


        //<add name="TabelaAbcfarmaLocal.Properties.Settings.Database" connectionString="DADOS_tabela.FDB"/>
        //<add name="TabelaAbcfarmaLocal.Properties.Settings.User" connectionString="User=SYSDBA"/>
        //<add name="TabelaAbcfarmaLocal.Properties.Settings.Password" connectionString="Password=masterkey"/> 


        }

        private void buttonGravarDadosCliente_Click(object sender, EventArgs e)
        {
            //if (textBoxcep.Text != string.Empty && textBoxcnpj.Text != string.Empty && textBoxComputador.Text != string.Empty && textBoxemail.Text != string.Empty && textBoxendereco.Text != string.Empty && textBoxnome.Text != string.Empty && textBoxnumero.Text != string.Empty)
            //{
                MetodoGravarDadosUsuario();
            //}
            //else
            //{
            //    MessageBox.Show(" Faltando dados preenchidos!", " Erro na Execução!");
            //}
        }

        private void MetodoGravarDadosUsuario()
        {

            ClsUsuarioComputador dadosCliente = new ClsUsuarioComputador();
            dadosCliente.Cep = textBoxcep.Text;
            dadosCliente.Cnpj = textBoxcnpj.Text;
            dadosCliente.Computador = textBoxComputador.Text;
            dadosCliente.Email = textBoxemail.Text;
            dadosCliente.Endereco = textBoxendereco.Text;
            dadosCliente.Nome = textBoxnome.Text;
            dadosCliente.Numero = textBoxnumero.Text;
            dadosCliente.Datainicio = DateTime.Now;
            dadosCliente.Datafinal = Cls.PegarData365Dias.gerandoDatacom365Dias(dadosCliente.Datainicio);


            bool Validacaodados = ValidarAluno(dadosCliente);

            if (Validacaodados)
            {
                textBoxkey.Text = Cls.Encrypt.criptografarArquivoRetornar(dadosCliente);
                if (textBoxkey.Text != string.Empty)
                {
                    string retorno = Cls.GravarArquivoSerial.GravarArquivoSerialliberacao(arquivoserialPath, textBoxkey.Text);
                    if (retorno != string.Empty)
                    {
                        MessageBox.Show(" \n " + retorno, "Retorno da aplicação ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //ConfigurationManager.ConnectionStrings.Clear();
                    string conectioStringtxtConnuser = txtConnuser.Text;
                    string conectioStringtxtPassword = txtPassword.Text;
                    string conectioStringtxtDatabase = txtDatabase.Text;

                    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    // Get the connection strings section.
                    ConnectionStringsSection csSection = config.ConnectionStrings;

                    csSection.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.User"].ConnectionString = conectioStringtxtConnuser;
                    csSection.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Password"].ConnectionString = conectioStringtxtPassword;
                    csSection.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Database"].ConnectionString = conectioStringtxtDatabase;
                    config.Save(ConfigurationSaveMode.Modified);
                    // reload the config file so the new values are available

                    ConfigurationManager.RefreshSection(csSection.SectionInformation.Name);




                    //ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.User"].ToString() = txtConnuser.Text;
                    //ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Password"].ToString() = txtPassword.Text;
                    //ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Database"].ToString() = txtDatabase.Text;

                    //ConfigurationManager.ConnectionStrings.Add["TabelaAbcfarmaLocal.Properties.Settings.Database"].ToString() = txtDatabase.Text;

                    //Settings.Default.NomeLocalextensao = textBoxNomeLocalextensao.Text;
                    //Settings.Default.NomedoServicoWindows = textBoxNomedoServicoWindows.Text;
                    //Settings.Default.Save();

                    //Close();

                    textBoxcep.Clear();
                    textBoxcnpj.Clear();
                    textBoxemail.Clear();
                    textBoxendereco.Clear();
                    textBoxnome.Clear();
                    textBoxnumero.Clear();
            }
 


           }

        }

        private bool ValidarAluno(object dadosCliente)
        {
         
            //private void ValidarAluno(object obj)
            var erros = Validacao.getValidationErros(dadosCliente);
	        foreach (var error in erros)
	        {
	            MessageBox.Show((error.ErrorMessage));
                return false;
            }
            return true;
            
        }

        private void buttonAtivarKey_Click(object sender, EventArgs e)
        {
           string retorno = Cls.GravarArquivoSerial.GravarArquivoSerialliberacao(arquivoserialPath, textBoxkey.Text);
           MessageBox.Show(" " + retorno, "Retorno da aplicação ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

    }
}
