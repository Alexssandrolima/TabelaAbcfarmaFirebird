using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabelaAbcfarmaFirebird.Cls
{
    class PegarData365Dias
    {
        internal static DateTime gerandoDatacom365Dias(DateTime dataFinal)
        {
            DATAFINAL = Convert.ToString(dataFinal);
            //MessageBox.Show("Data que pegou antes de mudar: \n " + DATAFINAL.Substring(0, 10)
            //    + "\n"
            //    + "\n" + DATAFINAL.Substring(0, 2)
            //    + "\n" + DATAFINAL.Substring(3, 2)
            //    + "\n" + DATAFINAL.Substring(6, 4)
            //    );
            try
            {
            int DD = Convert.ToInt32(DATAFINAL.Substring(0, 2));
            int MM = Convert.ToInt32(DATAFINAL.Substring(3, 2));
            int AAAA = Convert.ToInt32(DATAFINAL.Substring(6, 4));

            AAAA += 1;
            DataParaAcabarValidadeSistema = new DateTime(AAAA, MM, DD);
            //MessageBox.Show(" data que vai valer o sistema: " + DataParaAcabarValidadeSistema     );

            return DataParaAcabarValidadeSistema;
            }
            catch(Exception)
            {
                MessageBox.Show(" Formato da data diferente de dd/mm/aaa ", "Formato de dados! " + dataFinal);
                Application.Exit();
                return DataParaAcabarValidadeSistema;
            }
        }


        public static string DATAFINAL { get; set; }

        public static DateTime DataParaAcabarValidadeSistema { get; set; }
    }
}
