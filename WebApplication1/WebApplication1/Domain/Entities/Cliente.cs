using System;
using System.Collections.Generic;
using System.Text;
using API.Rejected.Domain.Enums;


namespace API.Rejected.Domain.Entities
{
    public class Cliente
    {
        public int id { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
       
        public EClienteStatus EClienteStatus { get; set; }
    }
}
