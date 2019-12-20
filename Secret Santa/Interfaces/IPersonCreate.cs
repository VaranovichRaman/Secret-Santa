using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Santa.Models
{
    public  interface IPersonCreate
    {
        Task CreatePerson();
    }
}
