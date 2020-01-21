using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer:person
    {
        protected string email;
        
        
        public string Email
        {
            get { return email; }
            set { value = email; }
        }
        public Customer(string email, string name, int id, string address, int phoneno):base(name,address,phoneno)
        {
            this.email = email;
        }
                                                                /*Aggregation Between Feedback and Customer*/

        public Feedback Feedback1;
        public void F_aggregation(Feedback Feedback2)
        {
            Feedback1 = Feedback2;
        }

                                                                /*Composition Between Customer and billing*/
        public void show1()
        {
            billingb1 = new billing();
        }


                                                                /*Composition Between Customer and Order*/
        public void show2()
        {
         OrderO = new Order();
        }
    

    }
}
