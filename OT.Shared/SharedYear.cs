using System.ComponentModel.DataAnnotations;

namespace OT.Shared
{
    public class SharedYear : SharedBase
    {
        [Display(Name = "Name")]
        public string Value { get; set; } = string.Empty;
    }
}
