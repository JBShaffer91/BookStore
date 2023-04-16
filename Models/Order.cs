using System.Collections.Generic;

namespace BookStore.Models
{
    public class Order
    {
        public Dictionary<Book, int> Books { get; set; }

        public Order()
        {
            Books = new Dictionary<Book, int>();
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var bookEntry in Books)
            {
                totalPrice += bookEntry.Key.Price * bookEntry.Value;
            }

            return totalPrice;
        }
    }
}
