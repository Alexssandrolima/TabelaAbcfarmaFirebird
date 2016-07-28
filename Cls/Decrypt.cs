using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace TabelaAbcfarmaFirebird.Cls
{
    class Decrypt
    {
        internal static ClsUsuarioComputador LerArquivocriptografadoRetornar()
        {
            try
            {

           

            arquivoserialPath = Environment.CurrentDirectory + "\\serial.txt";


 

            string lines = Cls.LerArquivoSerial.lerArquivoSerialLiberacao(arquivoserialPath);


            if (lines != string.Empty)
            {
                string key = "xdhBS9ySRLuIQ7bn94MVP9QEiKM84WQXltdCMu6Ogu0="; //Está chave você mesmo é quem escolhe.
                Criptografia crip = new Criptografia(CryptProvider.DES);
                crip.Key = key;
                arquividescriptografado = crip.Decrypt(lines);
            }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Descriptar o arquivo \n" + ex.Message,"Verificando Arquivo Serial.txt");
            }

            ClsUsuarioComputador dadosCliente = new ClsUsuarioComputador();


            if (arquividescriptografado != null)
            {

                string[] split = arquividescriptografado.Split('#');

                dadosCliente.Cep = split[0];
                dadosCliente.Cnpj = split[1];
                dadosCliente.Computador = split[2];
                dadosCliente.Email = split[3];
                dadosCliente.Endereco = split[4];
                dadosCliente.Nome = split[5];
                dadosCliente.Numero = split[6];
                dadosCliente.Datainicio = Convert.ToDateTime(split[7]);
                dadosCliente.Datafinal = Convert.ToDateTime(split[8]);

                //       MessageBox.Show(
                //       " \n " +dadosCliente.Cep +
                //       " \n " +dadosCliente.Cnpj +
                //       " \n " +dadosCliente.Computador +
                //       " \n " +dadosCliente.Email +
                //       " \n " +dadosCliente.Endereco +
                //       " \n " +dadosCliente.Nome +
                //       " \n " +dadosCliente.Numero +
                //       " \n " +dadosCliente.Datainicio +
                //       " \n " +dadosCliente.Datafinal

                //);


                return dadosCliente;
            }
            dadosCliente.Nome = "Não Cadastrado na Aplicação!";
            dadosCliente.Cnpj = "Não Cadastrado!"; 
            return dadosCliente;

        }

        public static string arquivoserialPath { get; set; }

        public static string arquividescriptografado { get; set; }
    }
}
