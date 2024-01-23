using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyGen.Models
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Session_Id { get; set; }

        [Required]
        public string Session_Name { get; set; }

        [Required]
        public int University_id { get; set; }
    }
}
