using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace revirewsAPI.Migrations.ProductTag
{
    public partial class ProdutTagContextV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminsId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    TagID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTags_Admin_AdminsId",
                        column: x => x.AdminsId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tag_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });


            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_AdminsId",
                table: "ProductTags",
                column: "AdminsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductID",
                table: "ProductTags",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagID",
                table: "ProductTags",
                column: "TagID");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

        }
    }
}
