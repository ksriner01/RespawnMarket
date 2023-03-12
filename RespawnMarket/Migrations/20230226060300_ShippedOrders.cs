////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the 20230226060300_ShippedOrders.cs file
//
// The 20230226060300_ShippedOrders class generates a schema for the database of orders that have been shipped.
// The class, like other migration classes, has an Up and Down method for Adding columns and Dropping columns.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RespawnMarket.Migrations
{
    public partial class ShippedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "Orders");
        }
    }
}
