using System.ComponentModel.DataAnnotations;
namespace Temuulen_REST_API_дадлагийн_ажил.Models
{
    public class ATA_L
    {
        [Key]
        public byte ATA_KOD { get; set; }

        [Required, StringLength(50)]
        public string? ATA_NER { get; set; }

        [Required]
        public byte ATA_Order { get; set; }

        [StringLength(50)]
        public string? ATA_NER_ENG { get; set; }
    }
}
