using Kest.Domain.OrderAggregate;
using Kest.Infra.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kest.Infra.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order, Guid>
    {

    }
}
