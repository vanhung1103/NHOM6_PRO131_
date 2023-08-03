using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class SupplierServices : ISupplierServices
    {
        IResSupplier ressup;
        List<Supplier> supplierbus;
        public SupplierServices()
        {
            ressup = new ResSupplier();
            supplierbus = new List<Supplier>();
        }
        public string AddSupplier(Supplier supplier)
        {
            if (ressup.AddSup(supplier))
            {
                return "Them thanh cong";
            }
            return "Thu lai";
        }

        public string DeleteSupplier(Guid id)
        {
            if (ressup.DeleteSup(id))
            {
                return "Xoa thanh cong";
            }
            return "Thu lai";
        }

        public Supplier GetSupplierID(Guid id)
        {
            return ressup.GetSupById(id);
        }

        public List<Supplier> GetSuppliers()
        {
            return supplierbus = ressup.GetSups().ToList();
        }

        public string UpdateSupplier(Supplier supplier)
        {
            if (ressup.UpdateSup(supplier))
            {
                return "Sua thanh cong";
            }
            return "Thu lai";
        }
    }
}