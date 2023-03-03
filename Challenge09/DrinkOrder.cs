namespace Challenge09
{
    public class DrinkOrder
    {
        public Drink Drink { get; set; }
        public int Count { get; set; }

        public DrinkOrder(int count, Drink drink)
        {
            Count = count;
            Drink = drink;
        }
    }
}