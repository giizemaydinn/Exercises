namespace Challenge09
{
    public class PizzaOrder
    {

        public Pizza Pizza { get; set; }
        public int Count { get; set; }

        public PizzaOrder(int count, Pizza pizza)
        {
            Count = count;
            Pizza = pizza;
        }
    }
}