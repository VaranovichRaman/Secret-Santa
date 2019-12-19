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


                    //var table = context.Persons.OrderBy(x => Guid.NewGuid()).ToList();
                    //    Person temp = null;
                    //    foreach (var item in table)
                    //    {
                    //        if (temp != null)
                    //        {
                    //            context.Persons.Find(temp).Name = context.Persons.Find(item).Name;
                    //            context.SaveChanges();
                    //        }
                    //        else
                    //        {
                    //            context.Persons.Last().GiftedFriend.Name = context.Persons.First().Name;
                    //            context.SaveChanges();
                    //        }
                    //        temp = item;
                    //    }
                    //Console.WriteLine($"Mixed list");
                    ////foreach (var item in context.Persons.OrderBy(r => Guid.NewGuid()).Take(context.Persons.Count()))
                    ////{
                    ////    Person temp = null;
                    ////   // if (temp != null)
                    ////    //{
                    ////        temp.GiftedFriend.Name = item.Name;
                    ////    //}
                    ////    //else
                    ////    //{
                    ////    //    context.Persons.Find(context.Persons.Count()).GiftedFriend.Name = item.Name;
                    ////    //}
                    ////    temp = item;
                    ////}

                    //Console.ReadLine();
                    //Person temp = null;
                    //for (int i = 0; i < context.Persons.Count(); i++)
                    //{

                    //    if (temp != null)
                    //    {
                    //        temp.GiftedFriend.Name = context.Persons.Find(i).Name;
                    //        context.SaveChanges();
                    //    }
                    //    else
                    //    {
                    //        context.Persons.Find(context.Persons.Last()).GiftedFriend.Name =
                    //            context.Persons.Find(context.Persons.First()).Name;
                    //        context.SaveChanges();
                    //    }
                    //    temp.Name = context.Persons.Find(i).Name;

                    //}
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
    

