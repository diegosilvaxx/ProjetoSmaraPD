using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmaraPD.Models
{
    public class SalaReuniao
    {
        public int Id { get; set; }
        public string Sala { get; set; }
        public string DataLocacao { get; set; }
        public string DataEntrega { get; set; }

        public int ClienteId { get; set; }
        public Cliente Clientes { get; set; }

    }
}
