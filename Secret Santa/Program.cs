using Microsoft.EntityFrameworkCore;
using Secret_Santa.Actions;
using Secret_Santa.Models;
using System;
using System.Threading.Tasks;

namespace Secret_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu startMenu = new Menu();
            startMenu.Start();
        }
    }
}

