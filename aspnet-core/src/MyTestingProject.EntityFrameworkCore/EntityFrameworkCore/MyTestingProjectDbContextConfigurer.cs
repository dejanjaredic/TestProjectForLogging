using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTestingProject.EntityFrameworkCore
{
    public static class MyTestingProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyTestingProjectDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyTestingProjectDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
