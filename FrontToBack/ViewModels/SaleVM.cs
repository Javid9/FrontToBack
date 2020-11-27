using FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewModels
{
    public class SaleVM
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public List<SaleProduct> SaleProducts { get; set; }
    }
}
