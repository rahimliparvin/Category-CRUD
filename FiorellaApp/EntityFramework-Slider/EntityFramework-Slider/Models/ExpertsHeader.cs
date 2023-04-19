using Microsoft.Build.Framework;

namespace EntityFramework_Slider.Models
{
    public class ExpertsHeader: BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
