using System.ComponentModel.DataAnnotations;

namespace OT.Shared
{
    public class SharedColor : SharedBase
    {
        [Required, MaxLength(50)]
        [Display(Name = "Color Name")]
        public string ColorName { get; set; } = string.Empty;
    }
}
