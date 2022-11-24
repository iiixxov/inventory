using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    class InventoryGame
    {
        string command;
        Bag bag;
        public InventoryGame()
        {
            bag = new Bag(100);
            RunGame();
        }
        private void RunGame()
        {
            command = Console.ReadLine();
            while (command != "exit")
            {
                switch (command)
                {
                    case "add":
                        Console.WriteLine("What item name that you want to add?");
                        string name = Console.ReadLine();
                        Item item = new Item(name);
                        bag.AddItem(item);
                        break;
                    case "open":
                        bag.WriteItemsNameInBag();
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
