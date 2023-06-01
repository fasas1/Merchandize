using Merchantdized.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Merchantdized.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
             new Product
             {
                 Id = 1,
                 Name = "Macbook Pro",
                 Description = "2017 Macbook Pro - Corei5 - 16gb RAM - 512gb SSD - Touchbar - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574595/Macbook_Pro_vvbq1q.png",
                 Price = 380000,
                 Category = "Macbook",

             }, new Product
             {
                 Id = 2,
                 Name = "Asus ROG",
                 Description = "Asus ROG Strix G713M - 32gb RAM - 1tb SSD - Ryzen 7 - 11th Generation - RGB Backlit - 6gb Nvidia RTX 3060 - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574594/Asus_ROG_owaj4r.png",
                 Price = 760000,
                 Category = "Gaming PC",

             }, new Product
             {
                 Id = 3,
                 Name = "Iphone 13Pro",
                 Description = "Iphoe 13Pro - 512gb Storage - Factory Unlock - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574592/Iphone_13_Promax_i8mop8.png",
                 Price = 420000,
                 Category = "Iphone",

             }, new Product
             {
                 Id = 4,
                 Name = "Alienware M15",
                 Description = "Alienware M15 R7 - 16gb RAM - 512gb SSD - 10th Generation - 6gb Nvidia RTX 2080 - RGB Backlit - Factory Unlock - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/Alienware_ijwzbh.png",
                 Price = 530000,
                 Category = "Gaming PC",

             }, new Product
             {
                 Id = 5,
                 Name = "Iwatch",
                 Description = "Iwatch Series 7 - 44MM - GPS and Cellular - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/iwatch_i9c7sp.png",
                 Price = 240000,
                 Category = "Iwatch",

             }, new Product
             {
                 Id = 6,
                 Name = "HP Pavillion",
                 Description = "Pavillion 15 - 16gb RAM - 512gb SSD - 4gb Nvidia GTX 1060 - 9th Generation - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/HP_Pavillion_nyey1g.png",
                 Price = 360000,
                 Category = "Gaming PC",

             }, new Product
             {
                 Id = 7,
                 Name = "HP Elitebook",
                 Description = "HP Elitebook 1030 G2 - Corei5 - 16gb RAM - 25gbg SSD - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/HP_14_tohtif.png",
                 Price = 250000,
                 Category = "Laptop",

             }, new Product
             {
                 Id = 8,
                 Name = "Iphone 14",
                 Description = "Iphone 14 - 512gb Storage - Factory Unlock - Pacific Blue Color - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/Iphone_14_bwnejg.png",
                 Price = 560000,
                 Category = "Iphone",

             }, new Product
             {
                 Id = 9,
                 Name = "Dell G7",
                 Description = "Dell G7 Gaming Laptop - Corei7 - 16gb RAM - 512gb SSD - 6gb Nvidia RTX 2070 - 10th Generation - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574591/Dell_G7_r9ugk7.png",
                 Price = 485000,
                 Category = "Gaming PC",

             }, new Product
             {
                 Id = 10,
                 Name = "Macbook Pro",
                 Description = "2019 Macbook Pro - 16gb RAM - 512gb SSD - Touchbar - Pickup available at  No. 1 Kodeosho street, Obafemi Awolowo way Ikeja, Computer Village, Lagos State.",
                 Image = "https://res.cloudinary.com/dgsjzsrw4/image/upload/v1685574593/Mabook_Pro_aicpdz.png",
                 Price = 455000,
                 Category = "Macbook",
             }
             );

     }
    }
}
