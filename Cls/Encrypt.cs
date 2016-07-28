using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace TabelaAbcfarmaFirebird.Cls
{
    class Encrypt
    {
        internal static void criptografarArquivo(ClsUsuarioComputador dadosCliente)
        {

            string texto =
            dadosCliente.Cep + "#" +
            dadosCliente.Cnpj + "#" +
            dadosCliente.Computador + "#" +
            dadosCliente.Email + "#" +
            dadosCliente.Endereco + "#" +
            dadosCliente.Nome + "#" +
            dadosCliente.Numero + "#" +

            dadosCliente.Datainicio + "#" +
            dadosCliente.Datafinal


            ;
            string key = "xdhBS9ySRLuIQ7bn94MVP9QEiKM84WQXltdCMu6Ogu0="; //Está chave você mesmo é quem escolhe.
            Criptografia crip = new Criptografia(CryptProvider.DES);
            crip.Key = key;

            
            textBoxTxtCriptografado = crip.Encrypt(texto);


            //MessageBox.Show(" \n" + textBoxTxtCriptografado);
        }

        public static string textBoxTxtCriptografado { get; set; }

        internal static string criptografarArquivoRetornar(ClsUsuarioComputador dadosCliente)
        {

            string texto =
            dadosCliente.Cep + "#" +
            dadosCliente.Cnpj + "#" +
            dadosCliente.Computador + "#" +
            dadosCliente.Email + "#" +
            dadosCliente.Endereco + "#" +
            dadosCliente.Nome + "#" +
            dadosCliente.Numero + "#" +

            dadosCliente.Datainicio + "#" +
            dadosCliente.Datafinal
            ;
            string key = "xdhBS9ySRLuIQ7bn94MVP9QEiKM84WQXltdCMu6Ogu0="; //Está chave você mesmo é quem escolhe.
            Criptografia crip = new Criptografia(CryptProvider.DES);
            crip.Key = key;


            textBoxTxtCriptografado = crip.Encrypt(texto);


            //MessageBox.Show(" \n" + textBoxTxtCriptografado);

            return textBoxTxtCriptografado;
        
        }
    }
}
