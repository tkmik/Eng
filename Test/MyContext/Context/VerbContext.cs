using MyContext.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContext.Context
{
    public class VerbContext : DbContext
    {       
        public DbSet<Verb> Verbs { get; set; }
        public VerbContext() : base("name=default")
        {

        }
    }
}
