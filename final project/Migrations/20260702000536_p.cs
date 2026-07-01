using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_project.Migrations
{
    /// <inheritdoc />
    public partial class p : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Drivers_driverid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_orderId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_orderid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_productid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Restaurants_restaurantId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_driverid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "driverid",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "reviewdate",
                table: "Reviews",
                newName: "ReviewDate");

            migrationBuilder.RenameColumn(
                name: "restaurantId",
                table: "Reviews",
                newName: "RestaurantID");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Reviews",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Reviews",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Reviews",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "reviewId",
                table: "Reviews",
                newName: "ReviewID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_restaurantId",
                table: "Reviews",
                newName: "IX_Reviews_RestaurantID");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "OrderItems",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "orderid",
                table: "OrderItems",
                newName: "Orderid");

            migrationBuilder.RenameColumn(
                name: "orderitemid",
                table: "OrderItems",
                newName: "Orderitemid");

            migrationBuilder.RenameColumn(
                name: "uniteprice",
                table: "OrderItems",
                newName: "UnitPrice");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_productid",
                table: "OrderItems",
                newName: "IX_OrderItems_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_orderid",
                table: "OrderItems",
                newName: "IX_OrderItems_Orderid");

            migrationBuilder.RenameColumn(
                name: "pickuptime",
                table: "Deliveries",
                newName: "PickupTime");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "Deliveries",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "driverId",
                table: "Deliveries",
                newName: "DriverID");

            migrationBuilder.RenameColumn(
                name: "deliverytime",
                table: "Deliveries",
                newName: "DeliveryTime");

            migrationBuilder.RenameColumn(
                name: "deliveryId",
                table: "Deliveries",
                newName: "DeliveryID");

            migrationBuilder.RenameColumn(
                name: "DeliveryStatus",
                table: "Deliveries",
                newName: "Status");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_orderId",
                table: "Deliveries",
                newName: "IX_Deliveries_OrderID");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "userid",
                table: "Drivers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PickupTime",
                table: "Deliveries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryTime",
                table: "Deliveries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerID",
                table: "Reviews",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_userid",
                table: "Drivers",
                column: "userid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DriverID",
                table: "Deliveries",
                column: "DriverID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Drivers_DriverID",
                table: "Deliveries",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "driverid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Orders_OrderID",
                table: "Deliveries",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_AspNetUsers_userid",
                table: "Drivers",
                column: "userid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Orderid",
                table: "OrderItems",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_Productid",
                table: "OrderItems",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_CustomerID",
                table: "Reviews",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Restaurants_RestaurantID",
                table: "Reviews",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Drivers_DriverID",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_OrderID",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_AspNetUsers_userid",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Orderid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_Productid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_CustomerID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Restaurants_RestaurantID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CustomerID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_userid",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_DriverID",
                table: "Deliveries");

            migrationBuilder.RenameColumn(
                name: "ReviewDate",
                table: "Reviews",
                newName: "reviewdate");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "Reviews",
                newName: "restaurantId");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Reviews",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Reviews",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Reviews",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "ReviewID",
                table: "Reviews",
                newName: "reviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_RestaurantID",
                table: "Reviews",
                newName: "IX_Reviews_restaurantId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderItems",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "OrderItems",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "OrderItems",
                newName: "orderid");

            migrationBuilder.RenameColumn(
                name: "Orderitemid",
                table: "OrderItems",
                newName: "orderitemid");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderItems",
                newName: "uniteprice");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_Productid",
                table: "OrderItems",
                newName: "IX_OrderItems_productid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_Orderid",
                table: "OrderItems",
                newName: "IX_OrderItems_orderid");

            migrationBuilder.RenameColumn(
                name: "PickupTime",
                table: "Deliveries",
                newName: "pickuptime");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Deliveries",
                newName: "orderId");

            migrationBuilder.RenameColumn(
                name: "DriverID",
                table: "Deliveries",
                newName: "driverId");

            migrationBuilder.RenameColumn(
                name: "DeliveryTime",
                table: "Deliveries",
                newName: "deliverytime");

            migrationBuilder.RenameColumn(
                name: "DeliveryID",
                table: "Deliveries",
                newName: "deliveryId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Deliveries",
                newName: "DeliveryStatus");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_OrderID",
                table: "Deliveries",
                newName: "IX_Deliveries_orderId");

            migrationBuilder.AlterColumn<decimal>(
                name: "rating",
                table: "Reviews",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "customerId",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "Drivers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "pickuptime",
                table: "Deliveries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "deliverytime",
                table: "Deliveries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "driverid",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_driverid",
                table: "AspNetUsers",
                column: "driverid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Drivers_driverid",
                table: "AspNetUsers",
                column: "driverid",
                principalTable: "Drivers",
                principalColumn: "driverid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Orders_orderId",
                table: "Deliveries",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_orderid",
                table: "OrderItems",
                column: "orderid",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_productid",
                table: "OrderItems",
                column: "productid",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Restaurants_restaurantId",
                table: "Reviews",
                column: "restaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
