using System.ComponentModel.DataAnnotations;
namespace Temuulen_REST_API_дадлагийн_ажил.Models
{
    using System.ComponentModel.DataAnnotations;

    public class U021
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        [Required, StringLength(20)]
        public string? U021AA { get; set; }

        [Required, StringLength(2)]
        public string? U021BB { get; set; }

        [Required, StringLength(2)]
        public string? U021CC { get; set; }

        [Required, StringLength(20)]
        public string? U021DD { get; set; }

        [Required, StringLength(20)]
        public string? U021EE { get; set; }

        [Required, StringLength(50)]
        public string? U021GG { get; set; }

        [Required, StringLength(50)]
        public string? U021HH { get; set; }

        [Required, StringLength(50)]
        public string? U021II { get; set; }

        [Required, StringLength(60)]
        public string? U021PP { get; set; }

        [StringLength(15)]
        public string? U021WW { get; set; }

        public byte? U021VV { get; set; }

        [StringLength(50)]
        public string? U021AI { get; set; }

        [StringLength(50)]
        public string? U021AJ { get; set; }
    }
}
