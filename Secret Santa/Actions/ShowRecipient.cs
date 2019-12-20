using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Secret_Santa.Actions
{
    public class ShowRecipient
    {
        public void ShowMan()
        {
            using (var context = new SomeContext())
            {
                Console.WriteLine($"Inter your name and you'll can findout to whom you need to buy a present!!!");
                var yourName = Console.ReadLine();
                var recipient = context.Persons.Single(x=>x.Name == yourName).GiftedFriend;
                Console.WriteLine($"{yourName} you're {recipient}'s SS agent, congratulations!!!");
            }
        }
    }
}
