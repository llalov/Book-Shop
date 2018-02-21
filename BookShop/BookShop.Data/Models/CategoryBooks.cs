namespace BookShop.Data.Models
{
    public class CategoryBooks
    {
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public Book Book { get; set; }

        public int BookId { get; set; }
    }
}
