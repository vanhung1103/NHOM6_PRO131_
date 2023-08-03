using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResSupplier
    {
        bool AddSup(Supplier supplier);
        bool UpdateSup(Supplier supplier);
        bool DeleteSup(Guid id);
        List<Supplier> GetSups();
        Supplier GetSupById(Guid supId);
    }
}