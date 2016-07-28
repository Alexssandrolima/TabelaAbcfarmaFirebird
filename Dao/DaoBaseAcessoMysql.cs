using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;
using FirebirdSql.Data.FirebirdClient;
//using FirebirdSql.Data.FirebirdClient;


namespace TabelaAbcfarmaFirebird.Dao
{
    public class DaoBaseAcessoDbf
    {


        #region "DEIXAR STATICO ACESSO MYSQL"
        private static readonly DaoBaseAcessoDbf instanciaMySql = new DaoBaseAcessoDbf(); // instancia vai dar erro...

        private DaoBaseAcessoDbf() { }    // caso acessar direto nao mostrara nada.
        #endregion

        #region "INSTANCIAR O MYSQL"
        public static DaoBaseAcessoDbf getInstancia()    //INSTANCIAR BANCO DE DADOS....
        {
            return instanciaMySql;
        }
        #endregion

        #region "STRING DE CONEXAO E CONFIGURACAO COM OS DADOS"
        public SqlConnection getConexaoSQL()    // string de conexao com o bando de dados pegando do arquivo config...
        {

                //                    SqlConnection oConn = new SqlConnection();
                //                    oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
                //                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";


                //     string conn = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\tabela.dbf;Exclusive=No;  _
                //                                               Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";


            string conn = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.Setting"].ToString();
            //            string conn = ConfigurationManager.ConnectionStrings["TabelaAbcfarmaLocal.Properties.Settings.SettingMdb"].ToString();
            
                return new SqlConnection(conn);
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
