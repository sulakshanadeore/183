using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
  public  class OrdersData
    {

        //       Orderno int,
        //Productid int,
        //productname nvarchar(40),
        //unitprice int,
        //qty int,
        //dis int


        public int Orderno { get; set; }
        public int Prodid { get; set; }
        public string ProdName { get; set; }
        public int unitPrice { get; set; }
        public int qty { get; set; }
        public int dis { get; set; }
    }
}
