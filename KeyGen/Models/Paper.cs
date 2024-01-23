using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyGen.Models
{
    public class Paper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Paper_Id { get; set; }

        [Required]
        public String Paper_Code { get; set; }

        [Required]
        public int University_Id { get; set; }

        [Required]
        public int SessionType_Id { get; set; }

        [Required]
        public int ExamType_Id { get; set; }

        [Required]
        public int Catch_Number { get; set; }

        [Required]
        public int Subject_Id { get; set; }

        [Required]
        public int Course_Id { get; set; }


    }
}
