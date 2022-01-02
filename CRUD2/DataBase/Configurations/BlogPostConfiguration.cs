using CRUD2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.DataBase.Configurations
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder
                .Property(bp => bp.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(bp => bp.BlogText)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
