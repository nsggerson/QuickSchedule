using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickSchedule.Shared.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }               // ID do endereço
        [Required]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string Street { get; set; } = null!;      // Rua
        [Required]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string Neighborhood { get; set; } = null!;   // Bairro
        [Required]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(30)]
        public string City { get; set; } = null!;        // Cidade
        [Required]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(30)]
        public string State { get; set; } = null!;       // Estado
        [Required]
        [Column(TypeName = "varchar(20)")]
        [MaxLength(20)]
        public string PostalCode { get; set; } = null!;  // Código Postal
        [Required]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(30)]
        public string Country { get; set; } = null!;     // País
        [Required]
        [Column(TypeName = "varchar(4)")]
        [MaxLength(4)]
        public string StateAbbreviation { get; set; } = null!; // UF
        [Required]
        [Column(TypeName = "varchar(3)")]
        [MaxLength(3)]
        public string AreaCode { get; set; } = null!;    // Código de área
        public ICollection<RecordAddress> RecordAddresses { get; set; } = null!;
    }
}
