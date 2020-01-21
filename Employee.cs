using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
                                               /*inhertance between person and employee*/
{
    class Employee:Person
    {
        protected string designation;
        public string Designation
        {
            get { return designation; }
            set { value = designation; }
        }
        public Employee(string designation,string name,int id,string address,int phoneno): base(name,id,address,phoneno)
        {
            this.designation=designation;
        }



                                                  /*Aggregation Between Employee and order*/

        public order order1;
        public void o_aggregation(order order2)
        {
            order1 = order2;
        }

                                                  /*Composition Between Employee and billing*/
    public void show()
        {
            billingb = new billing();
        }
    
    
    
    
    }
}