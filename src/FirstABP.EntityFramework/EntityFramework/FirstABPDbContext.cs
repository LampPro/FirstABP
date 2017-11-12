using System.Data.Common;
using Abp.Zero.EntityFramework;
using FirstABP.Authorization.Roles;
using FirstABP.Authorization.Users;
using FirstABP.MultiTenancy;
using FirstABP.Entities;
using FirstABP.ValueObjects;
using System.Data.Entity;


namespace FirstABP.EntityFramework
{
    public class FirstABPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        public IDbSet<Department> Departments { get; set; }
        public IDbSet<UserExtend> UserExtends { get; set; }
    

        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FirstABPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FirstABPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FirstABPDbContext since ABP automatically handles it.
         */
        public FirstABPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FirstABPDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public FirstABPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
