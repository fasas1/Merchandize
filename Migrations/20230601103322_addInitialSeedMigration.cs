using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Merchantdized.Migrations
{
    /// <inheritdoc />
    public partial class addInitialSeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Macbook", "2017 Macbook Pro - Corei5 - 16gb RAM - 512gb SSD - Touchbar - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574595/Macbook_Pro_vvbq1q.png", "Macbook Pro", 380000.0 },
                    { 2, "Gaming PC", "Asus ROG Strix G713M - 32gb RAM - 1tb SSD - Ryzen 7 - 11th Generation - RGB Backlit - 6gb Nvidia RTX 3060 - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574594/Asus_ROG_owaj4r.png", "Asus ROG", 760000.0 },
                    { 3, "Iphone", "Iphoe 13Pro - 512gb Storage - Factory Unlock - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574592/Iphone_13_Promax_i8mop8.png", "Iphone 13Pro", 420000.0 },
                    { 4, "Gaming PC", "Alienware M15 R7 - 16gb RAM - 512gb SSD - 10th Generation - 6gb Nvidia RTX 2080 - RGB Backlit - Factory Unlock - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/Alienware_ijwzbh.png", "Alienware M15", 530000.0 },
                    { 5, "Iwatch", "Iwatch Series 7 - 44MM - GPS and Cellular - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/iwatch_i9c7sp.png", "Iwatch", 240000.0 },
                    { 6, "Gaming PC", "Pavillion 15 - 16gb RAM - 512gb SSD - 4gb Nvidia GTX 1060 - 9th Generation - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/HP_Pavillion_nyey1g.png", "HP Pavillion", 360000.0 },
                    { 7, "Laptop", "HP Elitebook 1030 G2 - Corei5 - 16gb RAM - 25gbg SSD - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/HP_14_tohtif.png", "HP Elitebook", 250000.0 },
                    { 8, "Iphone", "Iphone 14 - 512gb Storage - Factory Unlock - Pacific Blue Color - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/Iphone_14_bwnejg.png", "Iphone 14", 560000.0 },
                    { 9, "Gaming PC", "Dell G7 Gaming Laptop - Corei7 - 16gb RAM - 512gb SSD - 6gb Nvidia RTX 2070 - 10th Generation - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/Dell_G7_r9ugk7.png", "Dell G7", 485000.0 },
                    { 10, "Macbook", "2019 Macbook Pro - 16gb RAM - 512gb SSD - Touchbar - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.", "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/Mabook_Pro_aicpdz.png", "Macbook Pro", 455000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
