using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        protected string name;
        protected int id;
        protected string address;
        protected int phoneno;
        public string Name
        {
            get { return name;}
            set { value = name; }
        }

        public int Id
        {
            get { return id; }
            set { value = id; }
        }
        public string Address
        {
            get { return address; }
            set { value = address; }
        }

        public int Phoneno
        {
            get { return phoneno; }
            set { value = phoneno; }
        }
        public Person(string name,int id,string address,int phoneno)
        {
            this.name = name;
            this.id = id;
            this.address = address;
            this.phoneno = phoneno;
        }

    }
}
