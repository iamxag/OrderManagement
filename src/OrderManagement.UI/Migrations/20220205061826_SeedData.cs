using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.UI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Beverages", null },
                    { 2, "Bread/Bakery", null },
                    { 3, "Canned/Jarred Goods", null },
                    { 4, "Dairy", null },
                    { 5, "Dry/Baking Goods", null },
                    { 6, "Frozen Foods", null },
                    { 7, "Meat", null },
                    { 8, "Produce", null },
                    { 9, "Cleaners", null },
                    { 10, "Paper Goods", null },
                    { 11, "Personal Care", null },
                    { 12, "Other", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, null, "/Images/BNaturalsPomegranate.jpg", true, true, "B Natural Pomegranate Juice is made with the choicest Pomegranate fruits to give you the most authentic product. It contains 100% natural fruit juice, and 0% Concentrate. This delicious fruit juice does not contain any added preservatives, no added flavour. Each sip of B Natural Pomegranate Juice is rich in Vitamin C, and contains the goodness of fiber.", "B Natural 100% Pomegranate Juice 1L", 159.20m, "Our famous apple Products!" },
                    { 4, 1, null, "/Images/SunfeastBadamMilk.jpg", true, false, "Treat yourself with an exciting tasteful adventure and discover Wonderz of Milk in every sip. NutShakes Kesar Badam is a wonderful blend of the goodness of nuts and milk. Made with real Badam Bits and Kesar, it promises a delightful experience. This product contains no preservatives and is a source of protein and calcium.", "Sunfeast Badam Milk", 28m, "Sunfeast Wonderz Milk Badam Flavoured Milk 180ml" },
                    { 7, 1, null, "/Images/SunbeanCoffee.jpg", false, false, "Sunbean Nicamalai Gourmet Coffee is an exotic blend of best coffees from Nicaragua and Anamalai. Blended to create an alchemy of great taste and aroma, Sunbean Nicamalai Gourmet Coffee is the culmination of ITC’s 30+ years of experience working with some of the finest coffee in India and across the world. This gourmet coffee blend is crafted by an expert master blender to give our consumers the most luxurious coffee experience.", "Sunbean Coffee", 250m, "Sunbean Gourmet Coffee Nicamalai 100g" },
                    { 9, 1, null, "/Images/DiwaliFestiveGiftPacks.jpg", true, true, "With Raksha Bandhan around the corner, shower your blessings to your siblings with special Rakhi Gifts. Give the Gift of Immunity this Season with B Natural Mixed Fruit and Orange which have clinically proven Green Coffee Extract which helps support immunity. It comes in an attractive reusable bag.", "B Natural Immunity Gift Pack", 208m, "B Natural Immunity Gift Pack" },
                    { 2, 2, null, "/Images/KarachiBisuits.jpg", true, false, "Italian Cheese Biscuits are absolutely delightful. These savory drop biscuits are filled with Italian herbs like basil, thyme, oregano and marjoram. They also include sharp cheddar cheese and garlic powder to amp up the flavors. Buy these tasty delicacy from KARACHI BAKERY (Hyderabad)", "Karachi Biscuit", 160m, "Karachi Bakery Italian Cheese Short Bread Biscuit" },
                    { 3, 2, null, "/Images/cheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", "Cheese Cake", 200m, "Plain cheese cake. Plain pleasure." },
                    { 11, 2, null, "/Images/Tandoori Seekh Kebab.jpg", false, false, "The Field Grill brings to you Tandoori Seekh Kebab are plant-based. We help you make your cooking life easy. This is a delicious meat-free addition to any diet. A spicy flavoured veggie kebab with a crispy, crunchy breading outside and tender inside. It is a rich source of protein and fibre. These kebabs are a quick, convenient meat-free meal option. It is easy to prepare a meal or snack that is loved by kids or adults alike. It has fresh ingredients without any added preservatives and is hygienically packed.", "Tandoori Seekh Kebab", 399m, "The field Grill Co. BBQ Strips - Spicy & Smoky, Plant Based, 200g" },
                    { 5, 3, null, "/Images/KnorrSweetCorn.jpg", true, false, "Knorr has hand-picked the best quality vegetables and mixed it with spices to make delicious Knorr Sweet Corn Chicken Soup. A perfect blend of corn, carrots, cabbage and chinese flavors with real chicken gives it its lip-smacking taste and perfect consistency. Made with 100% real vegetables and no added preservatives, this soup is ready in three simple steps and serves four. So now enjoy Restaurant like delicious Soup at home.Knorr Soups range comprises of 11 delicious flavours of 4 serve soups and 7 flavours of Cup-a-soup. Great taste is in our Nature! Knorr has gone to great lengths to ensure a perfect blend of ingredients and consistency that give you Restaurant like Soup at home.About Knorr:Just like you, we love everything about food, because no delicious meal is cooked without love. Love for carefully selected ingredients, flavours and spices, or the aroma of dinner wafting through your home. Love for the people you feed everyday; your family and friends, relatives and guests, the people that matter to you the most. With Knorr as your cooking partner, you can serve your loved ones nutritious and flavourful meals at home. Soup Fun Fact - The word 'soup' is of Sanskrit origin! It is derived from the su and po, which means good nutrition.", "Knorr Soup", 55m, "Knorr Sweet Corn Chicken Soup, 42g" },
                    { 6, 3, null, "/Images/BorgePepper.jpg", true, false, "Green manzanilla olives stuffed with spicy pepper paste", "Borges Green Olives", 179m, "Borges Hot Pepper Stuffed Green Olives, 450g" },
                    { 8, 3, null, "/Images/Ching's Soup.jpg", true, true, "Ching's Instant Manchow Soup, 55g", "Ching's Soup", 40m, "Ching's Instant Manchow Soup, 55g" },
                    { 10, 6, null, "/Images/BBQ Strips.jpg", true, false, "The Field Grill brings to you BBQ Strips, these strips are plant-based. It is made with the finest quality ingredients. This is a delicious meat-free addition to any diet. A barbecue flavoured veggie strips with a crispy, crunchy breading outside and tender inside. It is a rich source of protein and fibre. These strips are a quick, convenient meat-free meal option. It is easy to prepare a meal or snack that is loved by kids or adults alike.", "BBQ Strips - Spicy & Smoky", 399m, "The field Grill Co. BBQ Strips - Spicy & Smoky, Plant Based, 200g" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
