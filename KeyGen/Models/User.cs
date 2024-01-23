using KeyGen.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace KeyGen.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }

        [Required]
        [NameCheck]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [NameCheck]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string Designation { get; set; }


        public string Profile_pic { get; set; }

        public DateTime UserCreatedDateTime { get; set; }

        public string CreatedBy { get; set; }
    }
}
