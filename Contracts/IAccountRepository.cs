using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAzure.Models;

namespace WebApiAzure.Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
    }
}
