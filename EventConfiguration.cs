using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEFcore02.Classes
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {

            builder.Property(p => p.Title).IsRequired()
                .HasMaxLength(200);


            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.StartDate)
                .IsRequired();
                //.HasDefaultValueSql("GetDate()");
                

            builder.Property(p => p.EndDate)
                .IsRequired(false);
        }
    }
}
