using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class MenuItem
    {
        // Properties to represent the characteristics of a menu item
        public MenuCategory Category { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }

        // Constructor to initialize the menu item
        public MenuItem(MenuCategory category, string shortDescription, string longDescription, decimal retailPrice, decimal cost, string imageUrl)
        {
            Category = category;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            RetailPrice = retailPrice;
            Cost = cost;
            ImageUrl = imageUrl;
        }

        public enum MenuCategory
        {
            Coffee,
            Tea,
            Breakfast,
            Pastry
        }

        public static List<MenuItem> GetMenuItems()
        {
            // Create a list to store menu items.
            List<MenuItem> menu = new List<MenuItem>();

            // Add Coffee Items
            menu.Add(new MenuItem(MenuCategory.Coffee, "Espresso", "A concentrated coffee brewed by forcing a small amount of nearly boiling water through finely-ground coffee beans. It forms the base for many other coffee beverages.", 2.99m, 1.50m,
                             "https://blogstudio.s3.theshoppad.net/coffeeheroau/ec178d83e5f597b162cda1e60cb64194.jpg"));
            menu.Add(new MenuItem(MenuCategory.Coffee, "Cappuccino", "An espresso-based coffee with equal parts of espresso steamed milk and milk foam. It's known for its creamy texture and rich flavor.", 4.49m, 2.75m,
                             "https://img.freepik.com/premium-photo/hot-coffee-morning-wooden-table_838382-54.jpg"));

            // Add Tea Items
            menu.Add(new MenuItem(MenuCategory.Tea, "Green Tea", "Green tea is a type of tea made from unoxidized leaves. It is known for its earthy and slightly grassy flavor.", 2.49m, 1.20m,
                             "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9GoBCYKA5k1mnopa1xScF-xZ3d-dMia4RFi-x1n0gvAyvWtxf3b0dOPCY0aAmTaWJWXU&usqp=CAU"));
            menu.Add(new MenuItem(MenuCategory.Tea, "Black Tea", "Black tea is fully oxidized and has a robust bold flavor. It is a popular choice for breakfast tea and is often enjoyed with milk and sugar.", 4.99m, 2.95m,
                             "https://www.healthifyme.com/blog/wp-content/uploads/2020/02/Black-Tea-2-1.jpg"));

            // Add Breakfast Items
            menu.Add(new MenuItem(MenuCategory.Breakfast, "Cereal", "A quick and easy breakfast option often served with milk or yogurt. There are many types of breakfast cereals from cornflakes to granola.", 1.99m, .50m,
                            "https://thebigmansworld.com/wp-content/uploads/2021/05/low-calorie-cereal3-500x500.jpeg"));
            menu.Add(new MenuItem(MenuCategory.Breakfast, "Omelette", "A warm and filling dish made from rolled oats often | flavored with sweeteners |fruits or nuts.", 8.49m, 4.25m,
                            "https://c.ndtvimg.com/2020-07/3cqv032o_omelette_625x300_23_July_20.jpg"));

            // Add Pastry Items
            menu.Add(new MenuItem(MenuCategory.Pastry, "Croissant", "Buttery and flaky French pastry | often crescent shaped.", 2.99m, 1.25m,
                            "https://www.delscookingtwist.com/wp-content/uploads/2020/04/Caprese-Croissant-Breakfast-Sandwich_1.jpg"));
            menu.Add(new MenuItem(MenuCategory.Pastry, "Cinnamon Roll", "Swirled | sweet yeast roll with icing.", 1.49m, 2.75m,
                             "https://images-gmi-pmc.edge-generalmills.com/269becf4-cab5-46d3-846b-ce9f9cf1f308.jpg"));

            return menu;
        }


        public static void SaveMenuItemsToFile(List<MenuItem> menu)
        {
            string fileName = "menuItem.txt";
            try
            {   //a StreamWriter with 'true' to append data to the file.
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    foreach (var menuItem in menu)
                    {
                        string line = $"{menuItem.Category},{menuItem.ShortDescription}," +
                            $"{menuItem.LongDescription},{menuItem.RetailPrice},{menuItem.Cost},{menuItem.ImageUrl}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message in a message box
                MessageBox.Show($"An error occurred while saving the menu items: {ex.Message}");
            }
        }

    }
}
