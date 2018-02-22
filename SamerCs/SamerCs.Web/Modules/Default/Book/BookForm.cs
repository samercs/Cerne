
namespace SamerCs.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Book")]
    [BasedOnRow(typeof(Entities.BookRow), CheckNames = true)]
    public class BookForm
    {
        public String Name { get; set; }
        public Int32 NoP { get; set; }
        public Int32 Type { get; set; }
    }
}