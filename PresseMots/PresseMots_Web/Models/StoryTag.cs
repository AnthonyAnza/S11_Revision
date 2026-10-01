using Azure;

namespace PresseMots.Models
{
    public class StoryTag
    {
        public int StoryId { get; set; }
        public virtual Story Story { get; set; } = null!;

        public int TagsId { get; set; }
        public virtual Tags Tag { get; set; } = null!;
    }
}
