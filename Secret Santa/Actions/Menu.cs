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
            PersonCreate person = new PersonCreate();
            person.CreatePerson();
            ChooseGiftRecipient choose = new ChooseGiftRecipient();
            choose.Choose();
        }
    }
}
