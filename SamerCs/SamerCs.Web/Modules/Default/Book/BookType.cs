using Serenity.ComponentModel;
using System.ComponentModel;

namespace SamerCs
{
    [EnumKey("Default.BookType")]
    public enum BookType
    {
        [Description("Type1")]
        Type1,
        [Description("Type2")]
        Type2,
        [Description("Type3")]
        Type3
    }
}