using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedDefaultUserUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a255-9158-43c5-b4d6-767818907757",
                column: "ConcurrencyStamp",
                value: "e915d0cf-77c5-4bd3-b5d6-5edc1f1fe188");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a255-9158-46c5-b4a6-769818907707",
                column: "ConcurrencyStamp",
                value: "4349a55e-9df8-4a7f-a46f-dfe30e9ee80f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7fa144fe-772d-4a1f-9e60-ac42ebe7b39b", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFw5QqnKMqUC45p02ba235Ni++z5SaeOzxwCqT+CeeBnM0dKFJ+E0nrmQWqcpEkLtA==", "ad476ed9-6ce1-4fe4-bd48-d09f93db1328", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52fb7cd-7aa3-43c3-909e-592297bd2186",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6d09cf66-604e-43ec-82b2-10373a63ea97", true, "IVAN@GMAIL.COM", "AQAAAAEAACcQAAAAECMr64RlGSo/gLthwE9io7cuSIfLJmO0S7d8erCOiDkU2Cz/5hQq71YpkmKNAVQGbw==", "368384ff-6b0a-4d3a-9d1e-cc4ea9054f02", "ivan@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a255-9158-43c5-b4d6-767818907757",
                column: "ConcurrencyStamp",
                value: "c4f7815f-852b-457b-9caf-36303da4686f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a255-9158-46c5-b4a6-769818907707",
                column: "ConcurrencyStamp",
                value: "57224fb2-7dad-44bc-9416-fd11ac303d24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3ccf39a8-0c74-4d56-866d-ae5c3d9621a6", false, null, "AQAAAAEAACcQAAAAEP1U9Wq4jnZ1eyAQ19cPuh7rRvOS+r4VotXeZgO03JiEfvCR3lmcfsreCFb2Vz+Rag==", "718fcdd6-4857-432e-b534-b7a45dcdfb78", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52fb7cd-7aa3-43c3-909e-592297bd2186",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3d7c8bfa-5cb2-43d8-b911-de4605e07865", false, null, "AQAAAAEAACcQAAAAEHIGKhtoGgpWySTTcU2/I/9dUZIxCyOn+EQlZ6MBQgVC6pDigseGnXARtvUfJNurVg==", "77108155-75fc-475a-b300-bad295df355d", null });
        }
    }
}
