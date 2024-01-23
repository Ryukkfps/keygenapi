using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KeyGen.Validators;

namespace KeyGen.Models
{
    public class University
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int University_Id { get; set; }

        [Required]
        [NameCheck]
        public string University_Name { get; set; }

        [Required]
        [NameCheck]
        public string Region { get; set; }

        [Required]
        [NameCheck]
        public string City { get; set; }

        [Required]
        public int Session_Id { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
