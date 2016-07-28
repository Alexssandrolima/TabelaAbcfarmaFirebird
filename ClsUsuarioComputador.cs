using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations; // udar data annotations

namespace TabelaAbcfarmaFirebird
{
    class ClsUsuarioComputador
    {

        [Display(Name = "Nome Completo", Description = "Nome Completo.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }
        
        //private string nome;
        //public string Nome
        //{
        //    get { return nome; }
        //    set { nome = value; }   
        //}


        //string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ






        private string _cnpj;
        [Required(ErrorMessage = "Informe o seu Cnpj por favor")]
        [RegularExpression(".+\\..+\\..+\\/.+\\-.+", ErrorMessage = "Informe um Cnpj válido 99.999.999/9999-99 ...")] // .+\\..+\\..+\\/.+\\.-+\\..+
        public string Cnpj
        {
            get { return _cnpj; }
            set
            {
                if (Cls.ValidarCnpjCpf.ValidarCnpjObjetoDigitado(value)) _cnpj = value;
            }
        }





//        [Required(ErrorMessage = "Informe o seu Cnpj por favor")]
//        [RegularExpression(".+\\..+\\..+\\/.+\\-.+", ErrorMessage = "Informe um Cnpj válido 99.999.999/9999-99 ...")] // .+\\..+\\..+\\/.+\\.-+\\..+
//        public string Cnpj { get; set; }

        //[Required(ErrorMessage = "Informe o seu email")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        //public string Email { get; set; }
        
        //private string cnpj; 
        //public string Cnpj
        //{
        //    get { return cnpj; }
        //    set { cnpj = value; }
        //}
        private string computador;

        public string Computador
        {
            get { return computador; }
            set { computador = value; }
        }

        [Required(ErrorMessage = "O Endereço é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Endereço do Completo")]
        public string Endereco{ get; set; }

        [Required(ErrorMessage = "Numero da casa é obrigatório")]
        //[Required]
        [Display(Name = "Numero", Description = "Numero da casa deve esta entre 0 = nenhum ate 10000 para preechimento.")]
        [Range(0, 10000)]
        public string Numero{ get; set; }
        

        [Required(ErrorMessage = "Informe o seu Cep")]
        [RegularExpression(".+\\-.+", ErrorMessage = "Informe um Cep válido 00000-000 ...")]
        public string Cep{ get; set; }
        

        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email{ get; set; }
        
        private string serial;
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        private DateTime datainicio;

        public DateTime Datainicio
        {
            get { return datainicio; }
            set { datainicio = value; }
        }
        private DateTime datafinal;

        public DateTime Datafinal
        {
            get { return datafinal; }
            set { datafinal = value; }
        }

    }
}
