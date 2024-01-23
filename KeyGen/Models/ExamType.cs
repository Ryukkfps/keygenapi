using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyGen.Models
{
    public class ExamType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Exam_Type_id { get; set;}

        [Required]
        public string Exam_Type { get; set; }

        [Required]
        public int University_id { get; set; }
    }
}
