using FluentMigrator;

namespace SamerCs.Migrations.DefaultDB
{
    [Migration(20161029130002)]
    public class DefaultDB_20161029_130002 : AutoReversingMigration
    {
        public override void Up()
        {
            this.Alter.Table("Book").AddColumn("Type").AsInt32().NotNullable().WithDefaultValue(0);
        }
    }
}