using Secret_Santa.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Secret_Santa.Actions
{
    public class Mixed : IMixed
    {
        public void Mixing()
        {
            for (int i = 0; i < 5; i++)
            {
                var cubeOnePicture = File.ReadAllLines("Cube_1.txt", Encoding.Default);
                foreach (var symbol in cubeOnePicture)
                {
                    Console.WriteLine($"{symbol}");
                }
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                var cubeTwoPicture = File.ReadAllLines("Cube_2.txt", Encoding.Default);
                foreach (var symbol in cubeTwoPicture)
                {
                    Console.WriteLine($"{symbol}");
                }
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                var cubeThreePicture = File.ReadAllLines("Cube_3.txt", Encoding.Default);
                foreach (var symbol in cubeThreePicture)
                {
                    Console.WriteLine($"{symbol}");
                }
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                var cubeFourthPicture = File.ReadAllLines("Cube_4.txt", Encoding.Default);
                foreach (var symbol in cubeFourthPicture)
                {
                    Console.WriteLine($"{symbol}");
                }
                System.Threading.Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}
