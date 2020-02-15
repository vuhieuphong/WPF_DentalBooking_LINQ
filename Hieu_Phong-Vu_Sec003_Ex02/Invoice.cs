using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieu_Phong_Vu_Sec003_Ex02
{
    public class Invoice
    {
        public int partNumber { get; set; }
        public string partDesc { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        
        public Invoice(int partNumber,string partDesc,int quantity,decimal price)
        {
            this.partNumber = partNumber;
            this.partDesc = partDesc;
            this.quantity = quantity;
            this.price = price;
        }

        
    }
}
