class ProductManager {
List <Product> products = new List<Product>();
    public void AddProduct() {  
    while (true) {
            Console.Write("Enter Category: ");
            string userInputCategory = Console.ReadLine() ?? "";
    
        if (userInputCategory.Trim() == "q") {
            break;
        }

        Console.Write("Enter Name: ");
            string userInputName = Console.ReadLine() ?? "";

        if (userInputName.Trim() == "q") {
            break;
        }

        Console.Write("Enter Price: ");
            string userInputPriceInput = Console.ReadLine() ?? "";
            double userInputPrice;

        if (userInputPriceInput.Trim() == "q") {
            break;
        }

        while (true) {
            if (!double.TryParse(userInputPriceInput, out userInputPrice)) {
                Console.WriteLine("Error: Invalid number. Enter a valid number.");
                Console.Write("Enter Price: ");
                userInputPriceInput = Console.ReadLine() ?? "";
            } else {
                break;
            }
        }
        Product product1 = new Product(userInputCategory, userInputName, userInputPrice);
        products.Add(product1);
        Console.WriteLine("Product added successfully!");
        }



        Console.WriteLine("\nCategory".PadRight(20));
        Console.WriteLine("----------------------------------------------------");

       
        foreach (Product item in products) {
            Console.Write(item.Category.PadRight(20));
            Console.Write(item.Name.PadRight(20));
            Console.Write(item.Price);
            Console.Write("\n");
        }
    }
}