using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    internal class ModelConfigurations : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(m => m.Id);

            builder.HasOne(m => m.Year).WithMany(y => y.Models).HasForeignKey(m => m.IdYear);
        }
    }
}
