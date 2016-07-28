using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using System.Data;

namespace TabelaAbcfarmaFirebird.Cls
{
    class GravarArquivoSerial
    {

        internal static string GravarArquivoSerialliberacao(string arquivoserialPath, string contendotextoserial)
        {
            retorno = string.Empty;
            try
            {
                if (!File.Exists(arquivoserialPath))
                {
                    File.WriteAllText(arquivoserialPath, contendotextoserial);
                    
                    //retorno = "Consegui Gravar o arquivo: \n" + arquivoserialPath;
                    //retorno = "";
                    return retorno;
                }
                retorno = "Concluído! \n";

                return retorno;
            }
            catch (Exception ex)
            {
                retorno = "Não consegui Gravar o arquivo: \n" + ex.Message + " ";
                return retorno;

            }
        }

        public static string retorno { get; set; }
    }
}
