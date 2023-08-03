using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitories
{
    public interface IBillResponsitory
    {
        bool AddBill(Bill x);

        bool RemoveBill(Guid x);

        bool UpdateBill(Bill x);

        List<Bill> GetAllBill();
    }
}
