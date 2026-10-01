using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PresseMots.Models
{
    public class Tags
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public virtual List<StoryTag> StoryTags { get; set; } = new();
    }
}
