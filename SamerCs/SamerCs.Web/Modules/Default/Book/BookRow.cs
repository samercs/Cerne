
namespace SamerCs.Default.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Book]")]
    [DisplayName("Book"), InstanceName("Book")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class BookRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Name"), Size(255), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("No Of Pages"), NotNull]
        public Int32? NoP
        {
            get { return Fields.NoP[this]; }
            set { Fields.NoP[this] = value; }
        }

        [DisplayName("Type"), NotNull]
        public BookType? Type
        {
            get { return (BookType?)Fields.Type[this]; }
            set { Fields.Type[this] = (Int32?)value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public BookRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField Name;
            public Int32Field NoP;
            public Int32Field Type;
        }
    }
}
