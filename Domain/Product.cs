namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int Category { get; set; }


        public bool CanSell()
        {
            return Quantity > 0;
        }

        public void Sold()
        {
            if (CanSell())
                Quantity--;
        }

        public void Bought(int qtty)
        {
            Quantity += qtty;
        }
    }
}