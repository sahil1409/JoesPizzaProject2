using System;
using aspnet_core_dotnet_core.Pages;

public class HomeController
{

    public ActionResult AddToCart(int productId)
    {
        if (Session["cart"] == null)
        {
            List<Item> cart = new List<Item>();
            var product = context.laptops.Find(productId);
            cart.Add(new Item()
            {
                Product = product,
                Quantity = 1
            });
            Session["cart"] = cart;
        }

        else
        {
            List<Item> cart = (List<Item>)Session["cart"];
            var count = cart.Count();
            var product = context.laptops.Find(productId);
            for (int i = 0; i < count; i++)
            {
                if (cart[i].Product.laptop_id == productId)
                {
                    int prevQty = cart[i].Quantity;
                    cart.Remove(cart[i]);
                    cart.Add(new Item()
                    {
                        Product = product,
                        Quantity = prevQty + 1
                    });
                    break;
                }
                else
                {
                    var prd = cart.Where(x => x.Product.laptop_id == productId).SingleOrDefault();
                    if (prd == null)
                    {
                        cart.Add(new Item()
                        {
                            Product = product,
                            Quantity = 1
                        });
                    }
                }
            }
            Session["cart"] = cart;
        }
        return Redirect("Index");
    }
    public ActionResult RemoveFromCart(int productId)
    {
        List<Item> cart = (List<Item>)Session["cart"];
        foreach (var item in cart)
        {
            if (item.Product.laptop_id == productId)
            {
                cart.Remove(item);
                break;
            }
        }
        Session["cart"] = cart;
        return Redirect("Index");
    }
}
