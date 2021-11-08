using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Phase_4_Project_WDB.Models
{
    public class Customer_Records
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        [Required]
        public string CustomerUname { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string CustomerPwd { get; set; }
        public string CustomerEmail { get; set; }
    }
}
