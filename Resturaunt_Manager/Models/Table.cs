using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturaunt_Manager.Models
{
    public class Table
    {
        [Key]
        Guid TableNum { get; set; }
        //public virtual Account {get;set;}
        //public virtual Waiter {get;set;
    }
}