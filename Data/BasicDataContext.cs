using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BasicAPI.Data
{
    public class BasicDataContext : DbContext
    {
        public BasicDataContext(DbContextOptions<BasicDataContext> options): base(options)
        {

        }

        public DbSet<Agent>? Agents { get; set; }
    }

}
