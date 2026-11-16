using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEFcore02.Classes
{
    public class EventHubContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = EventDb; Trusted_Connection= true; TrustServerCertificate=True;");
        }



        protected override void OnModelCreating(ModelBuilder builder )
        {
            builder.Entity<OrganizerProfile>(o =>

            {
                o.Property(p => p.LogoUrl)
                .HasMaxLength(150);

                o.Property(p => p.Biography).HasMaxLength(500);

             }  


             );



            builder.ApplyConfiguration(new EventConfiguration());
            builder.ApplyConfiguration(new BadgeConfiguration());


           
        }

        
    }
}