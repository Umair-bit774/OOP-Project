using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class stock
    {
        protected int item_code;
        protected string quantity;
        protected int item_cost;

        public int Item_code
          {
            get { return item_code;}
            set { value = item_code; }
        }
        public string Quantity
        {
            get { return quantity; }
            set { value = quantity; }
        }
        public int Item_cost
        {
            get { return item_cost; }
            set { value = item_cost; }
        }
        public stock(int item_code, string quantity,int item_cost)
        {
            this.item_code = Item_code;
            this.quantity = quantity;
            this.item_cost = item_cost;
        }

    }
}
