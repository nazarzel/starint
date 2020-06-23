using Microsoft.EntityFrameworkCore.Migrations;

namespace Starint.Migrations
{
    public partial class initialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferColor_Colors_ColorId",
                table: "OfferColor");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferColor_Offers_OfferId",
                table: "OfferColor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferColor",
                table: "OfferColor");

            migrationBuilder.RenameTable(
                name: "OfferColor",
                newName: "OfferColors");

            migrationBuilder.RenameIndex(
                name: "IX_OfferColor_OfferId",
                table: "OfferColors",
                newName: "IX_OfferColors_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_OfferColor_ColorId",
                table: "OfferColors",
                newName: "IX_OfferColors_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferColors",
                table: "OfferColors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferColors_Colors_ColorId",
                table: "OfferColors",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferColors_Offers_OfferId",
                table: "OfferColors",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferColors_Colors_ColorId",
                table: "OfferColors");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferColors_Offers_OfferId",
                table: "OfferColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferColors",
                table: "OfferColors");

            migrationBuilder.RenameTable(
                name: "OfferColors",
                newName: "OfferColor");

            migrationBuilder.RenameIndex(
                name: "IX_OfferColors_OfferId",
                table: "OfferColor",
                newName: "IX_OfferColor_OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_OfferColors_ColorId",
                table: "OfferColor",
                newName: "IX_OfferColor_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferColor",
                table: "OfferColor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferColor_Colors_ColorId",
                table: "OfferColor",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferColor_Offers_OfferId",
                table: "OfferColor",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
