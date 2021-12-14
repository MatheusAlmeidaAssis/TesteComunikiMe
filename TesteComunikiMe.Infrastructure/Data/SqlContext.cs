using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaDetalhe> VendaDetalhes { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entrys = ChangeTracker.Entries();
            foreach (var entry in entrys)
            {
                if (entry.Property("DataCadastro") == null && entry.Property("DataAlteracao") == null && entry.Property("DataExclusao") == null)
                    continue;

                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                        entry.Property("DataAlteracao").IsModified = false;
                        entry.Property("DataExclusao").IsModified = false;
                        break;

                    case EntityState.Modified:
                        if (entry.Property("DataExclusao").CurrentValue == null)
                            entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                        entry.Property("DataCadastro").IsModified = false;
                        break;
                }
            }
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var properties = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties());
            foreach (var property in properties)
            {
                if (property.ClrType == typeof(string))
                    property.SetColumnType("varchar(100)");
                else if (property.ClrType == typeof(decimal))
                    property.SetColumnType("decimal(12,2)");
                else if (property.ClrType == typeof(DateTime))
                    property.SetColumnType("datetime2(7)");

                base.OnModelCreating(modelBuilder);
            }
        }
    }
}