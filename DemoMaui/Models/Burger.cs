using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMaui.Models
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsVeagan { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
