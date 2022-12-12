using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Order : BaseEntity
    {
        public string? OrderName { get; set; }
        public bool IsReady { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public Customer? Customer { get; set; }
        public Employee? Employee { get; set; }
        public OrderDetail? OrderDetail { get; set; }

    }
}
