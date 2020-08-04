using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("PaymentDetailTB")]
    public class PaymentDetailTB
    {
        [Key]
        public int PmId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }

    }
}
