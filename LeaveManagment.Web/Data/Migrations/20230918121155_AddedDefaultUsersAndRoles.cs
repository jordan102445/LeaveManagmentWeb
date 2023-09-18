using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a255-9158-43c5-b4d6-767818907757", "c4f7815f-852b-457b-9caf-36303da4686f", "Administrator", "ADMINISTRATOR" },
                    { "4a255-9158-46c5-b4a6-769818907707", "57224fb2-7dad-44bc-9416-fd11ac303d24", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf", 0, "3ccf39a8-0c74-4d56-866d-ae5c3d9621a6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "Admin", "AdminAdmin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEP1U9Wq4jnZ1eyAQ19cPuh7rRvOS+r4VotXeZgO03JiEfvCR3lmcfsreCFb2Vz+Rag==", null, false, "718fcdd6-4857-432e-b534-b7a45dcdfb78", null, false, null },
                    { "f52fb7cd-7aa3-43c3-909e-592297bd2186", 0, "3d7c8bfa-5cb2-43d8-b911-de4605e07865", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ivan@gmail.com", false, "Ivan", "Petrov", false, null, "IVAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHIGKhtoGgpWySTTcU2/I/9dUZIxCyOn+EQlZ6MBQgVC6pDigseGnXARtvUfJNurVg==", null, false, "77108155-75fc-475a-b300-bad295df355d", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0a255-9158-43c5-b4d6-767818907757", "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a255-9158-46c5-b4a6-769818907707", "f52fb7cd-7aa3-43c3-909e-592297bd2186" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a255-9158-43c5-b4d6-767818907757", "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a255-9158-46c5-b4a6-769818907707", "f52fb7cd-7aa3-43c3-909e-592297bd2186" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a255-9158-43c5-b4d6-767818907757");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a255-9158-46c5-b4a6-769818907707");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52fb7cd-7aa3-43c3-909e-592297bd2186");
        }
    }
}
