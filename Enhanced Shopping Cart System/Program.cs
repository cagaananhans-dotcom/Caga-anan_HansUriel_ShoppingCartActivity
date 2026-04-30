using ShoppingCartSystem;

namespace ShoppingCartSystem
{
    class Program
    {
        const int MAX_CART          = 10;
        const int MAX_ORDERS        = 50;
        const int LOW_STOCK_LEVEL   = 5;
        const double DISCOUNT_MIN   = 5000;
        const double DISCOUNT_RATE  = 0.10;

        static Product[] menu        = new Product[10];
        static CartItem[] cart       = new CartItem[MAX_CART];
        static int cartCount         = 0;

        static Receipt[] orderHistory = new Receipt[MAX_ORDERS];
        static int orderCount         = 0;
        
        static void Main()
        {
            menu[0] = new Product(1,  "Chair",       1_500.00, 10, "Furniture");
            menu[1] = new Product(2,  "Table",       3_000.00, 10, "Furniture");
            menu[2] = new Product(3,  "Sofa",       10_000.00, 10, "Furniture");
            menu[3] = new Product(4,  "Bed",        15_000.00, 10, "Furniture");
            menu[4] = new Product(5,  "Bookshelf",   5_000.00, 10, "Furniture");
            menu[5] = new Product(6,  "Dresser",     7_500.00, 10, "Appliances");
            menu[6] = new Product(7,  "Ref",        25_000.00, 10, "Appliances");
            menu[7] = new Product(8,  "Microwave",   8_000.00, 10, "Appliances");
            menu[8] = new Product(9,  "Aircon",     35_000.00, 10, "Appliances");
            menu[9] = new Product(10, "Wall Clock",    800.00, 10, "Home Decor");
    
            bool running = true;
    
            while (running)
            {
                ShowMainMenu();
                string choice = Console.ReadLine();
    
                if (choice == "1")
                {
                    ShoppingLoop();
                }
                else if (choice == "2")
                {
                    ShowOrderHistory();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("\nGoodbye! Thank you for using our system.");
                    running = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.");
                    PressAnyKey();
                }
            }
        }

        static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║     SHOPPING CART SYSTEM  v2.0       ║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine("║   1. Start Shopping                  ║");
            Console.WriteLine("║   2. View Order History              ║");
            Console.WriteLine("║   3. Exit                            ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.Write("\nEnter your choice: ");
        }
    }
}
