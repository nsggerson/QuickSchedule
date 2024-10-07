using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSchedule.Shared.Models
{
    [Table("Users")]
    public class ApplicationUser
    {
        [Key]
        public int ApplicationUserID { get; set; }
        public int RecordID { get; set; }
        public Record? Record { get; set; }
        [Required]
        [MaxLength(60)]
        public string? Login { get; set; }        

        [Display(Name = "Contatos")]
        //[NotEmptyList(ErrorMessage = "Pelo menos um contato é obrigatório.")]
        public List<Contact>? Contacts { get; set; } = new List<Contact>()!;

        [Required]
        public DateTime? LastLogin { get; set; }
    }
}
