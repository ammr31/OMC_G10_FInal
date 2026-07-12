using System.Collections.Generic;
using System.Linq;

namespace OMC_G10_Final
{
    public static class RecentlyViewed
    {
        public static List<Product> Items = new List<Product>();

        public static void Track(Product product)
        {
            var existing = Items.FirstOrDefault(p =>
                p.Id == product.Id && p.Category == product.Category);

            if (existing != null)
                Items.Remove(existing);

            Items.Insert(0, product);

            const int maxItems = 20;
            if (Items.Count > maxItems)
                Items.RemoveAt(Items.Count - 1);
        }
    }
}