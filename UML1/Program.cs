// See https://aka.ms/new-console-template for more information
using UML1;


Customer c1 = new Customer("Jon", "Elmedalen 22", "12345678", "Jon123@hotmail.com");
Customer c2 = new Customer("Sean", "Elmedalen 33", "87654321", "Sean123@hotmail.com");
Customer c3 = new Customer("Jan", "Elmedalen 11", "12342069", "Janbla123@hotmail.com");

Pizza p1 = new Pizza("Margarita", "Cheese", 70);
Pizza p2 = new Pizza("Pepperoni", "Pepperoni", 80);
Pizza p3 = new Pizza("Vesuvio", "Ham", 75);

Employee e1 = new Employee("Jonathan", "Baunedalen 1", "23455432", "Jost47@hotmail.com");


Order order1 = new Order(p1, c1, e1);
Order order2 = new Order(p2, c2, e1);
Order order3 = new Order(p3, c3, e1);

Console.WriteLine(order1.ToString());
Console.WriteLine();
Console.WriteLine(order2.ToString());
Console.WriteLine();
Console.WriteLine(order3.ToString());

//Console.WriteLine($"Employee ID: {e1.ID}");