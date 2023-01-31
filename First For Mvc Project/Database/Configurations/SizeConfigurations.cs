﻿
using First_For_Mvc_Project.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace First_For_Mvc_Project.Database.Configurations
{
    public class SizeConfigurations : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder
              .ToTable("Sizes");

        }
    }
}