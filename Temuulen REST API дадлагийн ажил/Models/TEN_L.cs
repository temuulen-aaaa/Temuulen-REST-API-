using System.ComponentModel.DataAnnotations;
namespace Temuulen_REST_API_дадлагийн_ажил.Models
{
    public class TEN_L
    {
        [Key]
        public int TTTID { get; set; }

        [Required, StringLength(2)]
        public string TTT1 { get; set; }

        [Required, StringLength(2)]
        public string TTT2 { get; set; }

        [Required, StringLength(100)]
        public string TTT3 { get; set; }

        [StringLength(100)]
        public string? TTT5 { get; set; }
    }
}
