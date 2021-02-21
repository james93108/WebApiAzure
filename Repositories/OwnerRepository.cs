using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAzure.Contracts;
using WebApiAzure.Models;

namespace WebApiAzure.Repositories
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
