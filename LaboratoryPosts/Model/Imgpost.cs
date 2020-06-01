using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryPosts.Model
{
    public class Imgpost
    {
        [Key]
        public int ID { get; set; }
        public byte[] PostImage { get; set; }
    }
}
