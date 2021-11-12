using System;
using System.Collections.Generic;

namespace WeaponShop.Models
{
    public class Character
    {
        private readonly IList<Item> Bag = new List<Item>();

        public Character(string name, CharacterType type,
            int health, int mana, int strength, int abilityPower,
            int agility, int startingMoney)
        {
            Name = name;
            CharacterType = type;
            Health = health;
            Mana = mana;
            Strength = strength;
            AbilityPower = abilityPower;
            Agility = agility;
            Money = startingMoney;
        }

        private string Name { get; }
        public CharacterType CharacterType { get; }
        private int Health { get; set; }
        private int Mana { get; set; }
        private int Strength { get; set; }
        private int AbilityPower { get; set; }
        private int Agility { get; set; }
        private int Money { get; set; }
        private void AddItem(Item item)
        {
            Health += item.HP;
            Mana += item.MP;
            Strength += item.Str;
            AbilityPower += item.AP;
            Agility += item.AG;
            Bag.Add(item);
            Console.WriteLine("You have acquired: " + item.Name + '.');
        }
        public void Stats()
        {
            Console.WriteLine(".........." + this.Name + "...........");
            Console.WriteLine("Type: " + this.CharacterType);
            Console.WriteLine("Health: " + this.Health);
            Console.WriteLine("Mana: " + this.Mana);
            Console.WriteLine("Strength: " + this.Strength);
            Console.WriteLine("Ability power: " + this.AbilityPower);
            Console.WriteLine("Agility: " + this.Agility);
            Console.WriteLine("Money: " + this.Money);
            Console.WriteLine("------------------------------------");
            DisplayItems();
        }
        private void DisplayItems()
        {
            foreach (var item in Bag)
            {
                Console.WriteLine(item.Name);
            }
        }

        public IList<Item> GetAvailableItemsForPurchase(Shop shop)
        {
            return shop.ShowItemsToBuy(this.CharacterType);
        }

        public void BuyItem(Item item)
        {
            if (item == null)
            {
                Console.WriteLine("Add valid item");
            }
            if (this.Money < item.Price)
            {
                Console.WriteLine("You can't affrod this.Go on another adventure traveler");
                return;
            }
            this.Money -= item.Price;
            AddItem(item);
        }
    }
}
