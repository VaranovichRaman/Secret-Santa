using Secret_Santa.Interfaces;
using Secret_Santa.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Secret_Santa.Actions
{
    class Menu : IMenu
    {
        public void Start() 
        {
            var flag = true;
            var helloBanner = File.ReadAllLines("TextFile1.txt", Encoding.Default);
            foreach (var symbol in helloBanner)
            {
                Console.WriteLine($"{symbol}");
            }
            while (flag)
            {
                Console.WriteLine($"\nYou have an options:\n1) Add a new member in table;\n" +
                    $"2) Run Secret Santa choosing process;\n3) Find out to whom you're giving a gift;\n" +
                    $"4) View list of participants;\n5) Delete someone from table;\n6) Delete whole table;\n" +
                    $"7) Exit SS app.\n\nChoose number of option:");
                var choosenOption = int.Parse(Console.ReadLine());
                switch (choosenOption)
                {
                    case 1:
                        PersonCreate person = new PersonCreate();
                        person.CreatePerson();
                        break;
                    case 2:
                        ChooseGiftRecipient choose = new ChooseGiftRecipient();
                        choose.Choose();
                        break;
                    case 3:
                        ShowRecipient show = new ShowRecipient();
                        show.ShowMan();
                        break;
                    case 4:
                        ShowTable showTable = new ShowTable();
                        showTable.ShowTableOfPersons();
                        break;
                    case 5:
                        Delete deleteOneOption = new Delete();
                        deleteOneOption.DeletePerson();
                        break;
                    case 6:
                        Delete deleteAllOption = new Delete();
                        deleteAllOption.DeleteAll();
                        break;
                    case 7:
                        flag = false;
                        Console.WriteLine($"Good bye!!!");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }              
            }            
        }
    }
}
