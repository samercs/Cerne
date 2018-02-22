using FluentMigrator;

namespace SamerCs.Migrations.DefaultDB
{
    [Migration(20161029130003)]
    public class DefaultDB_20161029_130003 : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Auther", "Id", s =>
                s.WithColumn("Name").AsString().NotNullable().WithDefaultValue("-")
            );
        }
    }
}