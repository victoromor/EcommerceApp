using EcommerceApp.Data;
using EcommerceApp.Models;

using EcommerceContext context = new EcommerceContext();

/*Add Data to database*/

//Product Biscuits = new Product()
//{
//    Name = "McVities Cookies",
//    Price = 109.99M
//};
//context.Products.Add(Biscuits);

//Product Soap = new Product()
//{
//    Name = "Nivea Body Soap",
//    Price = 350M
//};
//context.Add(Soap);
//context.SaveChanges();


/* Update Data in the Database */

var Biscuits = context.Products
    .Where(x => x.Name == "McVities Cookies")
    .FirstOrDefault();

if(Biscuits is Product)
{
    Biscuits.Price = 215M;
}

/* Delete Data from the Database */
//if (Biscuits is Product)
//{
//    context.Remove(Biscuits);
//}


context.SaveChanges();


/* Read Data from the Database */

var products = from product in context.Products
               where product.Price > 200M
               orderby product.Name
               select product;

//var products = context.Products
//    .Where(p => p.Price > 200M)
//    .OrderBy(p => p.Name);

foreach(Product p in products)
{
    Console.WriteLine($"Id:     {p.Id}");
    Console.WriteLine($"Name:   {p.Name}");
    Console.WriteLine($"Price:  {p.Price}");
    Console.WriteLine(new string('-', 20));
}





