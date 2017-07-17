using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExport
{
    class Order
    {
        Dictionary<string, string> Properties { get; }
        List<Product> Products { get; }

        public Order(Dictionary<string, string> properties)
        {
            Properties = properties.ToDictionary(x => x.Key, x => x.Value);
        }

        public Order(Dictionary<string, string> properties, List<Product> products)
        {
            Properties = properties.ToDictionary(x => x.Key, x => x.Value);
            Products = products.ToList();
        }
    }
}
