using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuickSchedule.Shared.Models
{
    [Table("RecordAddresses")]
    public class RecordAddress
    {
        [Key]
        public int RecordAddressID { get; set; }          // ID do endereço do registro
        public int RecordID { get; set; }                 // ID do registro
        public Record Record { get; set; } = null!;       // Registro
        public int AddressID { get; set; }                // ID do endereço
        public Address Address { get; set; } = null!;     // Endereço
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string? AddressComplement { get; set; } = null!;    // Complemento do endereço
        [Required]
        [Column(TypeName = "varchar(3)")]
        [MaxLength(3)]
        public string AddressNumber { get; set; } = null!;       // Número do endereço
        public bool IsPrimary { get; set; }               // É primário
    }
}
