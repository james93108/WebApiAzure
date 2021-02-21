using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAzure.Contracts;
using WebApiAzure.Models;

namespace WebApiAzure.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
