using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Secret_Santa.Models
{
    public class PersonCreate : IPersonCreate
    {
        public async Task CreatePerson()
        {            
            while (true)
            {
                var flag = true;
                using (var context = new SomeContext())
                {
                    Console.WriteLine($"This is list of humans:");
                    foreach (var item in context.Persons)
                    {
                        Console.WriteLine($"{item.Id} --- {item.Name}");
                    }
                    Console.WriteLine("Do you want to add person?(y/n)");
                    string answer = Console.ReadLine();
                    if (answer != "y") break;
                    while (flag)
                    {
                        var person = new Person();
                        Console.WriteLine("enter name:");
                        person.Name = Console.ReadLine();
                        if (context.Persons.All(x => x.Name != person.Name))
                        {
                            flag = false;
                            context.Add(person);
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine($"This human is already in list, choose anotherone!");
                        }
                    }
                    Console.WriteLine($"Do you wanna delete this table?");
                    var ans = Console.ReadLine();
                    if (ans == "y")
                    {
                       var context1 = new SomeContext();
                        Console.WriteLine($"Choose who will be killed");
                        var id =int.Parse( Console.ReadLine());
                        var table = context.Persons.Where(x => x.Name != null);                      
                        var person = new Person { Id = id };
                        context1.Persons.Remove(person);
                        context1.Persons.RemoveRange(table);
                        context1.Update(context1);
                        context1.SaveChanges();
                    }                               
                }
            }
        }
    }
}
