using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Expert
    {
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Image { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Position { get; set; }
    }
}
