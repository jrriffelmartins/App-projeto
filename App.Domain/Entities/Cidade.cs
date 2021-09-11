using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cidades

{
    public class Cidade
    {
        [Key]
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        

    }

}