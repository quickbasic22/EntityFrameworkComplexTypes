namespace ComplexTypes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.People");
            AddColumn("dbo.People", "Address_StreetAddress", c => c.String());
            AddColumn("dbo.People", "Address_City", c => c.String());
            AddColumn("dbo.People", "Address_State", c => c.String());
            AddColumn("dbo.People", "Address_ZipCode", c => c.String());
            AlterColumn("dbo.People", "SocialSecurityNumber", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.People", "SocialSecurityNumber");
            DropColumn("dbo.People", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.People");
            AlterColumn("dbo.People", "SocialSecurityNumber", c => c.Int(nullable: false));
            DropColumn("dbo.People", "Address_ZipCode");
            DropColumn("dbo.People", "Address_State");
            DropColumn("dbo.People", "Address_City");
            DropColumn("dbo.People", "Address_StreetAddress");
            AddPrimaryKey("dbo.People", "ID");
        }
    }
}
