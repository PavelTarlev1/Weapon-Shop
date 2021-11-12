namespace WeaponShop.Models
{
    public class Item
    {
        public Item(string name,int price,CharacterType visibleFor,int hp,int mp, int str, int ap, int ag)
        {
            Name = name;
            Price = price;
            VisibleFor = visibleFor;
            HP = hp;
            MP = mp;
            Str = str;
            AP = ap;
            AG = ag; 
            Name = name;
        }

        public CharacterType VisibleFor { get; }
        public int HP { get; }
        public int MP { get; }
        public int Str { get; }
        public int AP { get; }
        public int AG { get; }
        public string Name { get; }
        public int Price { get; }
    }
}
