namespace FirstABP.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class add_UserExtend : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserExtends",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Address_Province = c.String(maxLength: 10),
                        Address_City = c.String(maxLength: 20),
                        Address_County = c.String(maxLength: 20),
                        Address_Street = c.String(maxLength: 60),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Department_Id = c.Guid(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UserExtend_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            AddColumn("dbo.AbpUsers", "Extend_Id", c => c.Guid());
            CreateIndex("dbo.AbpUsers", "Extend_Id");
            AddForeignKey("dbo.AbpUsers", "Extend_Id", "dbo.UserExtends", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AbpUsers", "Extend_Id", "dbo.UserExtends");
            DropForeignKey("dbo.UserExtends", "Department_Id", "dbo.Departments");
            DropIndex("dbo.UserExtends", new[] { "Department_Id" });
            DropIndex("dbo.AbpUsers", new[] { "Extend_Id" });
            DropColumn("dbo.AbpUsers", "Extend_Id");
            DropTable("dbo.UserExtends",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_UserExtend_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
