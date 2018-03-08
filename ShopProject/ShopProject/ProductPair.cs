using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject
{
    public class ProductPair :Tuple<Product,Product>
    {
        public ProductPair(Product item1, Product item2) : base(item1, item2?? CreateEmptyModel()) {  }
        

            private static Product CreateEmptyModel()
            {
                return new Product { IsVisible = false };
            }
        }
    }

