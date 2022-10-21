using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //Context is using this

namespace MvcValidations.Models
{
    public class UsersContext : DbContext //it should inheritate 
    {
        public UsersContext() //we define a UsersContext constructor 
            :base("UsersConnection") //CS Name, //this Constructor have to call the base class constructor
        {
             
        }
        public DbSet<Register> RegisterTable { get; set; }  //For communicating with the DB
    }
}