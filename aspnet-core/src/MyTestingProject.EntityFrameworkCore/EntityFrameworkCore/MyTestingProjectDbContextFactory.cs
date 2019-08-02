using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyTestingProject.Configuration;
using MyTestingProject.Web;

namespace MyTestingProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyTestingProjectDbContextFactory : IDesignTimeDbContextFactory<MyTestingProjectDbContext>
    {
        public MyTestingProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyTestingProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyTestingProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyTestingProjectConsts.ConnectionStringName));

            return new MyTestingProjectDbContext(builder.Options);
        }
    }
}
