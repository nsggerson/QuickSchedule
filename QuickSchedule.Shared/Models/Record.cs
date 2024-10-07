using QuickSchedule.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickSchedule.Shared.Models
{
    [Table("Records")]
    public class Record
    {
        [Key]
        public int RecordID { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string RecordName { get; set; } = string.Empty;
        [Column(TypeName = "varchar(15)")]
        [MaxLength(15)]
        public string Taxpayer { get; set; } = null!; //cnpj ou cpf
        public TaxpayerTypeEnum TaxpayerType { get; set; }//Tipo que fai definir 
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string? TradeName { get; set; } = " ";//nome fantasia
        public bool IsActive { get; set; } = true;
        public Guid UniqueCode { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public ICollection<RecordAddress> RecordAddresses { get; set; } = null!;
        public ICollection<Contact> Contacts { get; set; } = null!;
    }
       
}
