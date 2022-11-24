using System;
using System.Collections.Generic;
using System.Text;

namespace inventory
{
    class Bag
    {
        private readonly int MaxCapacity;
        private Item[] items;
        private int fillAmount;


        public Bag(int capacity)
        {
            MaxCapacity = capacity;
            items = new Item[MaxCapacity];
        }

        public void AddItem(Item item)
        {
            if (fillAmount < MaxCapacity)
            {
                Console.WriteLine($"Item '{item.name}' added successfull");
                items[fillAmount] = item;
                fillAmount++;
            }
            else 
            {
                Console.WriteLine($"Item {item} don't fit");
            }

        }
        public void WriteItemsNameInBag()
        {
            int i = 1;

            Console.WriteLine("Items in Bag:");
            foreach (var item in items)
            {
                
                if (item != null)
                {
                    Console.WriteLine($"{i}. {item.name}");
                    i++;
                }
            }
            Console.WriteLine();
        }
        private Item GetItemByName(string name)
        {
            foreach (var item in items)
            {
                if (item.name == name)
                    return item;
            }
            return null;
        }
    }

}
