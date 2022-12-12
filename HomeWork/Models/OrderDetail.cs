using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class OrderDetail : BaseEntity
    {
        public Order? Order { get; set; }
        public int Fee { get; set; }
        public int Tax { get; set; }
        public string? Territory { get; set; }

    }
}
