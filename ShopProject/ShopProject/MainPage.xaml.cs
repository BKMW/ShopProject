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
	                Image="a.jpg",
	                Name="Gucci Hand Bag Light Brown",
	                Status="Almost New",
	                Price="3000.00 SAR",
	                Categry = "Shoes",
	                IsVisible = true

	            },
	            new Product
	            {
	                Image="a.jpg",
	                Name="Boss Hand",
	                Status="Almost New",
	                Price="3000.00 SAR",
	                Categry = "Shoes",
	                IsVisible = true

	            },
	        
	            new Product
	            {
	                Image ="a.jpg",
	                Name="Clarks Shoes",
	                Status="Almost New",
	                Price="3000.00 SAR",
	                Categry = "Shoes",
	                IsVisible = true

	            },
	            new Product
	            {
	                Image="a.jpg",
	                Name="Adidas Shoes",
	                Status="Almost New",
	                Price="3000.00 SAR",
	                Categry = "Shoes",
	                IsVisible = true

	            },
	       
	            new Product
	            {
	                Image ="a.jpg",
	                Name="Levis Clothes",
	                Status="Almost New",
	                Price="3000.00 SAR",
	                Categry = "Shoes",
	                IsVisible = true

	            }
	    };


        private List<ProductPair> productsPairs;
	    
        public MainPage()
		{
			InitializeComponent();

		    var category = new List<string>()
		        { "Shoes",
		          "Bags",
		          "Accessories",
                  "Travel"
		        };
            
		    productsPairs = new List<ProductPair>
		    {
		        new ProductPair(
		           /* new Product
		            {
		                Image="a.jpg",
		                Name="Gucci Hand Bag Light Brown",
		                Status="Almost New",
		                Price="3000.00 SAR",
		                Categry = "Shoes",
		                IsVisible = true

		            }*/products[0],
		           /* new Product
		            {
		                Image="a.jpg",
		                Name="Boss Hand",
		                Status="Almost New",
		                Price="3000.00 SAR",
		                Categry = "Shoes",
		                IsVisible = true

		            }*/products[1]),
		        new ProductPair(
		            /*new Product
		            {
		                Image ="a.jpg",
		                Name="Clarks Shoes",
		                Status="Almost New",
		                Price="3000.00 SAR",
		                Categry = "Shoes",
		                IsVisible = true

		            },
		            new Product
		            {
		                Image="a.jpg",
		                Name="Adidas Shoes",
		                Status="Almost New",
		                Price="3000.00 SAR",
		                Categry = "Shoes",
		                IsVisible = true

		            }*/products[2],products[3]),
		        new ProductPair(
		          /*  new Product
		            {
		                Image ="a.jpg",
		                Name="Levis Clothes",
		                Status="Almost New",
		                Price="3000.00 SAR",
		                Categry = "Shoes",
		                IsVisible = true

		            }*/products[4],null)
		    };

            ProductslistView.ItemsSource = productsPairs;

        }
	    public void RegroupByCategry(object sender, EventArgs e)
	    {
	        var keyword = MainSearchBar.Text;
	        IEnumerable<ProductPair> searchReasult = productsPairs.Where(product => product.Item1.Name.ToLower().Contains(keyword.ToLower()));

	        /*   IEnumerable<Product> searchReasult = products.Where(product => product.Name.ToLower().Contains(keyword.ToLower()));

               productsPairs = new List<ProductPair>
               {
                   new ProductPair(
                       products[0],products[1]

                  )

               };*/


	        ProductslistView.ItemsSource = searchReasult;
	    }
        public void Search(object sender, EventArgs e)
	    {
	        var keyword = MainSearchBar.Text;
	       IEnumerable<ProductPair> searchReasult = productsPairs.Where(product => product.Item1.Name.ToLower().Contains(keyword.ToLower()));

	     /*   IEnumerable<Product> searchReasult = products.Where(product => product.Name.ToLower().Contains(keyword.ToLower()));

	        productsPairs = new List<ProductPair>
	        {
	            new ProductPair(
	                products[0],products[1]

               )

	        };*/


        ProductslistView.ItemsSource = searchReasult;
	    }
    }
}
