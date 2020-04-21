using Kest.Domain.UserAggregate;
using Kest.Infra.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kest.Infra.Data.Repositories
{
    class UserRepository : Repository<User, Guid, DomainContext>
    {
        public UserRepository(DomainContext context) : base(context)
        {
        }
    }
}
