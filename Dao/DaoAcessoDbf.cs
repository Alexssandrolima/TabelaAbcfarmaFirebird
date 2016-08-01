using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using FirebirdSql.Data.FirebirdClient;


namespace TabelaAbcfarmaFirebird.Dao
{
    class DaoAcessoDbf
    {


        #region "CHAMAR DADOS DO CADASTRAO DE USUARIO PARA VERIFICAR SENHAS E USUARIO"
        internal static object MySql_GetUsuarioseAdmin(string receberDadosTabela, ClsObjetoTabela tabeladedados, bool Logadonosistemaretorno)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    //ClsObjetoTabela tabeladedados = new ClsObjetoTabela();
                    conexaoMySql.Open();
                    string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + tabeladedados.Med_des + "\" AND `senha` = \"" + tabeladedados.Med_abc + "\"";
                    //            string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = @usudesc AND `name` = @ususenha";
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                    //cmd.Parameters.Add("@usudesc", MySqlDbType.VarChar).Value = tabeladedados.NOME;
                    //cmd.Parameters.Add("@ususenha", MySqlDbType.VarChar).Value = tabeladedados.SENHA;
                    //             SqlDataReader dr = cmd.ExecuteReader();
                    //SqlDataReader reader = null;
                    //reader = cmd.ExecuteReader(); // ler arquivo de banco de cados....
                    SqlDataReader reader = cmd.ExecuteReader();
                    Logadonosistemaretorno = reader.Read();
                    return (Logadonosistemaretorno);
                }
                catch (OdbcException msqlex)
                {
                    //MessageBox.Show("Erro N° " + msqlex.Number + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ","Espere um pouco ");
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "CHAMAR TODOS DADOS funcionarios"
        public static DataTable MySql_GetDados(string receberDadosTabela)  //metodo de chamar os dados da classe RECEBER /// cliente/produtos.
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();                         //abre a conexao...
                    string mSQL = "Select * from " + receberDadosTabela;         //seleciona tudo da
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    SqlDataAdapter da = new SqlDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (OdbcException msqlex)
                {
                    switch (msqlex.ErrorCode)
                    {
                        case 0:
                            MessageBox.Show("Não é possível conectar ao servidor, por favor, tente novamente", " Contate o administrador");
                            break;

                        case 1045:
                            MessageBox.Show("Nome de usuário / senha inválida , por favor, tente novamente", " Contate o administrador");
                            break;

                        case 1042:
                            MessageBox.Show("Não é possível conectar ao servidor \n por favor,\n Ao inicializar o servidor tente novamente ", " Contate o administrador");
                            break;
                    }
                    //MessageBox.Show(msqlex.Number + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ","Espere um pouco ");
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "INSERIR DADOS NA TABELA DO BANCO DE DADOS"
        internal static void MySql_InserirDados(string receberDadosTabela, ClsObjetoTabela dadosdatabela)
        {
            //MessageBox.Show("RECEBEU -> " + receberDadosTabela + " - "+ dadosdatabela);
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();
                    //PEGAR NO NOME usuario PARA INSERIR VALUES...
                    // string query = "INSERT INTO usuario (name, grupo) VALUES('John Smith', 'ADM')";

                    if (receberDadosTabela == "tbusuario")
                    {
                        //MessageBox.Show("USUARIO -> " + receberDadosTabela + " - " + dadosdatabela);
                        string mSQL = "INSERT INTO " + receberDadosTabela + " (name, grupo) VALUES('" + dadosdatabela.Med_des +"','" + dadosdatabela.Med_abc + "')";
                        SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OdbcException MYex)
                {
                    throw MYex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "EXCLUIR DADOS CLIENTES"
        internal static void MySql_EcluirDados(string receberDadosTabela, int NumerodoId)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();
                    // DELETETAR DADOS usuarios
                    string mSQL = "DELETE FROM `" + receberDadosTabela + "` WHERE id = " + NumerodoId;
                    //string mSQL = "DELETE from   usuario Were id= " + Id;
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                    cmd.ExecuteNonQuery();
                }
                catch (OdbcException Myfbex)
                {
                    throw Myfbex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "PROCURAR DADOS DOS UNICO por codigos"
        internal static ClsObjetoTabela MySql_ProcuraDados(string receberDadosTabela, int NumerodoId)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();
                    string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE id = " + NumerodoId;
                    //MessageBox.Show("SELECT * FROM `" + receberDadosTabela + "` WHERE id = " + NumerodoId);
                    //string mSQL = "SELECT * FROM `usuario` WHERE id = " + NumerodoId;
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                    SqlDataReader dr = cmd.ExecuteReader();
                    ClsObjetoTabela dadosdatabela = new ClsObjetoTabela();
                    if (receberDadosTabela == "tbusuario")
                    {
                        while (dr.Read())
                        {
                            //dadosdatabela.Lab_nom = Convert.ToInt32(dr[0]);
                            dadosdatabela.Lab_nom = dr[0].ToString();
                            dadosdatabela.Med_des = dr[1].ToString();
                            dadosdatabela.Med_princi = dr[2].ToString();
                        }
                    }
                    return dadosdatabela;
                }
                catch (OdbcException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "PROCURAR DADOS NA TABELA POR NOME E RETORNA UM NOME"
        internal static object MySql_ProcuraDadosNome(string receberDadosTabela, string NomedoTabela)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();
                    //string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` like \"%" + nome + "%\" ORDER BY `name` ASC";
                    //MessageBox.Show("string mSQL = SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + NomedoTabela + "\"");
                    string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + NomedoTabela + "\"";
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                    SqlDataReader dr = cmd.ExecuteReader();
                    ClsObjetoTabela dadosdatabela = new ClsObjetoTabela();
                    if (receberDadosTabela == "tbusuario")
                    {
                        while (dr.Read())
                        {
                            dadosdatabela.Lab_nom = dr[0].ToString();
                            dadosdatabela.Med_des = dr[1].ToString();
                            dadosdatabela.Med_princi = dr[2].ToString();
                        }
                    }
                    return dadosdatabela;
                }
                catch (OdbcException msqlex)
                {
                    switch (msqlex.ErrorCode)
                    {
                        case 0:
                            MessageBox.Show("Não é possível conectar ao servidor, por favor, tente novamente", " Contate o administrador");
                            break;

                        case 1045:
                            MessageBox.Show("Nome de usuário / senha inválida , por favor, tente novamente", " Contate o administrador");
                            break;

                        case 1042:
                            MessageBox.Show("Não é possível conectar ao servidor \n por favor,\n Ao inicializar o servidor tente novamente ", " Contate o administrador");
                            break;

                        case 1064:
                            MessageBox.Show("You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near", " Contate o administrador");
                            break;
                    }
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "CHAMAR OS DADOS UNITARIOS DO BANCO DE DADOS"
        internal static object MySql_GetDadosUnitario(string receberDadosTabela, int NumerodoId)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    //MessageBox.Show("MYSQL RECEB -> "+ receberDadosTabela +" -> "+ NumerodoId);
                    conexaoMySql.Open();                         //abre a conexao...
                    string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE id = " + NumerodoId;
                    //string mSQL = "SELECT * FROM `usuario` WHERE id = " + NumerodoId;
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    SqlDataAdapter da = new SqlDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (OdbcException msqlex)
                {
                    MessageBox.Show(msqlex.ErrorCode + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ", "Espere um pouco ");
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "Modificar e alterar Dados da tabela"
        internal static void MySql_AlterarDados(string receberDadosTabela, ClsObjetoTabela tabeladedados)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();
                    //string mSQL = "INSERT INTO usuario (name, grupo) VALUES('" + usuario.NOME + "','" + usuario.GRUPO + "')";
                    //               UPDATE usuario SET name = 'ALTERADO', grupo = 'USER' WHERE id = 14;
                    if (receberDadosTabela == "tbusuario")
                    {
                        //MessageBox.Show("string mSQL = UPDATE " + receberDadosTabela + " SET name = '" + tabeladedados.NOME + "', grupo = '" + tabeladedados.GRUPO + "'" + " WHERE id= " + tabeladedados.ID);
                        string mSQL = "UPDATE " + receberDadosTabela + " SET name = '" + tabeladedados.Lab_nom + "', grupo = '" + tabeladedados.Med_apr + "'" + " WHERE id= " + tabeladedados.Med_princi;
                        SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OdbcException MySqlex)
                {
                    //MessageBox.Show("error no -> " + MySqlex);

                    throw MySqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "CHAMAR OS DADOS DO BANCO E RETORNA UMA Array"
        public static DataTable MySql_ProcuraArrayDadosOrdNome(string receberDadosTabela, string NomedoTabela, string MEDTabela)  //metodo de chamar os dados da classe RECEBER /// cliente/produtos.
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                string colunasdatabela = Properties.Settings.Default.tbtabela;

                try
                {
                    conexaoMySql.Open();
                    // string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + NomedoTabela + "\"";

                   // SELECT  MED_DES,MED_APR FROM tabela WHERE MED_DES LIKE 'AAS%'

                    //SELECT [MED_PRINCI],[MED_DES] FROM [tabela].[dbo].[tabela] WHERE [MED_PRINCI] LIKE '%ASo%' ORDER BY [MED_PRINCI] ASC

                    string mSQL = "SELECT " + colunasdatabela + " FROM " + receberDadosTabela + " WHERE " + MEDTabela + " LIKE \'%" + NomedoTabela + "%\' ORDER BY " + MEDTabela + " ASC";
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    SqlDataAdapter da = new SqlDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //return dt;
                    DataSet DS = new DataSet();
                    da.Fill(DS);
                    return DS.Tables[0];
                }
                catch (OdbcException msqlex)
                {
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }

        public static DataTable Fb_ProcuraArrayDadosOrdNome(string receberDadosTabela, string NomedoTabela, string MEDTabela)  //metodo de chamar os dados da classe RECEBER /// cliente/produtos.
        {
            using (FbConnection conexaoMySql = Dao.DaoBaseAcessoFb.getInstancia().getConexaoSQL())
            {
                string colunasdatabela = Properties.Settings.Default.tbtabela;

                try
                {
                    conexaoMySql.Open();
                    // string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + NomedoTabela + "\"";

                    // SELECT  MED_DES,MED_APR FROM tabela WHERE MED_DES LIKE 'AAS%'

                    //SELECT [MED_PRINCI],[MED_DES] FROM [tabela].[dbo].[tabela] WHERE [MED_PRINCI] LIKE '%ASo%' ORDER BY [MED_PRINCI] ASC

                    //                <value>MED_ABC,MED_DES,MED_APR,MED_PRINCI,MED_PLA1,MED_PCO1,LAB_NOM,MED_BARRA,MED_FRA1</value>



                    string mSQL = "Select " + colunasdatabela + " from " +
                        receberDadosTabela 
                        + " where upper(MED_DES) like upper('" + NomedoTabela 
                        + "%') or upper(MED_PRINCI) like upper('%" + NomedoTabela
                        + "%') or upper(MED_ABC) like upper('" + NomedoTabela
                        + "%') or upper(MED_BARRA) like upper('" + NomedoTabela
                        + "%') or upper(LAB_NOM) like upper('" + NomedoTabela
                        //+ "%')or upper(MED_APR) like upper('%" + NomedoTabela 
                        + "%') ORDER BY " + MEDTabela + " ASC";         //seleciona tudo da


//                    string mSQL = "SELECT " + colunasdatabela + " FROM " + receberDadosTabela + " WHERE " + MEDTabela + " LIKE upper('%" + NomedoTabela + "%'), "+ MEDTabela + " LIKE upper('%" + NomedoTabela + "%') ORDER BY " + MEDTabela + " ASC";
//                    string mSQL = "SELECT " + colunasdatabela + " FROM " + receberDadosTabela + " WHERE " + MEDTabela + " LIKE \'%" + NomedoTabela + "%\' ORDER BY " + MEDTabela + " ASC";
                    FbCommand cmd = new FbCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    FbDataAdapter da = new FbDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //return dt;
                    DataSet DS = new DataSet();
                    da.Fill(DS);
                    return DS.Tables[0];
                }
                catch (OdbcException msqlex)
                {
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion

        #region "CHAMAR COLUNAS SEPARADAS DOS DADOS Mysql"
        public static DataTable MySql_GetSepararDados(string colunasdatabela)  //metodo de chamar os dados da classe RECEBER /// cliente/produtos.
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {

                //MessageBox.Show("" + conexaoMySql);
                try
                {
                    //                    SqlConnection oConn = new SqlConnection();
                    //                    oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
                    //                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
                    //                    oConn.Open();
                    //                    SqlCommand oCmd = oConn.CreateCommand();
                    //                    oCmd.CommandText = @"SELECT MED_ABC FROM c:\dados\tabela.dbf";
                    //                    DataTable dt = new DataTable();
                    //                    dt.Load(oCmd.ExecuteReader());

                    //                    oConn.Close();

                    conexaoMySql.Open();
                    //abre a conexao...
                    // SELECT `id`, `name`, `grupo` FROM `tbusuario` WHERE 1
                    //LAB_NOM,C,30 nome do produto
                    //MED_DES,C,45 descricao do produto
                    //MED_APR,C,45  apreciação
                    //MED_PCO1,N,12,2  preço de venda
                    //MED_FRA1,N,12,2  preço fracionado
                    //MED_PRINCI,C,130  printipio ativo
                    //MED_BARRA,N,13,0  codigo de barra


                    //oCmd.CommandText = @"SELECT MED_ABC FROM c:\dados\tabela.dbf";
                    //string mSQL = @"SELECT MED_ABC FROM c:\dados\tabela.dbf";         //seleciona tudo da

                        //string mSQL = "Select " + colunasdatabela + " from " + receberDadosTabela;         //seleciona tudo da

                    string mSQL = "Select "+ colunasdatabela +" from tabela";         //seleciona tudo da
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    SqlDataAdapter da = new SqlDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                //catch (ConfigurationErrorsException ex)
                //{
                //    MessageBox.Show(ex + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ", "Espere um pouco ");
                    
                //}
                catch (OdbcException msqlex)
                {
                    MessageBox.Show(msqlex.Message + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ", "Espere um pouco ");
                    throw msqlex;
                }
                catch (SqlException msqlex)
                {
                    MessageBox.Show(msqlex.Message + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ", "Espere um pouco ");
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }

        public static DataTable Fb_GetSepararDados(string colunasdatabela)  //metodo de chamar os dados da classe RECEBER /// cliente/produtos.
        {
            //MessageBox.Show("" + colunasdatabela);
            using (FbConnection conexaoMySql = DaoBaseAcessoFb.getInstancia().getConexaoSQL())
            {
                //MessageBox.Show("" + conexaoMySql.ConnectionString);
                try
                {
                    conexaoMySql.Open();
                    string mSQL = "Select " + colunasdatabela + " from tabela_dbf";         //seleciona tudo da
                    FbCommand cmd = new FbCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    FbDataAdapter da = new FbDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (OdbcException msqlex)
                {
                    MessageBox.Show(msqlex.Message + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ", "Espere um pouco ");
                    throw msqlex;
                }
                catch (FbException msqlex)
                {
                    MessageBox.Show(msqlex.Message + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ", "Espere um pouco ");
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion


        //        public static string pegaradministradordosistema { get; set; }


        //    SqlDataReader reader = cmd.ExecuteReader();
        //MessageBox.Show("PEGOU O REACER DO COMANDO -> 1 " + reader);
        //    while (reader.Read())
        //    {

        //        tabeladedados.ID = Convert.ToInt32(reader[0]);
        //        tabeladedados.NOME = reader[1].ToString();
        //        tabeladedados.GRUPO = reader[2].ToString();
        //        MessageBox.Show("TABELA DE DADOS \n " 
        //            + tabeladedados.ID 
        //            + tabeladedados.NOME
        //            + tabeladedados.GRUPO);


        //    }
        //    if (tabeladedados.GRUPO != reader[2].ToString())
        //    {
        //        //MessageBox.Show("PEGOU O REACER DO COMANDO -> 1 " + reader.Read());
        //        pegaradministradordosistema = tabeladedados.GRUPO;
        //    }

        #region "CHAMAR COLUNAS SEPARADAS DOS DADOS funcionarios"
        internal static string MySql_ProcuraDadosadminstrador(string receberDadosTabela, string NomedoTabela)
        {
            using (SqlConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoSQL())
            {
                try
                {
                    conexaoMySql.Open();
                    string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + NomedoTabela + "\"";
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
                    SqlDataReader dr = cmd.ExecuteReader();
                    ClsObjetoTabela dadosdatabela = new ClsObjetoTabela();
                    if (receberDadosTabela == "tbusuario")
                    {
                        while (dr.Read())
                        {
                            dadosdatabela.Lab_nom = dr[0].ToString();
                            dadosdatabela.Med_des = dr[1].ToString();
                            dadosdatabela.Med_princi = dr[2].ToString();
                        }
                    }
                    return dadosdatabela.Med_princi;
                }
                catch (OdbcException msqlex)
                {
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion



        //internal static object MySql_GetSepararDados(string colunasdatabela, string tabeladbf)
        //{

        //    using (FbConnection conexaoMySql = Dao.DaoBaseAcessoDbf.getInstancia().getConexaoFB())
        //    {
        //        try
        //        {
        //            //ClsObjetoTabela tabeladedados = new ClsObjetoTabela();
        //            conexaoMySql.Open();
        //            string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = \"" + tabeladedados.Med_des + "\" AND `senha` = \"" + tabeladedados.Med_abc + "\"";
        //            //            string mSQL = "SELECT * FROM `" + receberDadosTabela + "` WHERE `name` = @usudesc AND `name` = @ususenha";
        //            SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql);
        //            //cmd.Parameters.Add("@usudesc", MySqlDbType.VarChar).Value = tabeladedados.NOME;
        //            //cmd.Parameters.Add("@ususenha", MySqlDbType.VarChar).Value = tabeladedados.SENHA;
        //            //             SqlDataReader dr = cmd.ExecuteReader();
        //            //SqlDataReader reader = null;
        //            //reader = cmd.ExecuteReader(); // ler arquivo de banco de cados....
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            Logadonosistemaretorno = reader.Read();
        //            return (Logadonosistemaretorno);
        //        }
        //        catch (OdbcException msqlex)
        //        {
        //            //MessageBox.Show("Erro N° " + msqlex.Number + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ","Espere um pouco ");
        //            throw msqlex;
        //        }
        //        finally
        //        {
        //            conexaoMySql.Close();
        //        }
        //    }
        //}


    }
}
