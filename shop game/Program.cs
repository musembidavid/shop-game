// See https://aka.ms/new-console-template for more information
using System.Timers;

int Peperroni_pizza = 28;
int Crispy_chicken_burger = 7;
int Cheese_pizza = 31;
int Garlic_bread = 12;

Console.WriteLine("hello you are at the food shop here we sell food");
Thread.Sleep(2000);
Console.WriteLine("our food menu has peperoni pizza which is " + Peperroni_pizza + "$");
Thread.Sleep(2000);
Console.WriteLine("our food menu also has a crispy chicken burger which is " + Crispy_chicken_burger + "$");
Thread.Sleep(2000);
Console.WriteLine("in addition to peperroni pizza our food menu has cheese pizza which is " + Cheese_pizza + "$");
Thread.Sleep(2000);
Console.WriteLine("last of all food menu has Garlic bread which is " + Garlic_bread + "$");
Thread.Sleep(2000);
Console.WriteLine("so what do you want");
String food = Console.ReadLine();
Console.WriteLine("ok your " + food + " will be ready in 15 - 20 minutes take a seat");
Console.ReadLine();
Console.WriteLine(" 20 min later your " + food + " is here enjoy");
Console.ReadLine();
Console.WriteLine("you're done ok your bill is 12$, how would you like to pay cash or credit card");
String paymeth = Console.ReadLine();
if (paymeth == "cash")
{
    Console.WriteLine("ok pay 12 $");
    Console.WriteLine("ok thanks have a nice day");
}

if (paymeth == "credit card")
{
    Console.WriteLine("ok just swipe or tap on the card machine");
    Console.ReadLine();
    Console.WriteLine("yes it went through have a nice day");
}
