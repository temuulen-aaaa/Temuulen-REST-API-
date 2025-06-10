using System.ComponentModel.DataAnnotations;
namespace Temuulen_REST_API_дадлагийн_ажил.Models
{
    public class MER_L
    {
        [Key, StringLength(20)]
        public string MMM3 { get; set; }

        [StringLength(2000)]
        public string? MMM4 { get; set; }

        [StringLength(50)]
        public string? MMM20 { get; set; }

        [Required]
        public byte MDEL { get; set; }
    }
}
