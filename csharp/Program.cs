﻿using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<IItem> Items = new List<IItem>{
                new RegularItem("+5 Dexterity Vest", 10,20),
                new AgedBrie("Aged Brie", 2,0),
                new RegularItem("Elixir of the Mongoose", 5,7),
                new Sulfuras("Sulfuras, Hand of Ragnaros", 0),
                new Sulfuras("Sulfuras, Hand of Ragnaros", -1),
                new Backstage("Backstage passes to a TAFKAL80ETC concert", 15,20),
                new Backstage("Backstage passes to a TAFKAL80ETC concert", 10,49),
                new Backstage("Backstage passes to a TAFKAL80ETC concert", 5,49),
				// this conjured item does not work properly yet
                new Conjured("Conjured Mana Cake", 3,6)
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
