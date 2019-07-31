using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment6b.Models
{
    public class JellyBeanContext : DbContext
    {
        public JellyBeanContext(DbContextOptions<JellyBeanContext> options) : base(options)
        { }

        public virtual DbSet<JellyBean> JellyBeans { get; set; }

    }
}
