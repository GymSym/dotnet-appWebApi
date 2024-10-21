using dotnet_appWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet_appWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
