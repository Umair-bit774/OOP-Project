using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Supplier:Person
    {

        protected string company;
        protected string products;
        public string Company
        {
            get { return company; }
            set { value = company; }
        }
        public string Products
        {
            get { return products; }
            set { value = products; }
        }
        public Supplier(string company,string products,string name,int id,string address,int phoneno):base(name, id,address,phoneno)
        {
            this.company = company;
            this.products = products;
  }


        //Aggregation Between Stock and Supplier//

        public stock stock1;
        public void aggregation(stock stock2)
        {
            stock1 = stock2;

        }
    }
}
