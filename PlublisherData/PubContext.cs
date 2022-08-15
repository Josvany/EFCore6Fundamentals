using Microsoft.EntityFrameworkCore;
using PublisherDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlublisherData
{
    public class PubContext : DbContext
    {
        public PubContext() : base()
        {

        }

        public DbSet<Author> Authors { get; set; }
    }
}
