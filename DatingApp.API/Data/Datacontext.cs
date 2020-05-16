using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class Datacontext: DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options):base(options)
        {
            
        }

        public DbSet<Value> Values {get;set;}
    }
}