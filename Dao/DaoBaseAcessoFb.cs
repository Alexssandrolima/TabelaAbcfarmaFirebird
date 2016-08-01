using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;
//using System.Data.SqlClient;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;
using System.IO;


namespace TabelaAbcfarmaFirebird.Dao
{
    public class DaoBaseAcessoFb
    {
        string varSourcePath = Environment.CurrentDirectory + "\\DADOS\\";

         #region "DEIXAR STATICO ACESSO FB"
        private static readonly DaoBaseAcessoFb instanciaFb = new DaoBaseAcessoFb(); // instancia vai dar erro...

        private DaoBaseAcessoFb() { }    // caso acessar direto nao mostrara nada.
        #endregion

        #region "INSTANCIAR O MYSQL"
        public static DaoBaseAcessoFb getInstancia()    //INSTANCIAR BANCO DE DADOS....
        {
            return instanciaFb;
        }
        #endregion

        #region "STRING DE CONEXAO E CONFIGURACAO COM OS DADOS"
        public FbConnection getConexaoSQL()    // string de conexao com o bando de dados pegando do arquivo config...
        {
            //                    SqlConnection oConn = new SqlConnection();
            //                    oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
            //                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";


            //     string conn = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\tabela.dbf;Exclusive=No;  _
            //                                               Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
            string connuser = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.User"].ToString();
            MessageBox.Show(@" connuser: " + connuser);

                string connPassword = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Password"].ToString();
                MessageBox.Show(@" connPassword: " + connPassword);
                string connDatabase = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Database"].ToString();
                MessageBox.Show(@" connPassword: " + connDatabase);
                string conn = "Database=" + varSourcePath + connDatabase + ";" + connuser + ";" + connPassword;
                MessageBox.Show(@" conn: " + conn);

                //string conn2 = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Setting"].ToString();
                //            string conn = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.SettingMdb"].ToString();
                if (connuser == string.Empty) MessageBox.Show(@" connuser: " + connuser);
                if (connPassword == string.Empty) MessageBox.Show(@" connPassword: " + connPassword);
                if (connDatabase == string.Empty) MessageBox.Show(@" connDatabase: " + connDatabase);
                //MessageBox.Show(@" conn: " + conn);
                return new FbConnection(conn);

        }
        //public FbConnection getConexaoFB()    // string de conexao com o bando de dados pegando do arquivo config...
        //{

        //    //                    SqlConnection oConn = new SqlConnection();
        //    //                    oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
        //    //                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";


        //    //     string conn = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\tabela.dbf;Exclusive=No;  _
        //    //                                               Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";


        //    string conn = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Setting"].ToString();
        //    //            string conn = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.SettingMdb"].ToString();

        //    return new FbConnection(conn);
        //}
        #endregion


    }
}
