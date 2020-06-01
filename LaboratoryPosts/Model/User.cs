using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryPosts.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Field {0} required")]
        [StringLength(50, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Field {0} required")]
        [StringLength(10, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
