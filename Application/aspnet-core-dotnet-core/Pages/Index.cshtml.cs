using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_core_dotnet_core.Entities;
using aspnet_core_dotnet_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnet_core_dotnet_core.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;
        public void OnGet()
        {

            ProductModel productModel = new ProductModel();
            Products = productModel.findAll();

        }
        public string DoTest()
        {
            return "Index";
        }
    }
}