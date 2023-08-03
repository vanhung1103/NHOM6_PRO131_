using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.NewFolder
{
    public interface IBillService
    {
        List<BillView> GetBill();
        string AddBill(BillView obj);
        string RemoveBill(Guid obj);
        string UpdateBill(BillView obj);
    }
}
