using System;
using System.Collections.Generic;
using System.Linq;

namespace WeaponShop.Models
{
    public class Shop
    {
        private readonly IList<Item> ShopWeapons = new List<Item>();

        public Shop(IList<Item> shopWeapons)
        {
            ShopWeapons = shopWeapons;
        }

        public IList<Item> ShowItemsToBuy(CharacterType characterType)
        {
            Console.WriteLine("Good evening traveler.");
            foreach (var item in ShopWeapons)
            {
                Console.WriteLine(item.Name + " HP:" + item.HP + " Str:" + item.Str + " AP:" + item.AP + " AG:" + item.AG);
            }
            return ShopWeapons.Where(i => i.VisibleFor == characterType).ToList();
        }
    }
}
