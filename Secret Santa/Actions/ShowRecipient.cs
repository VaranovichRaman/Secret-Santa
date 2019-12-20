using Secret_Santa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Secret_Santa.Actions
{
    public class ShowRecipient : IShowRecipient
    {
        public void ShowMan()
        {
            using (var context = new SomeContext())
            {
                Console.WriteLine($"Enter your name to find out who you are buying the gift for:\n");
                var yourName = Console.ReadLine();
                var recipient = context.Persons.Single(x=>x.Name == yourName).GiftedFriend;
                Console.WriteLine($"{yourName} you're {recipient}'s SS agent, congratulations!!!\n");
            }
        }
    }
}
