using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO;
using System.Windows.Forms;
using System.Data;


namespace TabelaAbcfarmaFirebird.Cls
{
    class LerArquivoSerial
    {
        internal static string lerArquivoSerialLiberacao(string arquivoserialPath)
        {
            try
            {
                string lines = System.IO.File.ReadAllText(arquivoserialPath);
                return lines;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi Encontrado o Arquivo de Configuração: "
                    + "\n Verifique na aba Configuração e Faça seu cadastro, por favor! " 
                    //+ arquivoserialPath + " \n "
                    //+ ex.Message
                    ,"Retorno da aplicação ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }
        }
    }
}
