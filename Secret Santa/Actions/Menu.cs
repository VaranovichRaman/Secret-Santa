using Secret_Santa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_Santa.Actions
{
    class Menu
    {
        public void Start() 
        {
            while (true)
            {
                Console.WriteLine($"Welcome in the SS organization!");
                PersonCreate person = new PersonCreate();
                person.CreatePerson();
                ChooseGiftRecipient choose = new ChooseGiftRecipient();
                choose.Choose();
                ShowRecipient show = new ShowRecipient();
                show.ShowMan();
            }            
        }
    }
}
