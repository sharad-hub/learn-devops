using MongoDB.Driver;
using Shopping.API.Model;

namespace Shopping.API.Data
{

    public class ProductContext
    {

        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);

            SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
        private static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool productExists = productCollection.Find(p => true).Any();
            if (!productExists)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }

        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product> {
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
}