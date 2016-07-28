using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration; //usando configuração app.config

namespace TabelaAbcfarmaFirebird
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
                      

            string arquivoserialPath = Environment.CurrentDirectory + "\\serial.txt";

            
            MessageBox.Show("    procurar onde esta dando o erro de cnpj tem que ter 14 digitos. " +
                "\n outra coisa enviar email de cadastro e erros \n "+ args );
            if(System.IO.File.Exists(arquivoserialPath))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormTabelaPrincipal());

            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormConfiguracao(arquivoserialPath));
            }
        }
    }
}
