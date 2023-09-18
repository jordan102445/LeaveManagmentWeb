using LeaveManagment.Web.Constraints;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities
{
    public class RolsSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "0a255-9158-43c5-b4d6-767818907757",

                    Name = Roles.Administrator,

                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "4a255-9158-46c5-b4a6-769818907707",

                    Name = Roles.User,

                    NormalizedName = Roles.User.ToUpper(),
                }
              );
        }
    }
}