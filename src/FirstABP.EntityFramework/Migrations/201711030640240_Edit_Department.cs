namespace FirstABP.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Department : DbMigration
    {
        public override void Up()
        {
            AlterTableAnnotations(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TenantId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        CostCenter = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        ParentDepartment_Id = c.Guid(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Department_MustHaveTenant",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AddColumn("dbo.Departments", "TenantId", c => c.Int(nullable: false));
            AddColumn("dbo.AbpUsers", "Department_Id", c => c.Guid());
            CreateIndex("dbo.AbpUsers", "Department_Id");
            AddForeignKey("dbo.AbpUsers", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AbpUsers", "Department_Id", "dbo.Departments");
            DropIndex("dbo.AbpUsers", new[] { "Department_Id" });
            DropColumn("dbo.AbpUsers", "Department_Id");
            DropColumn("dbo.Departments", "TenantId");
            AlterTableAnnotations(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TenantId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        CostCenter = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        ParentDepartment_Id = c.Guid(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Department_MustHaveTenant",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
        }
    }
}
