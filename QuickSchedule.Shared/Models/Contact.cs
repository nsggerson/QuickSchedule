using QuickSchedule.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickSchedule.Shared.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public int RecordID { get; set; }
        public Record Record { get; set; } = null!;
        public ContactTypeEnum ContactType { get; set; } = ContactTypeEnum.MobilePhone;
        [Required]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string ContactValue { get; set; } = string.Empty;
        public bool IsPrimary { get; set; } = false;
        public bool IsWhatsApp { get; set; }
        public bool IsActive { get; set; }
    }   

}

