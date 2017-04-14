namespace Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addurlhehe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SysDepartment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        DepartmentDesc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SysUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoginName = c.String(maxLength: 10),
                        Email = c.String(),
                        Password = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        SysDepartmentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SysDepartment", t => t.SysDepartmentID)
                .Index(t => t.SysDepartmentID);
            
            CreateTable(
                "dbo.SysUserRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SysUserID = c.Int(nullable: false),
                        SysRoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SysRole", t => t.SysRoleID, cascadeDelete: true)
                .ForeignKey("dbo.SysUser", t => t.SysUserID, cascadeDelete: true)
                .Index(t => t.SysUserID)
                .Index(t => t.SysRoleID);
            
            CreateTable(
                "dbo.SysRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleDesc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SysUserRole", "SysUserID", "dbo.SysUser");
            DropForeignKey("dbo.SysUserRole", "SysRoleID", "dbo.SysRole");
            DropForeignKey("dbo.SysUser", "SysDepartmentID", "dbo.SysDepartment");
            DropIndex("dbo.SysUserRole", new[] { "SysRoleID" });
            DropIndex("dbo.SysUserRole", new[] { "SysUserID" });
            DropIndex("dbo.SysUser", new[] { "SysDepartmentID" });
            DropTable("dbo.SysRole");
            DropTable("dbo.SysUserRole");
            DropTable("dbo.SysUser");
            DropTable("dbo.SysDepartment");
        }
    }
}
