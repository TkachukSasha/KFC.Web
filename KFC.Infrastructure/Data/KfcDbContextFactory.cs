using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Infrastructure.Data
{
    public class KfcDbContextFactory : IDesignTimeDbContextFactory<KfcDbContext>
    {
        public KfcDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<KfcDbContext>();
            options.UseSqlServer("Server=DESKTOP-ELR5B0P;Database=SportStore.DB;Trusted_Connection=True;");

            return new KfcDbContext(options.Options);
        }
    }
}
