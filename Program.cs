using System;
using System.Collections.Generic;
using System.IO;
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

            bool arquivoEncontrado = File.Exists(Environment.CurrentDirectory + "\\serial.txt");

            
            MessageBox.Show(" verificar porque não esta conectando ao banco de dados... \n outra coisa enviar email de cadastro e erros \n " + args.ToString() );
            if (arquivoEncontrado)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormTabelaPrincipal());

            }
            else
            {
                string arquivoserialPath = Environment.CurrentDirectory + "\\serial.txt";
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormConfiguracao(arquivoserialPath));
            }
        }
    }
}
