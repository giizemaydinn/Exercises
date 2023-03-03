using System.Data;

namespace Challenge09
{
    public partial class Form1 : Form
    {
        public static List<Order> _orders = new List<Order>();
        private List<Pizza> _pizzaPrices = new List<Pizza>();
        private List<Drink> _drinkPrices = new List<Drink>();
        private List<Customer> _customerList = new List<Customer>();
        private List<Extra> _extraList = new List<Extra>();
        public Form1()
        {
            InitializeComponent();
            InitializePriceList();

            //FillCustomerNames();
            //FillCustomerPhones();
            //FillCustomerAddresses();
            //FillPizza();
            //FillDrink();
            //FillPrice();
        }

        private void AddOrder()
        {
            _customerList.Add(new Customer(txtName.Text, txtTel.Text, txtAddress.Text));

            Pizza pizza = new Pizza();
            foreach (var item in _pizzaPrices)
            {
                if (item.Id == (int)cmbPizzaSize.SelectedValue)
                {
                    pizza = item;
                }
            }
            PizzaOrder pOrder = new PizzaOrder(Convert.ToInt32(nuPizzaCount.Value), pizza);

            Drink drink = new Drink();
            foreach (var item in _drinkPrices)
            {
                if (item.Id == (int)cmbDrink.SelectedValue)
                {
                    drink = item;
                }
            }
            DrinkOrder dOrder = new DrinkOrder(Convert.ToInt32(nuDrinkCount.Value), drink);


            _orders.Add(new Order(_customerList.Last().Id, pOrder, dOrder));

            foreach (Extra itemChecked in clbExtra.CheckedItems)
            {
                _orders.Last().ExtrasId.Add(itemChecked.Id);
            }

            FillCustomerNames();
            FillCustomerPhones();
            FillCustomerAddresses();
            FillPizza();
            FillDrink();
            FillPrice();
            FillExtras();

            //clbExtra.Items.Add("Sucuk");
        }
        private void FillExtras()
        {
            var q1 = from order in _orders
                     select new
                     {
                         order.Id,
                         Name = string.Join("-", from extraOrder in order.ExtrasId
                                                 join extra in _extraList
                                                      on extraOrder equals extra.Id
                                                 select new
                                                 {
                                                     extra.Name
                                                 }.Name)
                     };



            lstbExtra.DataSource = q1.ToList();
            lstbExtra.ValueMember = "Id";
            lstbExtra.DisplayMember = "Name";

        }
        private void FillCustomerNames()
        {
            //if (lstbName.Items.Count > 0)
            //{
            //    lstbName.Items.Clear();
            //    //lstbName.Refresh();
            //}
            //List<string> names = new List<string>();
            //foreach(var order in _orders) 
            //{ 
            //    foreach(var customer in _customerList)
            //    {
            //        if(order.Id == customer.Id)
            //        {
            //            names.Add(customer.Name);
            //            //lstbName.Items.Insert(customer.Id, customer.Name);

            //        }
            //    }
            //}
            var q = from order in _orders
                    join customer in _customerList
                        on order.CustomerId equals customer.Id
                    select new
                    {
                        order.Id,
                        customer.Name
                    };
            lstbName.DataSource = q.ToList();
            lstbName.ValueMember = "Id";
            lstbName.DisplayMember = "Name";
        }

        private void FillPrice()
        {
            var q = from order in _orders
                    select new
                    {
                        order.Id,
                        priceFood = order.PizzaOrder.Pizza.Price * order.PizzaOrder.Count +
                        order.DrinkOrder.Drink.Price * order.DrinkOrder.Count,
                        PriceExtra = from extraOrder in order.ExtrasId
                                     join extra in _extraList
                                          on extraOrder equals extra.Id
                                     select new
                                     {
                                         extra.Price
                                     }.Price
                                     //price = priceFood + priceExtra

                    };
            lstbPrice.DataSource = q.ToList();
            lstbPrice.ValueMember = "Id";
            lstbPrice.DisplayMember = "Price";
        }
        private void FillPizza()
        {

            var q = from order in _orders
                    select new
                    {
                        order.Id,
                        order.PizzaOrder.Pizza.Name,
                        order.PizzaOrder.Pizza.Price,
                        order.PizzaOrder.Count,
                        Result = order.PizzaOrder.Count > 0 ? order.PizzaOrder.Pizza.Name.ToString() + " " + order.PizzaOrder.Count.ToString() : "-"
                    };

            lstbPizza.DataSource = q.ToList();
            lstbPizza.ValueMember = "Id";
            lstbPizza.DisplayMember = "Result";
        }

        private void FillDrink()
        {

            var q = from order in _orders
                    select new
                    {
                        order.Id,
                        order.DrinkOrder.Drink.Name,
                        order.DrinkOrder.Drink.Price,
                        order.DrinkOrder.Count,
                        Result = order.DrinkOrder.Count > 0 ? order.DrinkOrder.Drink.Name.ToString() + " " + order.DrinkOrder.Count.ToString() : "-"
                    };

            lstbDrink.DataSource = q.ToList();
            lstbDrink.ValueMember = "Id";
            lstbDrink.DisplayMember = "Result";
        }
        private void FillCustomerPhones()
        {
            var q = from order in _orders
                    join customer in _customerList
                        on order.CustomerId equals customer.Id
                    select new
                    {
                        order.Id,
                        customer.PhoneNumber
                    };
            lstbPhone.DataSource = q.ToList();
            lstbPhone.ValueMember = "Id";
            lstbPhone.DisplayMember = "PhoneNumber";
        }

        private void FillCustomerAddresses()
        {
            var q = from order in _orders
                    join customer in _customerList
                        on order.CustomerId equals customer.Id
                    select new
                    {
                        order.Id,
                        customer.Address
                    };
            lstbAddress.DataSource = q.ToList();
            lstbAddress.ValueMember = "Id";
            lstbAddress.DisplayMember = "Address";
        }

        private void InitializePriceList()
        {
            _pizzaPrices.Add(new Pizza("Küçük", 50));
            _pizzaPrices.Add(new Pizza("Orta", 70));
            _pizzaPrices.Add(new Pizza("Büyük", 90));

            _drinkPrices.Add(new Drink("Fanta", 15));
            _drinkPrices.Add(new Drink("Kola", 17));
            _drinkPrices.Add(new Drink("Gazoz", 14));

            _extraList.Add(new Extra("Sucuk", 10));
            _extraList.Add(new Extra("Kasar", 5));
            _extraList.Add(new Extra("Mantar", 5));
            _extraList.Add(new Extra("Misir", 5));
            _extraList.Add(new Extra("Salam", 5));
            _extraList.Add(new Extra("Sosis", 5));

            cmbPizzaSize.DataSource = _pizzaPrices;
            cmbPizzaSize.ValueMember = "Id";
            cmbPizzaSize.DisplayMember = "Name";

            cmbDrink.DataSource = _drinkPrices;
            cmbDrink.ValueMember = "Id";
            cmbDrink.DisplayMember = "Name";

            ((ListBox)clbExtra).DataSource = _extraList;
            ((ListBox)clbExtra).DisplayMember = "Name";
            ((ListBox)clbExtra).ValueMember = "Id";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
            //FillPizza();

        }

        private void lstbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(lstbName.SelectedValue.ToString());
        }

        private void clbExtra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}