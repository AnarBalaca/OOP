using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Category : BaseEntity
    {
        public string? CategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }


    }
}
