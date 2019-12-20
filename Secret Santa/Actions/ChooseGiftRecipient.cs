using Secret_Santa.Interfaces;
using Secret_Santa.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Santa.Actions
{
    public class ChooseGiftRecipient : IChoose
    {
        public async Task Choose()
        {
            using (var context = new SomeContext())
            {
                var row = context.Persons.OrderBy(x => Guid.NewGuid()).ToList();
                Mixed mix = new Mixed();
                mix.Mixing();   
                Person temp = null;
                foreach (var person in row)
                {
                    if (temp != null)
                    {

                        temp.GiftedFriend = person.Name;
                    }
                    else
                    {
                        row.Last().GiftedFriend = person.Name;
                    }
                    temp = person;
                }
                Console.WriteLine($"\nThe list of people who gives gifts to whom (to check that no one is offended):\n");
                foreach (var item in context.Persons)
                {
                    Console.WriteLine($"{item.Name} gifts to {item.GiftedFriend}");
                }
                context.SaveChanges();
            }
        }
    }
}


