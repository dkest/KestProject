using Kest.Domain.OrderAggregate;
using Kest.Domain.UserAggregate;
using Kest.Infra.Core;
using Microsoft.EntityFrameworkCore;
using MediatR;
using DotNetCore.CAP;
using Kest.Infra.Data.EntityConfigurations;

namespace Kest.Infra.Data
{
    public class DomainContext : EFContext
    {
        public DomainContext(DbContextOptions options, IMediator mediator, ICapPublisher capBus) : base(options, mediator, capBus)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 注册领域模型与数据库的映射关系
            modelBuilder.ApplyConfiguration(new OrderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
