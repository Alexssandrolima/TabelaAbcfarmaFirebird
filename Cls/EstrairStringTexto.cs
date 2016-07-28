using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TabelaAbcfarmaFirebird.Cls
{
    class EstrairStringTexto
    {
        public class Posicional
        {
            public string ID { get; set; }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Cpf { get; set; }
        }


        public void ParseExpressaoRegular(string stringPosicional)
        {
            Regex regex = new Regex(@"(?<ID>[A-Z\d]{5})(?<Nome>.{30})(?<DataNascimento>\d{8})(?<Cpf>\d{11})");
 
            Match match = regex.Match(stringPosicional);
 
            if (match.Success)
            {
 //               ID = match.Groups["ID"].Value;
//                Nome = match.Groups["Nome"].Value;
//                DataNascimento = DateTime.ParseExact(match.Groups["DataNascimento"].Value, "ddMMyyyy", new CultureInfo("pt-BR"));
//                Cpf = match.Groups["Cpf"].Value;
            }
        }


    }
}
