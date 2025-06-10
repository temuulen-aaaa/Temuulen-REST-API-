using System.ComponentModel.DataAnnotations;
namespace Temuulen_REST_API_дадлагийн_ажил.Models
{
    public class AuthUser
    {
        [Key]
        [StringLength(80)]
        public string UserName { get; set; }

        [Required, StringLength(80)]
        public string Password { get; set; }

        [Required, StringLength(10)]
        public string U41EE { get; set; }

        public U41 U41 { get; set; }  // Navigation property
    }
}
