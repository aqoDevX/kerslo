using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            // NullReferenceException almamaq üçün kolleksiyanı inisializasiya edirik
            Products = new HashSet<Product>();
        }
    }
}
