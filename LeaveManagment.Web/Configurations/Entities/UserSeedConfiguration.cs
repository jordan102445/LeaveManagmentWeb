using LeaveManagment.Web.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {

                    Id = "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "AdminAdmin",
                    PasswordHash = hasher.HashPassword(null, "P@assword1"),
                    EmailConfirmed = true
                    
                },

                new Employee
                {
                    Id = "f52fb7cd-7aa3-43c3-909e-592297bd2186",
                    Email = "ivan@gmail.com",
                    NormalizedEmail = "IVAN@GMAIL.COM",
                    UserName = "ivan@gmail.com",
                    NormalizedUserName = "IVAN@GMAIL.COM",
                    FirstName = "Ivan",
                    LastName = "Petrov",
                    PasswordHash = hasher.HashPassword(null, "P@assword1"),
                    EmailConfirmed = true


                }
                );
        }
    }
}