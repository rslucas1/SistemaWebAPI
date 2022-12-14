using System;
using System.Collections.Generic;
using System.Text;
using API.Rejected.Domain.Enums;

namespace API.Rejected.Domain.Entities
{
    class Pedido
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public EPagamentoTipo ePagamentoTipo { get; set; }
        public DateTime dataPedido { get; set; }
        public Boolean faturado { get; set; }
        public double valorTotalPedido { get; set; }
        public int notaFiscal { get; set; }

        
}
}
