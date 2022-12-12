using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Supplier : BaseEntity
    {
        public string? SupplierName { get; set; }
        public string? SupplierDescription { get; set; }
        public string? SupplierAdress { get; set; }
        public ICollection<Product>? Products { get; set; }


    }
}
