using Secret_Santa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Secret_Santa.Actions;
using Secret_Santa.Interfaces;

namespace Secret_Santa.Actions
{
    class Delete : IDelete
    {
        public void DeletePerson()
        {
            using (var context = new SomeContext())
            {
                Console.WriteLine($"Do you wanna delete someone from table? (type \"y\" ifyes, \"other key\" if not)");
                var answer = Console.ReadLine();
                if (answer == "y")
                {
                    ShowTable showTable = new ShowTable();
                    showTable.ShowTableOfPersons();
                    Console.WriteLine($"Choose who will be deleted from table. (choose number)");
                    var id = int.Parse(Console.ReadLine());
                    var person = new Person { Id = id };
                    context.Persons.Remove(person);
                    context.SaveChanges();
                }
            }
        }
        public void DeleteAll()
        {
            using (var context = new SomeContext())
            {
                Console.WriteLine($"Do you wanna delete whole table? (type \"y\" if yes, \"other key\" if not)");
                var answer = Console.ReadLine();
                if (answer == "y")
                {
                    var table = context.Persons.Where(x => x.Name != null);
                    context.Persons.RemoveRange(table);
                    context.SaveChanges();
                }
            }
        }
    }
}
