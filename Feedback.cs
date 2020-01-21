using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Feedback:Person
    {
        protected string subject;
        protected string inquiry;
          public string Subject
        {
            get { return subject; }
            set { value = subject; }
        }
                  public string Inquiry
        {
            get { return inquiry; }
            set { value = inquiry; }
        }
        public Feedback (string subject,string inquiry,string name,int id,string address,string phoneno):base(name,id,address,phoneno)
        {
            this.subject = subject;
            this.inquiry = inquiry;
        }
    }
}
