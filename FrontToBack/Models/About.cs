using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
        public string Link { get; set; }
        [Required]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public string List { get; set; }
    }
}
