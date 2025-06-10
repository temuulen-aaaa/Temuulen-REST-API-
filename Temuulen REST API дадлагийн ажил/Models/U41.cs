using System.ComponentModel.DataAnnotations;

namespace Temuulen_REST_API_дадлагийн_ажил.Models
{
    public class U41
    {
        [Key]
        [StringLength(7)]
        public string? U41EE { get; set; }

        [Required, StringLength(50)]
        public string? U41AA { get; set; }

        [Required, StringLength(2)]
        public string? U41BB { get; set; }

        [Required, StringLength(2)]
        public string? U41CC { get; set; }

        [Required]
        public byte U41DD { get; set; }

        [Required, StringLength(30)]
        public string? U41II { get; set; }

        [Required, StringLength(30)]
        public string? U41HH { get; set; }

        [Required]
        public byte U41JJ { get; set; }

        [Required, StringLength(50)]
        public string? U41KK { get; set; }

        [Required, StringLength(200)]
        public string? U41QQ { get; set; }

        [Required, StringLength(50)]
        public string? U41TT { get; set; }

        [StringLength(50)]
        public string? U41AI { get; set; }

        public byte? U41DEL { get; set; }

        public int? U41Tabel { get; set; }

        public int? U41TGroup { get; set; }
    }
}
