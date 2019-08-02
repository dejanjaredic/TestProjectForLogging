using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyTestingProject.Authorization.Roles;
using MyTestingProject.Authorization.Users;
using MyTestingProject.Models;
using MyTestingProject.MultiTenancy;
using MyTestingProject.Services;

namespace MyTestingProject.EntityFrameworkCore
{
    public class MyTestingProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyTestingProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<TimeModel> TimeModels { get; set; }
        public DbSet<Log> Logs { get; set; }
        public MyTestingProjectDbContext(DbContextOptions<MyTestingProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
