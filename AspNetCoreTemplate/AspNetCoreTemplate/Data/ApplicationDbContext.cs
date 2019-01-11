using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        
        // public DbSet<Value> Values { get; set; }
    }

    //public class Value
    //{
    //    [Key]
    //    public int Id { get; set; }

    //    [MaxLength(10)]
    //    public string Property { get; set; }
    //}
}
