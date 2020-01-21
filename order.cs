using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class order
    {
        protected string order_no;
        public string Order_no
        {
            get { return order_no; }
            set { value = order_no; }
        }
        public order (string order_no)
        {
            this.order_no = order_no;
        }
    }
}
