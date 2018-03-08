using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShopProject
{
	public partial class MainPage : ContentPage
	{

       
	    private List<Product> products = new List<Product>
	    {

	        new Product
	        {
	            Name = "BROWNIE HIP SUNGLASSES",
	            Status = "Almost New",
	            Price = "770.00 SAR",
	            Image = "Pic1.png",
	            Category = "Accessoreis",
	            IsVisible = true


            },
	        new Product
	        {
	            Name = "BROWNIE GLASSES HOLDER",
	            Status = "Acceptable",
	            Price = "2200 SAR",
	            Image = "Pic2.png",
	            Category = "Accessoreis",
	            IsVisible = true


            },

	        new Product
	        {
	            Name = "HANDBAG NATURAL LEATHER",
	            Status = "New",
	            Price = "770.00 SAR",
	            Image = "Pic3.png",
	            Category = "Bags",
	            IsVisible = true


            },
	        new Product
	        {
	            Name = "CONCORD HANDWATCH",
	            Status = "Almost New",
	            Price = "3000.00 SAR",
	            Image = "Pic4.png",
	            Category = "Accessoreis",
	            IsVisible = true


            },

	        new Product
	        {
	            Name = "EVENING SHOES HIGH HEAL",
	            Status = "Almost New",
	            Price = "2200 SAR",
	            Image = "Pic5.png",
	            Category = "Shoes",
	            IsVisible = true


            },

	        new Product
	        {
	            Name = "HANDBAG NATURAL LEATHER",
	            Status = "Almost New",
	            Price = "770.00 SAR",
	            Image = "Pic6.png",
	            Category = "Bags",
	            IsVisible = true

            },

	        new Product
	        {
	            Image ="a.jpg",
	            Name="Levis Clothes",
	            Status="Almost New",
	            Price="3000.00 SAR",
	            Category = "Bags",
	            IsVisible = true

	        }
        };

	 

        public MainPage()
		{
			InitializeComponent();

            
            var productsPair= new List<ProductPair>();

            for (int i = 0; i < products.Count; i++)
		    {
		        if (products.Count % 2 == 0)
		        {
		            productsPair.Add(new ProductPair(products[i],
		                products[i + 1]));
                }
		        else
		        {
		            if (i<products.Count-1)
		            {
		                productsPair.Add(new ProductPair(products[i],
		                    products[i + 1]));
                    }
		            else
		            {
		                productsPair.Add(new ProductPair(products[i], null));
                    }
		           
                }
                   

		        i++;
		    }

		    ProductslistView.ItemsSource = productsPair;


            /*  productsPair = new List<ProductPair>

                  {

              new ProductPair(
                          new Product
                          {
                              Name = "BROWNIE HIP SUNGLASSES",
                              Status = "Almost New",
                              Price = "770.00 SAR",
                              Image = "Pic1.png",
                              Category = "Accessoreis"
                          },
                          new Product
                          {
                              Name = "BROWNIE GLASSES HOLDER",
                              Status = "Acceptable",
                              Price = "2200 SAR",
                              Image = "Pic2.png",
                              Category = "Accessoreis"
                          }),
                      new ProductPair(
                          new Product
                          {
                              Name = "HANDBAG NATURAL LEATHER",
                              Status = "New",
                              Price = "770.00 SAR",
                              Image = "Pic3.png",
                              Category = "Bags"
                          },
                          new Product
                          {
                              Name = "CONCORD HANDWATCH",
                              Status = "Almost New",
                              Price = "3000.00 SAR",
                              Image = "Pic4.png",
                              Category = "Accessoreis"
                          }),
                      new ProductPair(
                          new Product
                          {
                              Name = "EVENING SHOES HIGH HEAL",
                              Status = "Almost New",
                              Price = "2200 SAR",
                              Image = "Pic5.png",
                              Category = "Shoes"
                          },
                          new Product
                          {
                              Name = "HANDBAG NATURAL LEATHER",
                              Status = "Almost New",
                              Price = "770.00 SAR",
                              Image = "Pic6.png",
                              Category = "Bags"
                          })

                  };*/



        }// end constructor

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (sender.Equals(ShoesLabel))
            {
                ShoesLabel.TextColor = Color.White;
                ShoesLabel.FontSize = 20;
                GetDataByCategory("Shoes");
                BagLabel.TextColor = Color.Gray;
                BagLabel.FontSize = 14;
                AccessoreisLabel.TextColor = Color.Gray;
                AccessoreisLabel.FontSize = 14;


            }
            else if (sender.Equals(BagLabel))
            {
                BagLabel.TextColor = Color.White;
                BagLabel.FontSize = 20;
                GetDataByCategory("Bags");
                ShoesLabel.TextColor = Color.Gray;
                ShoesLabel.FontSize = 14;
                AccessoreisLabel.TextColor = Color.Gray;
                AccessoreisLabel.FontSize = 14;
            }
            else if (sender.Equals(AccessoreisLabel))
            {
                AccessoreisLabel.TextColor = Color.White;
                AccessoreisLabel.FontSize = 20;
                GetDataByCategory("Accessoreis");
                ShoesLabel.TextColor = Color.Gray;
                ShoesLabel.FontSize = 14;
                BagLabel.TextColor = Color.Gray;
                BagLabel.FontSize = 14;
            }
        }


        void GetDataByCategory(string category)
        {
          
         
            List<Product> searchReasult = products.Where(product => product.Category.ToLower().Contains(category.ToLower())).ToList();

            var productsPair = new List<ProductPair>();

            for (int i = 0; i < searchReasult.Count; i++)
            {
                if (searchReasult.Count % 2 == 0)
                {
                    productsPair.Add(new ProductPair(searchReasult[i],
                        products[i + 1]));
                }
                else
                {
                    if (i < searchReasult.Count - 1)
                    {
                        productsPair.Add(new ProductPair(searchReasult[i],
                            searchReasult[i + 1]));
                    }
                    else
                    {
                        productsPair.Add(new ProductPair(searchReasult[i], null));
                    }

                }


                i++;
            }
            ProductslistView.ItemsSource = productsPair;
        }





        private void FrameTapGestureRecognizer_OnTapped(object sender, EventArgs e)

        {

            Frame senderFrame = (Frame)sender;

            Product Prod = new Product();

            Prod = senderFrame.BindingContext as Product;

            DisplayAlert("Frame Tapped ", "Product Name : " + Prod.Name + " Product Category : " + Prod.Category,
                "Ok");

        }


        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            
           var keyword = MainSearchBar.Text;

           List<Product> searchReasult = products.Where(product => product.Name.ToLower().Contains(keyword.ToLower())).ToList();
            var productsPair = new List<ProductPair>();

            for (int i = 0; i < searchReasult.Count; i++)
            {
                if (searchReasult.Count % 2 == 0)
                {
                    productsPair.Add(new ProductPair(searchReasult[i],
                        products[i + 1]));
                }
                else
                {
                    if (i < searchReasult.Count - 1)
                    {
                        productsPair.Add(new ProductPair(searchReasult[i],
                            searchReasult[i + 1]));
                    }
                    else
                    {
                        productsPair.Add(new ProductPair(searchReasult[i], null));
                    }

                }


                i++;
            }
            ProductslistView.ItemsSource = productsPair;

        }






        //////////////////////////////////////////////////////////////
        /* public void RegroupByCategry(object sender, EventArgs e)
         {
             var keyword = MainSearchBar.Text;
             IEnumerable<ProductPair> searchReasult = productsPairs.Where(product => product.Item1.Name.ToLower().Contains(keyword.ToLower()));

               IEnumerable<Product> searchReasult = products.Where(product => product.Name.ToLower().Contains(keyword.ToLower()));

                productsPairs = new List<ProductPair>
                {
                    new ProductPair(
                        products[0],products[1]

                   )

                };


             ProductslistView.ItemsSource = searchReasult;
         }
         public void Search(object sender, EventArgs e)
         {
             var keyword = MainSearchBar.Text;
            IEnumerable<ProductPair> searchReasult = productsPairs.Where(product => product.Item1.Name.ToLower().Contains(keyword.ToLower()));

             IEnumerable<Product> searchReasult = products.Where(product => product.Name.ToLower().Contains(keyword.ToLower()));

             productsPairs = new List<ProductPair>
             {
                 new ProductPair(
                     products[0],products[1]

                )

             };


         ProductslistView.ItemsSource = searchReasult;
         }*/
    }
}
