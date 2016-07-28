using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Windows.Forms;


namespace TabelaAbcfarmaFirebird.Cls
{
    class ValidarCnpjCpf
    {

        internal static bool ValidarCnpjObjetoDigitado(string valorCnpj)
        {
            valorCnpj = valorCnpj.Trim();
            valorCnpj = valorCnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (valorCnpj == string.Empty)
            {
                MessageBox.Show("Por favor, preencha o campo \"CNPJ\"." + valorCnpj);
                return (false);
            }
            if (valorCnpj == "00000000000000")
            {
                MessageBox.Show("Valor de \"CNPJ\" inválido.");
                return (false);
            }

            if (valorCnpj.Length < 14)
            {
                MessageBox.Show("Por favor, preencha o campo \"CNPJ\" com 14 dígitos.");
                return (false);
            }

            if (valorCnpj.Length > 14)
            {
                MessageBox.Show("Por favor, preencha o campo \"CNPJ\" com 14 dígitos.");
                return (false);
            }
            const string checkOk = "0123456789";
            var checkStr = valorCnpj;
            var allValid = true;
            //int decPoints = 0;
            var allNum = "";
            int i;
            int j;
            for (i = 0; i < checkStr.Length; i++)
            {
                var ch = int.Parse(checkStr.Substring(i, 1));
                for (j = 0; j < checkOk.Length; j++)
                    if (ch == int.Parse(checkOk.Substring(j, 1)))
                        break;
                if (j == checkOk.Length)
                {
                    allValid = false;
                    break;
                }
                allNum += ch;
            }
            if (!allValid)
            {
                MessageBox.Show("Por favor, preencha o campo \"CNPJ\" apenas com dígitos.");
                return (false);
            }

            string cgc = valorCnpj;
            int cgc01 = Convert.ToInt16(cgc.Substring(0, 1));
            int cgc02 = Convert.ToInt16(cgc.Substring(1, 1));
            int cgc03 = Convert.ToInt16(cgc.Substring(2, 1));
            int cgc04 = Convert.ToInt16(cgc.Substring(3, 1));
            int cgc05 = Convert.ToInt16(cgc.Substring(4, 1));
            int cgc06 = Convert.ToInt16(cgc.Substring(5, 1));
            int cgc07 = Convert.ToInt16(cgc.Substring(6, 1));
            int cgc08 = Convert.ToInt16(cgc.Substring(7, 1));
            int cgc09 = Convert.ToInt16(cgc.Substring(8, 1));
            int cgc10 = Convert.ToInt16(cgc.Substring(9, 1));
            int cgc11 = Convert.ToInt16(cgc.Substring(10, 1));
            int cgc12 = Convert.ToInt16(cgc.Substring(11, 1));
            int cgc13 = Convert.ToInt16(cgc.Substring(12, 1));
            int cgc14 = Convert.ToInt16(cgc.Substring(13, 1));
            decimal aux1 = 10 * (cgc01 * 5 + cgc02 * 4 + cgc03 * 3 + cgc04 * 2 + cgc05 * 9 + cgc06 * 8 +
                       cgc07 * 7 + cgc08 * 6 + cgc09 * 5 + cgc10 * 4 + cgc11 * 3 + cgc12 * 2);
            decimal aux2 = aux1 / 11;
            decimal aux3 = Math.Floor(aux2);
            decimal aux4 = aux3 * 11;
            decimal dv1 = (aux1 - aux4);

            if (dv1 == 10)
            {
                dv1 = 0;
            }
            aux1 = 10 * (cgc01 * 6 + cgc02 * 5 + cgc03 * 4 + cgc04 * 3 + cgc05 * 2 + cgc06 * 9 +
                       cgc07 * 8 + cgc08 * 7 + cgc09 * 6 + cgc10 * 5 + cgc11 * 4 + cgc12 * 3 +
                       dv1 * 2);
            aux2 = aux1 / 11;
            aux3 = Math.Floor(aux2);
            aux4 = aux3 * 11;
            decimal dv2 = (aux1 - aux4);

            if (dv2 == 10)
            {
                dv2 = 0;
            }
            if (dv1 != cgc13 || dv2 != cgc14)
            {
                MessageBox.Show(@"Dígito verificador do campo" + "\"CNPJ\"" + @" não confere.");
                return (false);
            }
            return true;
        }
      
    }
}
