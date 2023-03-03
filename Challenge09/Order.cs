namespace Challenge09
{
    public class Order
    {
        private static int ID = 0;
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public PizzaOrder PizzaOrder { get; set; }
        public DrinkOrder DrinkOrder { get; set; }
        public List<int> ExtrasId = new List<int>();
        public Order(int customerId, PizzaOrder pizzaOrder, DrinkOrder drinkOrder)
        {
            Id = ID++;
            CustomerId = customerId;
            PizzaOrder = pizzaOrder;
            DrinkOrder = drinkOrder;
        }
    }
}
