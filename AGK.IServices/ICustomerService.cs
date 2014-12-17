using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGK.Models;

namespace AGK.IServices
{
    public interface ICustomerService
    {
        bool Add(CustomerVm cus);
        bool Update(CustomerVm cus);
        CustomerVm FindById(Guid id);
        ICollection<CustomerVm> FindAll();
        
    }
}
