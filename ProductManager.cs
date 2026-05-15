
class ProductManager {
    List <Product> products = new List<Product>();
    public void AddProduct() {
        Console.WriteLine("PRODUCT LIST APPLICATION");
        Console.WriteLine("Type 'q' to quit");

        while (true) {
            Console.Write("Enter Category: ");
            string userInputCategory = Console.ReadLine() ?? "";
    
            if (userInputCategory.Trim() == "q") {
                break;
            }

            // Check if product name is empty
            string userInputName;
            while(true) {
                Console.Write("Enter Product Name: ");
                userInputName = Console.ReadLine() ?? "";
                
                if (userInputName.Trim() == "q") {
                    break;
                }

                if(string.IsNullOrWhiteSpace(userInputName)) {
                    Console.WriteLine("ERROR:");
                    Console.WriteLine("You must provide a name.");
                   continue;
                } 

                break;
            }
            if (userInputName.Trim() == "q") {
                break;
            }
         
            // Check input is valid number and check if number negative
            string userInputPriceInput;
            double userInputPrice = 0;
            while (true) {
                Console.Write("Enter Product Price: ");
                userInputPriceInput = Console.ReadLine() ?? "";
          
                if (userInputPriceInput.Trim() == "q") {
                    break;
                }

                if (!double.TryParse(userInputPriceInput, out userInputPrice)) {
                    Console.WriteLine("ERROR:");
                    Console.WriteLine("Invalid price. Enter a numeric value.");
                    continue;
                }

                if(userInputPrice < 0) {
                    Console.WriteLine("ERROR:");
                    Console.WriteLine("Price cannot be negative");
                    continue;
                }

                break;
            }
            if (userInputPriceInput.Trim() == "q") {
                break;
            }

            Product product1 = new Product(userInputCategory, userInputName, userInputPrice);
            products.Add(product1);
            Console.WriteLine("Product added successfully!");
        }
    }

    public void ShowProducts() {
        List<Product> sortedList = products.OrderBy(product => product.Price).ToList();

        Console.WriteLine("\nCategory".PadRight(20) + "Product name".PadRight(30) + "Price");
        Console.WriteLine("-----------------------------------------------------------");
       
        foreach (Product item in sortedList) {
            Console.Write(item.Category.PadRight(20));
            Console.Write("|".PadRight(5));
            Console.Write(item.Name.PadRight(20));
            Console.Write("|".PadRight(5));
            Console.Write($"{item.Price} kr");
            Console.Write("\n");
        }
    }


    public void SearchProducts() {
        Console.Write("Search Product: ");
        string userSearchInput = Console.ReadLine()?.Trim().ToLower() ?? "";

        var searchProducts = products.Where(product => product.Name.ToLower().Contains(userSearchInput) || product.Category.ToLower().Contains(userSearchInput)).ToList();

        if(searchProducts.Count == 0) {
            Console.WriteLine("No products found.");
        } else {
            Console.WriteLine("FOUND PRODUCTS:");
            foreach (Product item in searchProducts) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{item.Category} | {item.Name} | {item.Price} kr");
                Console.ResetColor();
            }
        }
        
    }

    public void CalculateTotal() {
        double sum = products.Sum(product => product.Price);

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Total price: {sum} kr");
        Console.WriteLine("------------------------------");
    }
}