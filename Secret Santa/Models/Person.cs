using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_Santa.Models
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string GiftedFriend { get; set; }         
    }
}
