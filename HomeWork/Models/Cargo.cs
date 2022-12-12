using HomeWork.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Cargo : BaseEntity
    {
        public string? CargoName { get; set; }
        public string? CargoDescription { get; set; }

    }
}
