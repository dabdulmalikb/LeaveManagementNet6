using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "63383f91-4380-42e3-8220-16d2d6e72be8",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     FirstName = "System",
                     LastName = "Admin",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "32517b00-6e34-411e-9644-10b401abc185",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed=true                     
                 }
               ) ; 
        }
    }
}