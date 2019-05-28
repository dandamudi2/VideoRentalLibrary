using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MemberShipType
    {
          public byte id { get; set; }

          [StringLength(100)]
          public string Name { get; set; }
          public short SignUpFee { get; set; }
          public byte DurationInMonths { get; set; }
          public byte DiscountRate { get; set; } 

          public List<Customer> Customers { get; set; }
    }
}