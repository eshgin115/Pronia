﻿using First_For_Mvc_Project.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace First_For_Mvc_Project.Database.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
               .ToTable("Users");

            builder
               .HasOne(u => u.Basket)
               .WithOne(b => b.User)
               .HasForeignKey<Basket>(u => u.UserId);

            builder
               .HasOne(u => u.Role)
               .WithMany(r => r.Users)
               .HasForeignKey(u => u.RoleId);

            builder
                .HasOne(u => u.UserActivation)
                .WithOne(ua => ua.User)
                .HasForeignKey<UserActivation>(ua => ua.UserId);
        }
    }
}