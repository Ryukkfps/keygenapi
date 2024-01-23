using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyGen.Models
{
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Permission_Id { get; set; }

        [Required]
        public int User_Id { get; set; }

        public int Module_Id { get; set; }

        public bool Can_Add { get; set; }

        public bool Can_Delete { get; set;}

        public bool Can_Update { get; set;}

        public bool Can_View { get; set; }
    }
}
