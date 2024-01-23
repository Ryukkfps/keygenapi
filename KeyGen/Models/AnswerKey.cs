using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyGen.Models
{
    public class AnswerKey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerKey_Id { get; set; }

        [Required]
        public string Paper_code { get; set; }

        [Required]
        public int Page_number{ get; set; }

        [Required]
        public int Question_number{ get; set; }

        [Required]
        public char Answer{ get; set; }
    }
}
