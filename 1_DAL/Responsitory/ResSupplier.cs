using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Responsitory
{
    public class ResSupplier : IResSupplier
    {
        ShopClothesContext contextsup;
        List<Supplier> suppliers;
        public ResSupplier()
        {
            contextsup = new ShopClothesContext();
            suppliers = new List<Supplier>();
        }
        public bool AddSup(Supplier supplier)
        {
            contextsup.Suppliers.Add(supplier);
            contextsup.SaveChanges();
            return true;
        }

        public bool DeleteSup(Guid id)
        {
            var idxoa = contextsup.Suppliers.Find(id);
            contextsup.Suppliers.Remove(idxoa);
            contextsup.SaveChanges();
            return true;
        }

        public Supplier GetSupById(Guid supId)
        {
            return contextsup.Suppliers.Find(supId);
        }

        public List<Supplier> GetSups()
        {
            return suppliers = contextsup.Suppliers.ToList();
        }

        public bool UpdateSup(Supplier supplier)
        {
            contextsup.Suppliers.Update(supplier);
            contextsup.SaveChanges();
            return true;
        }
    }
}