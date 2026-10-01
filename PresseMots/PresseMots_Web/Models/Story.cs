using PresseMots.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresseMots.Models
{
    public class Story : IWordCountable
    {

        public Story()
        {
            Likes = new List<Like>();
            Shares = new List<Share>();
            Comments = new List<Comment>();

        }
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        
        [StringLength(10000, MinimumLength = 25, ErrorMessage = "Le contenu doit contenir entre 25 et 10000 caractères.")]
        public string Texte { get; set; } = string.Empty;

        public virtual List<StoryTag> StoryTags { get; set; } = new();

        public virtual User Owner { get; set; }
        public int OwnerId { get; set; }
        public virtual IList<Like> Likes { get; set; }

        public virtual IList<Share> Shares { get; set; }

        public virtual IList<Comment> Comments { get; set; }


    }
}
