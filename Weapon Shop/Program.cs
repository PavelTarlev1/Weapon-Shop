
using System.Collections.Generic;
using WeaponShop.Models;
namespace WeaponShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("Pesho", CharacterType.Warrior, 10, 10, 10, 10, 10, 17);
            Item rapier = new Item("Rapier ", 3, CharacterType.Rogue, 5, 7, 10, 0, 7);
            Item sword = new Item("Sword", 5, CharacterType.Rogue, 10, 0, 14, 0, 3);
            Item greatsword = new Item("Greatsword", 15, CharacterType.Warrior, 15, 0, 20, 0, -3);
            Shop shop = new Shop(new List<Item>() { sword, greatsword, rapier });
            IList<Item> itemsForSale = character.GetAvailableItemsForPurchase(shop);
            character.BuyItem(itemsForSale[0]);
            character.Stats();
        }
    }
}
