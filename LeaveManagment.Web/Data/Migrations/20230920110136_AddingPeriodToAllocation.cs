using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a255-9158-43c5-b4d6-767818907757",
                column: "ConcurrencyStamp",
                value: "9601aa32-6503-4b0d-9fd6-fe3aa1490e25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a255-9158-46c5-b4a6-769818907707",
                column: "ConcurrencyStamp",
                value: "2e017628-0bb7-45a6-bb3e-e3d2a153e5f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3500936c-6b1e-43ee-8e99-ccc2b3b16ebf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35cad2ff-136b-455a-8ddf-6d80d0725c66", "AQAAAAEAACcQAAAAELamfckH0TlUEmPXpFpSX0uOKgONvPWzWhUl6SYk7KaF5iT5nNv9ShStZz2x5D4aKQ==", "b0542bec-7143-438f-bf2a-14a7092decf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52fb7cd-7aa3-43c3-909e-592297bd2186",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f95b6bea-4add-4269-aee0-30a47bb66b73", "AQAAAAEAACcQAAAAEP+OIzAMgdGPoaUmlhU3aM49CWAf91oJrFO//s2Sd3d479hsXs7TLAeyVQoqK1BC1Q==", "9c2dbe88-25de-44ab-a487-df82997a91f2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fa144fe-772d-4a1f-9e60-ac42ebe7b39b", "AQAAAAEAACcQAAAAEFw5QqnKMqUC45p02ba235Ni++z5SaeOzxwCqT+CeeBnM0dKFJ+E0nrmQWqcpEkLtA==", "ad476ed9-6ce1-4fe4-bd48-d09f93db1328" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52fb7cd-7aa3-43c3-909e-592297bd2186",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d09cf66-604e-43ec-82b2-10373a63ea97", "AQAAAAEAACcQAAAAECMr64RlGSo/gLthwE9io7cuSIfLJmO0S7d8erCOiDkU2Cz/5hQq71YpkmKNAVQGbw==", "368384ff-6b0a-4d3a-9d1e-cc4ea9054f02" });
        }
    }
}
