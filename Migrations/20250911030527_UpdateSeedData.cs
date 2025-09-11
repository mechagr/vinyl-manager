using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Bio",
                value: "Pioneering electronic musicians; atmospheric, cinematic soundscapes.");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                column: "Bio",
                value: "Japanese synthesist; cinematic, otherworldly music.");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                column: "Bio",
                value: "Experimental psychedelic band; emotive, introspective themes.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Electronic music genre.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Progressive rock genre.");

            migrationBuilder.UpdateData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 1,
                column: "Notes",
                value: "Hypnotic, cosmic.");

            migrationBuilder.UpdateData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 2,
                column: "Notes",
                value: "Ethereal, mysterious.");

            migrationBuilder.UpdateData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 3,
                column: "Notes",
                value: "Mellow, introspective.");
        }

    }     
}
