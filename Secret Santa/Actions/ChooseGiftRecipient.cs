using Secret_Santa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Santa.Actions
{
    public class ChooseGiftRecipient
    {
        public async Task Choose()
        {
            using (var context = new SomeContext())
            {
                var row = context.Persons.OrderBy(x => Guid.NewGuid()).ToList();
                Console.WriteLine($"Mixed");
                Person temp = null;
                foreach (var item in row)
                {
                    if (temp != null)
                    {

                        temp.GiftedFriend = item.Name;
                    }
                    else
                    {
                        row.Last().GiftedFriend = item.Name;
                    }
                    temp = item;
                }
                Console.WriteLine($"who to whom:");
                foreach (var item in context.Persons)
                {
                    Console.WriteLine($"{item.Name} gifts to {item.GiftedFriend}");
                }
                Console.ReadLine();
                context.SaveChanges();
            }
        }
    }
}


