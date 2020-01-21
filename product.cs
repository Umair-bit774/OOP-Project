using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class product
    {
        protected string p_name;
        protected int item_code;
        protected string price;

        public int Item_code
        {
            get { return item_code; }
            set { value = item_code; }
        }
        public string P_name
        {
            get { return P_name; }
            set { value = P_name; }

        }
        public string Price
        {
            get { return price; }
            set { value = Price; }
        }
        public product(int item_code,string P_name,string price)
        {
            this.item_code = item_code;
            this.P_name = P_name;
            this.Price = price;
           }
                                                           /*Aggregation Between product and order*/

        public order order1;
        public void aggregation(order order2)
        {
            order1 = order2;

        }



        /*Aggregation Between product and Supplier*/

        public Supplier Supplier1;
        public void S_aggregation(Supplier Supplier2)
        {
            Supplier1 = Supplier2;

        }
     }
}
