using System;
using System.Collections.Generic;
using System.Text;
using Domain.Context.Enums;

namespace Domain.Context.Entities
{
    class Cliente
    {
        public int id { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public int MyProperty { get; set; }

        public enum EclienteStatus { get }
    }
}
