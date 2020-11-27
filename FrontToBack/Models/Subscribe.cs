using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Image { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
    }
}
