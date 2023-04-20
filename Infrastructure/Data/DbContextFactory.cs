using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data
{
	public class DbContextFactory
	{
        public class DbContextDesignTimeFactory : IDesignTimeDbContextFactory<WebAppDbContext>
        {
            public WebAppDbContext CreateDbContext(string[] args)
            {
                DbContextOptionsBuilder<WebAppDbContext> builder = new DbContextOptionsBuilder<WebAppDbContext>();
                builder.UseSqlServer("Server=localhost; Database=WebDB; User Id=sa; Password=#Wmafs6119107; TrustServerCertificate=true");
                return new WebAppDbContext(builder.Options);
            }
        }
    }
}

