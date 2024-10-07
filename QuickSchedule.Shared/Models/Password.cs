using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSchedule.Shared.Models
{
    [Table("Passwords")]
    public class Password
    {
        [Key]
        public int PassWordID { get; set; }     
        
        public int ApplicationUserID { get; set; }
        public ApplicationUser? UserSystem { get; set; }
        public bool IsPasswordExpirationEnabled { get; set; }
        [Required]
        [Column(TypeName = "varchar(max)")]
        public string? PasswordText { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
