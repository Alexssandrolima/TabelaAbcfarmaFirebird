using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabelaAbcfarmaFirebird.Cls
{
    class BuscarValidarDataquantosDiasFalta
    {
        internal static string getvalidarDataquantosdiasfalta(string DATAFINAL)
        {
            string retorno = string.Empty;

            //MessageBox.Show("" + DATAFINAL.Substring(0, 10)
            //    + "\n"
            //    + "\n" + DATAFINAL.Substring(0, 2)
            //    + "\n" + DATAFINAL.Substring(3, 2)
            //    + "\n" + DATAFINAL.Substring(6, 4)
            //    );

            int DD = Convert.ToInt32(DATAFINAL.Substring(0, 2));
            int MM = Convert.ToInt32(DATAFINAL.Substring(3, 2));
            int AAAA = Convert.ToInt32(DATAFINAL.Substring(6, 4));

            DateTime DataParaAcabarValidadeSistema = new DateTime(AAAA, MM, DD);
            retorno = Convert.ToString((int)DataParaAcabarValidadeSistema.Subtract(DateTime.Today).TotalDays);
            return retorno;
        }
    }
}
