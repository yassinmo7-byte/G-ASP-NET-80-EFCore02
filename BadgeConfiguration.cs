using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEFcore02.Classes
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.Property(p => p.BadgeNumber)
                                .IsRequired();


            builder.HasIndex(p => p.BadgeNumber)
                .IsUnique();



            builder.Property(p => p.IssuedDate)
                .IsRequired();



            builder.Property(b => b.Tier)
                .IsRequired();

        }
    }
}
