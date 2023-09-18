using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>>builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "0a255-9158-43c5-b4d6-767818907757",
                    UserId = "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf"
                },// ovoj e samo ADMINISTRATOR
                 new IdentityUserRole<string>
                 {
                     RoleId = "4a255-9158-46c5-b4a6-769818907707",
                     UserId = "f52fb7cd-7aa3-43c3-909e-592297bd2186"
                 }// ovoj e samo USER

                );
        }
    }
}