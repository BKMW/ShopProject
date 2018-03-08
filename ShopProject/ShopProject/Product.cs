using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject
{
    public class Product
    {
        public String Image { get; set; }
        public String Name { get; set; }
        public String Status { get; set; }
        public String Price { get; set; }
        public String Category { get; set; }
        public bool IsVisible { get; set; }

      /*  public Product()
        {
            this.Image = Image;
            this.Name = Name;
            this.Status = Status;
            this.Price = Price;
            this.Category = Category;
            this.IsVisible = true;
        }*/
    }
}
