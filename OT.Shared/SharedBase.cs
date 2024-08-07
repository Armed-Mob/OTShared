using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OT.Shared
{
    public class SharedBase
    {
        // Identifier For Database Tables
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // DateTime For Tracking
        [Required]
        [Display(Name = "Created")]
        public DateTime CreatedDate { get; set; } =  DateTime.UtcNow;
        [Display(Name = "Last Modified")]
        public DateTime? LastModifiedDate { get; set; } 
    }
}
