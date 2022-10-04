using aspnet_core_dotnet_core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace aspnet_core_dotnet_core.Models
{
    public class ProductModel
    {

        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "1",
                    Name = "Margherita",
                    Price = 125,
                    Photo = "https://www.dominos.co.in//files/items/Margherit.jpg"
                },
                new Product
                {
                    Id = "2",
                    Name = "Peppy Paneer",
                    Price = 300,
                    Photo = "https://www.dominos.co.in/files/items/Peppy_Paneer.jpg"
                },
                new Product
                {
                    Id = "3",
                    Name = "Tandoori Paneer",
                    Price = 350,
                    Photo = "https://www.dominos.co.in/files/items/IndianTandooriPaneer.jpg"
                },
                new Product
                {
                    Id = "4",
                    Name = "Pepper Barbeque",
                    Price = 400,
                    Photo = "https://www.dominos.co.in/files/items/Pepper_Barbeque_&_Onion.jpg"
                },
                new Product
                {
                    Id = "5",
                    Name = "Non Veg Supreme",
                    Price = 450,
                    Photo = "https://chefchoice.com.np/wp-content/uploads/2020/07/Non-Veg_Supreme.jpg"
                },
                new Product
                {
                    Id = "6",
                    Name = "Tandoori Paneer",
                    Price = 400,
                    Photo = "https://www.dominos.co.in/files/items/PrimeLoadedL.jpg"
                }
            };
        }

        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
