using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Qaqa bosh buraxma"),MaxLength(100,ErrorMessage ="eee bes elemedi???")]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
