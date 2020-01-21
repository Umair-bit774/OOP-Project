using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class billing
    {
        protected string totalbill;
        protected string item_no;
    public string Totalbill
    {           
        get { return totalbill;}
        set { value = totalbill;}
    }
    public string Item_no
    {
        get { return item_no; }
        set { value = item_no; }
    }
public billing(string totalbill,string item_no)
    {
        this.totalbill = totalbill;
        this.item_no = item_n0;
      }
    }
}
