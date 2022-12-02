using dn7.domain;
using Microsoft.EntityFrameworkCore;

namespace dn7.db
{
    public class Dn7Context : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public Dn7Context(DbContextOptions<Dn7Context> options) : base(options)
        {
        }

        // TODO: only do this running locally/dev
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
        //.ConfigureWarnings(b => b.Ignore(RelationalEventId.AmbientTransactionWarning));


    }
}