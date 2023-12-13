using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SwayASP.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
