using productAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productAPI.service
{
    public class OfferService
    {
        public OfferService()
        {
            this.createProducts();
        }

        private List<Product> Inventory = new List<Product>();

        private List<Offer> offers = new List<Offer>();

        private void createProducts()
        {
            this.Inventory.Add(new Product("P1",1000, "P1 desc"));
            this.Inventory.Add(new Product("P2", 200, "P2 desc"));
            this.Inventory.Add(new Product("P3", 400, "P3 desc"));
            this.Inventory.Add(new Product("P4", 700, "P4 desc"));
            this.Inventory.Add(new Product("P5", 600, "P5 desc"));
            this.Inventory.Add(new Product("P6", 800, "P6 desc"));
        }

        public List<Product> GetAllProducts()
        {
            return this.Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            Random rnd = new Random();
            for (int iCount=0;iCount<4;iCount++)
            {
                List<Product> prods = new List<Product>();
                for(int jCount=0;jCount<3;jCount++)
                {
                    prods.Add(new Product("product" + Guid.NewGuid().ToString(), rnd.Next(1000), Guid.NewGuid().ToString() + " desc"));
                }
                offers.Add(new Offer("ComboPackage" + iCount.ToString(),prods)) ;
            }

            return offers;
        }
    }
}
