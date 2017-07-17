using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExport
{
    class Product
    {
        Dictionary<string, string> Properties { get; }

        public Product(Dictionary<string, string> properties)
        {
            Properties = properties.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
