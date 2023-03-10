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
    internal class EngineConfigurations : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.TypeEngine).WithMany(te => te.Engines).HasForeignKey(e => e.TypeEngineId);
        }
    }
}
