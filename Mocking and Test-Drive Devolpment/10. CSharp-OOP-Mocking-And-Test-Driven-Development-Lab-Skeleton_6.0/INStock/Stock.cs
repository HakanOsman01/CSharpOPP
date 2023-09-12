using INStock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INStock
{
    public class Stock : IProductStock
    {
        private List<IProduct> products;
        public Stock(List<IProduct>products)
        {
            this.products = products;
        }
        public IProduct this[int index] 
        { 
            get
            {
                if (!IsOutsideOfRange(index))
                {
                    throw new InvalidOperationException("The product index is outside in the List");

                }
                return products[index];

            }
            set
            {
                if (!IsOutsideOfRange(index))
                {
                    throw new InvalidOperationException("The product index is outside in the List");
                }
                products[index] = value;
            }
        }

        public int Count => this.products.Count;

        public void Add(IProduct product)
        {
           this.products.Add(product);
        }

        public bool Contains(IProduct product)
        {
            return this.products.Contains(product);
        }

        public IProduct Find(int index)
        {
            if (!IsOutsideOfRange(index))
            {
                throw new InvalidOperationException("The product index is outside in the List");
            }
            return products[index];
        }

        public IEnumerable<IProduct> FindAllByPrice(double price) =>
         this.products.FindAll(p => p.Price == (decimal)price);
       

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
            => this.products.FindAll(p => p.Quantity == quantity);


        public IEnumerable<IProduct> FindAllInrangeAll(double lo, double hi)
        {
            IEnumerable<IProduct> findRangeProducts = this.products.GetRange((int)lo,
                (int)hi - (int)lo);
            return findRangeProducts;
        }

        public IProduct FindByLabel(string label)
         =>this.products.FirstOrDefault(p=>p.Label==label); 
       

        public IProduct FindMostExpensiveProduct()
        {
            decimal mostExpensive = decimal.MinValue;
            IProduct mostExpensiveProduct = null;
            foreach (IProduct product in products)
            {
                if (product.Price > mostExpensive)
                {
                    mostExpensive=product.Price;
                    mostExpensiveProduct=product;

                }
            }
            return mostExpensiveProduct;
        }
       

        public IEnumerator<IProduct> GetEnumerator()
        {
            for (int i = 0; i < products.Count; i++)
            {
                yield return products[i];
            }
        }

        public bool Remove(IProduct product)
        {
            return this.products.Remove(product);
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        
        private bool IsOutsideOfRange(int index)
        {
            return index<0 || index>= this.products.Count;
        }
    }
}
