using Microsoft.EntityFrameworkCore;

namespace UKParliament.CodeTest.Data
{
    public class PersonManagerContext : DbContext
    {
        /// Change Log:
        /// simonjpearson | 06 Nov, 2021 | Extended class for UK Parliament Interview

        public PersonManagerContext(DbContextOptions<PersonManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        // simonjpearson 06 Nov, 2021
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }

}
