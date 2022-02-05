using Microsoft.EntityFrameworkCore;

namespace OrderManagement.UI.Models
{
    public class AppDbContext : DbContext
    {
        //add-migration migrationName  -- when we want to create new migration
        //updatabase - to update database with current(latest) migration
        //update-database -migration migrationname(InitialCommit) - Only Name with out trailing key and .cs
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Beverages" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Bread/Bakery" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Canned/Jarred Goods" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Dairy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Dry/Baking Goods" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Frozen Foods" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Meat" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 8, CategoryName = "Produce" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 9, CategoryName = "Cleaners" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 10, CategoryName = "Paper Goods" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 11, CategoryName = "Personal Care" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 12, CategoryName = "Other" });

            //seed Products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "B Natural 100% Pomegranate Juice 1L",
                Price = 159.20M,
                ShortDescription = "Our famous apple Products!",
                LongDescription = "B Natural Pomegranate Juice is made with the choicest Pomegranate fruits to give you the most authentic product. It contains 100% natural fruit juice, and 0% Concentrate. This delicious fruit juice does not contain any added preservatives, no added flavour. Each sip of B Natural Pomegranate Juice is rich in Vitamin C, and contains the goodness of fiber.",
                CategoryId = 1,
                ImageUrl = "/Images/BNaturalsPomegranate.jpg",
                InStock = true,
                IsProductOfTheWeek = true,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Karachi Biscuit",
                Price = 160M,
                ShortDescription = "Karachi Bakery Italian Cheese Short Bread Biscuit",
                LongDescription = "Italian Cheese Biscuits are absolutely delightful. These savory drop biscuits are filled with Italian herbs like basil, thyme, oregano and marjoram. They also include sharp cheddar cheese and garlic powder to amp up the flavors. Buy these tasty delicacy from KARACHI BAKERY (Hyderabad)",
                CategoryId = 2,
                ImageUrl = "/Images/KarachiBisuits.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Cheese Cake",
                Price = 200M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "/Images/cheesecake.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Sunfeast Badam Milk",
                Price = 28M,
                ShortDescription = "Sunfeast Wonderz Milk Badam Flavoured Milk 180ml",
                LongDescription = "Treat yourself with an exciting tasteful adventure and discover Wonderz of Milk in every sip. NutShakes Kesar Badam is a wonderful blend of the goodness of nuts and milk. Made with real Badam Bits and Kesar, it promises a delightful experience. This product contains no preservatives and is a source of protein and calcium.",
                CategoryId = 1,
                ImageUrl = "/Images/SunfeastBadamMilk.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Knorr Soup",
                Price = 55M,
                ShortDescription = "Knorr Sweet Corn Chicken Soup, 42g",
                LongDescription = "Knorr has hand-picked the best quality vegetables and mixed it with spices to make delicious Knorr Sweet Corn Chicken Soup. A perfect blend of corn, carrots, cabbage and chinese flavors with real chicken gives it its lip-smacking taste and perfect consistency. Made with 100% real vegetables and no added preservatives, this soup is ready in three simple steps and serves four. So now enjoy Restaurant like delicious Soup at home.Knorr Soups range comprises of 11 delicious flavours of 4 serve soups and 7 flavours of Cup-a-soup. Great taste is in our Nature! Knorr has gone to great lengths to ensure a perfect blend of ingredients and consistency that give you Restaurant like Soup at home.About Knorr:Just like you, we love everything about food, because no delicious meal is cooked without love. Love for carefully selected ingredients, flavours and spices, or the aroma of dinner wafting through your home. Love for the people you feed everyday; your family and friends, relatives and guests, the people that matter to you the most. With Knorr as your cooking partner, you can serve your loved ones nutritious and flavourful meals at home. Soup Fun Fact - The word 'soup' is of Sanskrit origin! It is derived from the su and po, which means good nutrition.",
                CategoryId = 3,
                ImageUrl = "/Images/KnorrSweetCorn.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Borges Green Olives",
                Price = 179M,
                ShortDescription = "Borges Hot Pepper Stuffed Green Olives, 450g",
                LongDescription = "Green manzanilla olives stuffed with spicy pepper paste",
                CategoryId = 3,
                ImageUrl = "/Images/BorgePepper.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Sunbean Coffee",
                Price = 250M,
                ShortDescription = "Sunbean Gourmet Coffee Nicamalai 100g",
                LongDescription = "Sunbean Nicamalai Gourmet Coffee is an exotic blend of best coffees from Nicaragua and Anamalai. Blended to create an alchemy of great taste and aroma, Sunbean Nicamalai Gourmet Coffee is the culmination of ITC’s 30+ years of experience working with some of the finest coffee in India and across the world. This gourmet coffee blend is crafted by an expert master blender to give our consumers the most luxurious coffee experience.",
                CategoryId = 1,
                ImageUrl = "/Images/SunbeanCoffee.jpg",
                InStock = false,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Ching's Soup",
                Price = 40M,
                ShortDescription = "Ching's Instant Manchow Soup, 55g",
                LongDescription = "Ching's Instant Manchow Soup, 55g",
                CategoryId = 3,
                ImageUrl = "/Images/Ching's Soup.jpg",
                InStock = true,
                IsProductOfTheWeek = true,
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "B Natural Immunity Gift Pack",
                Price = 208M,
                ShortDescription = "B Natural Immunity Gift Pack",
                LongDescription = "With Raksha Bandhan around the corner, shower your blessings to your siblings with special Rakhi Gifts. Give the Gift of Immunity this Season with B Natural Mixed Fruit and Orange which have clinically proven Green Coffee Extract which helps support immunity. It comes in an attractive reusable bag.",
                CategoryId = 1,
                ImageUrl = "/Images/DiwaliFestiveGiftPacks.jpg",
                InStock = true,
                IsProductOfTheWeek = true,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "BBQ Strips - Spicy & Smoky",
                Price = 399M,
                ShortDescription = "The field Grill Co. BBQ Strips - Spicy & Smoky, Plant Based, 200g",
                LongDescription = "The Field Grill brings to you BBQ Strips, these strips are plant-based. It is made with the finest quality ingredients. This is a delicious meat-free addition to any diet. A barbecue flavoured veggie strips with a crispy, crunchy breading outside and tender inside. It is a rich source of protein and fibre. These strips are a quick, convenient meat-free meal option. It is easy to prepare a meal or snack that is loved by kids or adults alike.",
                CategoryId = 6,
                ImageUrl = "/Images/BBQ Strips.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Tandoori Seekh Kebab",
                Price = 399M,
                ShortDescription = "The field Grill Co. BBQ Strips - Spicy & Smoky, Plant Based, 200g",
                LongDescription = "The Field Grill brings to you Tandoori Seekh Kebab are plant-based. We help you make your cooking life easy. This is a delicious meat-free addition to any diet. A spicy flavoured veggie kebab with a crispy, crunchy breading outside and tender inside. It is a rich source of protein and fibre. These kebabs are a quick, convenient meat-free meal option. It is easy to prepare a meal or snack that is loved by kids or adults alike. It has fresh ingredients without any added preservatives and is hygienically packed.",
                CategoryId = 2,
                ImageUrl = "/Images/Tandoori Seekh Kebab.jpg",
                InStock = false,
                IsProductOfTheWeek = false,
            });
        }
    }
}
