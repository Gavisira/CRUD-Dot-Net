using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Entities
{
    public class Pessoa
    {
        #region Atributos Privados

        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public DateTime dtNascimento { get; set; }

        public string nomeMae { get; set; }

        public string endereco { get; set; }


        #endregion

    }
}
