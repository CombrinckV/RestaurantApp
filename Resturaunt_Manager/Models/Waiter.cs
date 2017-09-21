using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Waiter
    {
        [Key]
        Guid WaiterId { get; set; }
        private string waitername { get; set; }
        private string waitersurname { get; set; }
        // public virtual Table {get;set;}
        // public virutal Account {get;set;}
        
    }
}