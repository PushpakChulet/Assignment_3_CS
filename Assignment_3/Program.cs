using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Listofproducts = new List<Name_products>();

            Listofproducts.Add(new Name_products() { name = "lettuce", price = 10.5f, quantity = 50, type = "Leafy green" });
            Listofproducts.Add(new Name_products() { name = "cabbage", price = 20f, quantity = 100, type = "Cruciferous" });
            Listofproducts.Add(new Name_products() { name = "pumpkin", price = 30f, quantity = 30, type = "Marrow" });
            Listofproducts.Add(new Name_products() { name = "cauliflower", price = 10f, quantity = 25, type = "Cruciferous" });
            Listofproducts.Add(new Name_products() { name = "zucchini", price = 20.5f, quantity = 50, type = "Marrow" });
            Listofproducts.Add(new Name_products() { name = "yam", price = 30f, quantity = 50, type = "Root" });
            Listofproducts.Add(new Name_products() { name = "spinach", price = 10f, quantity = 100, type = "Leafy green" });
            Listofproducts.Add(new Name_products() { name = "broccoli", price = 20.2f, quantity = 75, type = "Cruciferous" });
            Listofproducts.Add(new Name_products() { name = "garlic", price = 30f, quantity = 20, type = "Leafy green" });
            Listofproducts.Add(new Name_products() { name = "silverbeet", price = 10f, quantity = 50, type = "Marrow" });

            Console.WriteLine("Total products = " + Listofproducts.Count);
            Console.WriteLine();

            Listofproducts.Add(new Name_products() { name = "Potato", price = 10f, quantity = 50, type = "Root" });

            foreach (var pr in Listofproducts)
            {
                Console.WriteLine($"Name = {pr.name}         Price = {pr.price} Rs      Quantity = {pr.quantity}       Type = {pr.type}");
            }

            Console.WriteLine();
            Console.WriteLine($"Total Products = {Listofproducts.Count}");
            Console.WriteLine();

            foreach (var r in Listofproducts)
            {
                if (r.type.Equals("Leafy green"))
                {
                    Console.WriteLine($"Name = {r.name}      Price = {r.price} Rs        Quantity = {r.quantity}        Type = {r.type}");
                }
            }

            Console.WriteLine();

            Listofproducts.RemoveAt(8);

            Console.WriteLine("Total Products=" + Listofproducts.Count);
            Console.WriteLine();

            Console.WriteLine("add cabbages: ");
            var cab = int.Parse(Console.ReadLine());

            Listofproducts[1].quantity += cab;
            Console.WriteLine();
            Console.WriteLine("Toatl Cabbages: " + Listofproducts[1].quantity);
            Console.WriteLine();

            float sum = 0;

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the number of item You wanna Buy:");
                int i = 1;
                foreach (var variab in Listofproducts)
                {
                    Console.WriteLine("  " + i + " " + variab.name + " " + variab.price + "Rs/kg");
                    i++;
                }

                Console.WriteLine("Press 0 to EXIT");
                Console.WriteLine();

                move:

                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                else if (x > Listofproducts.Count)
                {
                    Console.WriteLine("Invalid Option: Please Re-Enter you item number:");
                    goto move;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("How Many Kgs:");
                    int k = int.Parse(Console.ReadLine());
                    sum += (Listofproducts[x - 1].price * k);
                    Console.WriteLine();
                }

            }

            Console.WriteLine("You need to pay: " + Math.Round(sum));

        }
    }
}
