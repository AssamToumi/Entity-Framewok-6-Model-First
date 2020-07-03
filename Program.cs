using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AcountingSystemContainer())
            {
                var invHeader = db.InvoiceHeaders.Create();
                var invDetail = db.InvoiceDetails.Create();

                invHeader.Total = 150m;
                
                invDetail.ItemDescription = "Some Item";
                invDetail.Price = 75m;
                invDetail.Quantity = 2;

                invHeader.InvoiceDetails.Add(invDetail);
                db.InvoiceHeaders.Add(invHeader);
                db.SaveChanges();
        }
    }

    }
}