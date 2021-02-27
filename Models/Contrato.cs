using System;
using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class Contrato
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataContrato { get; set; }
        public string Parcelas { get; set; }
        public decimal ValorFinanciado { get; set; }

        public int PrestacaoId { get; set; }
        public Prestacao Prestacoes { get; set; }
    }
}