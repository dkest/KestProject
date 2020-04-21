using Kest.Domain.OrderAggregate;
using Kest.Infra.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kest.Infra.Data.Repositories
{
    public class OrderRepository : Repository<Order, long, DomainContext>, IOrderRepository
    {
        public OrderRepository(DomainContext context) : base(context)
        {
        }
    }
}
