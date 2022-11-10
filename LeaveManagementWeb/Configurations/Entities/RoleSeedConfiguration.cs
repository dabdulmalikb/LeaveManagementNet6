using LeaveManagementWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "43383d91-4380-42d3-8220-16c2d6e72be8",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "53383a91-4380-42b3-8220-16a2d6d72be8",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
             );
        }
    }
}