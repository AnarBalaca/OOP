using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }
        public string? SureName { get; set; }
        public string? LocalAdress { get; set; }
        public string? MailAdress { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public Order? Order { get; set; }


    }
}
