using EcoAdmin.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace EcoAdmin.Models
{
    public class UserProfile
    {
        [Key]
        [Required]
        public string UniqueUserName { get; set; }

        // Foreign key reference to ApplicationUser
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
