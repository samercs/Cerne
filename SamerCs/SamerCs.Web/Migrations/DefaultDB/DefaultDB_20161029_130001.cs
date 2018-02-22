using FluentMigrator;

namespace SamerCs.Migrations.DefaultDB
{
    [Migration(20161029130001)]
    public class DefaultDB_20161029_130001 : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("Book", "Id", s => s
                .WithColumn("Name").AsString().NotNullable().WithDefaultValue("-")
                .WithColumn("NoP").AsInt32().NotNullable().WithDefaultValue(100));
        }
    }
}