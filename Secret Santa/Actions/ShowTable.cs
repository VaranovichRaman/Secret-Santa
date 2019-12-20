using Secret_Santa.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_Santa.Actions
{
    public class ShowTable : IShowTable
    {
        public void ShowTableOfPersons()
        {
            using (var context = new SomeContext())
            {
                Console.WriteLine($"This is table of persons:");
                foreach (var personInTable in context.Persons)
                {
                    Console.WriteLine($"{personInTable.Id} --- {personInTable.Name}");
                }
            }
        }
    }
}
