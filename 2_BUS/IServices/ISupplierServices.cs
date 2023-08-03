using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISupplierServices
    {
        string AddSupplier(Supplier supplier);
        string DeleteSupplier(Guid id);
        string UpdateSupplier(Supplier supplier);
        List<Supplier> GetSuppliers();
        Supplier GetSupplierID(Guid id);
    }
}