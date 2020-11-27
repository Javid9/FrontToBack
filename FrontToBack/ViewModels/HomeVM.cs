using FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public PageSign PageSign { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public About About { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public Subscribe Subscribe { get; set; }
    }
}
