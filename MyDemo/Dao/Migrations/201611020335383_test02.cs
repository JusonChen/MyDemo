namespace Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test02 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SysUser", name: "LoginName", newName: "UserName");
            AlterColumn("dbo.SysUser", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.SysUser", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.SysUser", "Password", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SysUser", "Password", c => c.String());
            AlterColumn("dbo.SysUser", "Email", c => c.String());
            AlterColumn("dbo.SysUser", "UserName", c => c.String(maxLength: 10));
            RenameColumn(table: "dbo.SysUser", name: "UserName", newName: "LoginName");
        }
    }
}
