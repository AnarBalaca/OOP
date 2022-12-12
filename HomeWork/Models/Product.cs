using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Product : BaseEntity
    {
        public int Price { get; set; }
        public int Count { get; set; }
        public string? Name { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Supplier>? Suppliers { get; set; }



    }
}
