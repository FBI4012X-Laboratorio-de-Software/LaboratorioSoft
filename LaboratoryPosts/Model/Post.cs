using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryPosts.Model
{
    public class Post
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Field {0} required")]
        [StringLength(50, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Field {0} required")]
        [StringLength(50, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Subtitle { get; set; }

        public string Information { get; set; }

        public User User { get; set; }

        public List<Imgpost> ImgPosts { get; set; }
    }
}
