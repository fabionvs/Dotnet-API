using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace app.Models
{
    [Table("tb_contrato")]
    public class Contrato
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataContrato { get; set; }
        public int Parcelas { get; set; }
        public decimal ValorFinanciado { get; set; }

        public List<Prestacao> Prestacoes { get; set; }
    }
}