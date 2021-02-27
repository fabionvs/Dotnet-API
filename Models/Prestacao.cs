using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace app.Models
{

    [Table("tb_prestacao")]
    public class Prestacao
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }
        
        public DateTime? DataPagamento { get; set; }
        public decimal Valor { get; set; }

        string _status;
        public virtual string Status
        {
            get
            {
                if (DataVencimento >= DateTime.Now)
                {
                    _status = "Aberta";
                }
                else if (DataVencimento < DateTime.Now && DataPagamento == null)
                {
                    _status = "Atrasada";
                }
                else if (DataPagamento != null)
                {
                    _status = "Baixada";
                }
                return _status;
            }
            set { }
        }

        [ForeignKey("ContratoId")]
        public int ContratoId { get; set; }

        public virtual Contrato Contrato { get; set; }
    }
}