using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate.Data
{
    public class region
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; } = string.Empty;

        public int governateId { get; set; }
        [ForeignKey("governateId")]
        public govarnate? govarnate { get; set; }
    }
}
