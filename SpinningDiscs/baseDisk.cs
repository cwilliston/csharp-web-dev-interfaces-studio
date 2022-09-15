using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class baseDisk : IOpticalDisc
    {
        public string DiskType { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Dictionary <string, int> Contents { get; set; }
        
        public baseDisk()
        {
            DiskType = "Disc";
            Capacity = 0;
        }

        public baseDisk (string name, Dictionary<string, int> contents)
        {
            Name = name;
            Contents = contents;
        }

        //will implement spin() from IOpticalDisc;
        //
        public void ReadInfo()
        {
            Console.WriteLine($"This disk is a {DiskType}.");
            Console.WriteLine($"This disk is named {Name}.");
            Console.WriteLine($"This disk has a byte capacity of {Capacity}.");
            Console.WriteLine("Contents:");
            foreach (var item in Contents)
            {
                Console.WriteLine($"{item.Key}: Storage space : {item.Value}");
            }
        }
        public void WriteInfo(string itemName, int bytes)
        {
            Contents.Add(itemName, bytes);
        }

        

        
        public void SpinDisk()
        {
            Console.WriteLine("Would you like to read, or write? ");
            string choice = Console.ReadLine().ToLower();
            while (choice != "read" && choice != "write")
            {
                Console.WriteLine("Invalid choice, read or write? ");
                choice = Console.ReadLine();
            }
            if (choice == "read")
            {
                ReadInfo();
            } 
            else
            {
                Console.Write("Name the file: ");
                string inputName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("How many bytes does it have? ");

                int inputBytes = int.Parse(Console.ReadLine());
                WriteInfo(inputName, inputBytes);
            }
        }
        
        
    }
}
