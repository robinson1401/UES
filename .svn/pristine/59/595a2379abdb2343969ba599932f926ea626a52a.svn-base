using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UES.Models;

namespace UES.Data
{
    public class UESContext : DbContext
    {
        public UESContext(DbContextOptions<UESContext> options)
            : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            foreach (var entityType in model.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType.BaseType == typeof(Enum))
                    {
                        var type = typeof(EnumToStringConverter<>).MakeGenericType(property.ClrType);
                        var converter = Activator.CreateInstance(type, new ConverterMappingHints()) as ValueConverter;

                        property.SetValueConverter(converter);
                    }
                }
            }
        }

        public DbSet<UES.Models.Permission> Permission { get; set; } = default!;

        public DbSet<UES.Models.Role> Role { get; set; } = default!;

        public DbSet<UES.Models.User> User { get; set; } = default!;

        public DbSet<UES.Models.TodoItem> TodoItem { get; set; } = default!;

        public DbSet<UES.Models.HeDaoTao> HeDaoTao { get; set; } = default!;
        public DbSet<UES.Models.Nganh> Nganh { get; set; } = default!;
        public DbSet<UES.Models.ChuongTrinhDaoTao> ChuongTrinhDaoTao { get; set; } = default!;
        public DbSet<UES.Models.HocPhan> HocPhan { get; set; } = default!;
        public DbSet<UES.Models.DauDiem> DauDiem { get; set; } = default!;
    }
}
