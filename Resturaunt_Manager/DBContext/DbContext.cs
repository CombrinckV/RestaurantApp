using Resturaunt_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Resturaunt_Manager.DBContext
{
    public class DbContext
    {
        
        private DbSet<Account> Accounts { get; set; }
        private DbSet<Waiter> Waiters { get; set; }
        private DbSet<Table> Tables { get; set; }
    }
}