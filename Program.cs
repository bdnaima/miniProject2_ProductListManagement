Console.WriteLine("PRODUCT LIST APPLICATION");
Console.WriteLine("Type 'q' to quit");

ProductManager productManager = new ProductManager();
productManager.AddProduct();
productManager.ShowProducts();
productManager.CalculateTotal();

