using System.Collections.Generic;

namespace Sirano.Models
{
    public class ProductReviewViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}