using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Account
    {
        [Key]
        Guid AccountNum { get; set; }
        private double Amount { get; set; }
        private double Tip { get; set; }
        private double Total { get; set; }
    }
}