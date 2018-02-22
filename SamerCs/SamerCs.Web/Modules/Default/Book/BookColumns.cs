
namespace SamerCs.Default.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Default.Book")]
    [BasedOnRow(typeof(Entities.BookRow), CheckNames = true)]
    public class BookColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
        public Int32 NoP { get; set; }
        public Int32 Type { get; set; }
    }
}