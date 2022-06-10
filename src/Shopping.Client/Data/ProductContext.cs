using Shopping.Client.Models;

namespace Shopping.Client.Data
{

    public static class ProductContext
    {

        public static readonly List<Product> Products = new List<Product> {
      new Product {
          Category= "Phone",
          Description="This is phone",
          ImageFile = "product-1.jpg",
           Name ="I PHOne x",
           Price=950.00M

      },
       new Product {
          Category= "Phone",
          Description="This is samsung phone",
          ImageFile = "product-2.jpg",
           Name ="Samsung Note",
           Price=800.00M

      }


    };
    }

}