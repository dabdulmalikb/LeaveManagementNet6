using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "43383d91-4380-42d3-8220-16c2d6e72be8",
                    UserId= "63383f91-4380-42e3-8220-16d2d6e72be8"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "53383a91-4380-42b3-8220-16a2d6d72be8",
                     UserId = "32517b00-6e34-411e-9644-10b401abc185"
                 }
            );

        }
    }
}