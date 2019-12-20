using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Secret_Santa.Actions;

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
                    Console.WriteLine("Do you want to add a person in table?(type \"y\" ifyes, \"other key\" if not)");
                    string answer = Console.ReadLine();
                    if (answer != "y") break;
                    while (flag)
                    {
                        var person = new Person();
                        Console.WriteLine("\nEnter name:");
                        person.Name = Console.ReadLine();
                        if (context.Persons.All(x => x.Name != person.Name))
                        {
                            flag = false;
                            context.Add(person);
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine($"This person is already in table, choose another name!");
                        }
                    }
                }
            }
        }
    }
}
