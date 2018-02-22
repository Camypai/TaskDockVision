using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskTwoWCF
{
    public class MailContext : DbContext
    {
        public MailContext() : base("mssql")
        { }
        public DbSet<Mail> Mails { get; set; }
    }
}