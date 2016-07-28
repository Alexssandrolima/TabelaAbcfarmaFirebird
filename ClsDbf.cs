using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data.Odbc;
using System.Data;

namespace TabelaAbcfarmaFirebird
{
    class ClsDbf
    {



        void BtnLeDBFClick(object sender, EventArgs e)
        {
            OdbcConnection oConn = new OdbcConnection();
            oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
            oConn.Open();
            OdbcCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText = @"SELECT * FROM c:\dados\arqDBF.dbf";
            DataTable dt = new DataTable();
            dt.Load(oCmd.ExecuteReader());
            oConn.Close();

            //dataGridView1.DataSource = dt;
        }


//        internal static System.Windows.Forms.DataGridView GetArquivoDbf()
//        {
//            OdbcConnection oConn = new OdbcConnection();
//            oConn.ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=c:\dados\;Exclusive=No;  _
//                                                         Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
//            oConn.Open();
//            OdbcCommand oCmd = oConn.CreateCommand();
//            oCmd.CommandText = @"SELECT * FROM c:\dados\tabela.dbf";
//            DataTable dt = new DataTable();
//            dt.Load(oCmd.ExecuteReader());

//            oConn.Close();
//           // return dt;
//            return ;
//        }

    }
}
