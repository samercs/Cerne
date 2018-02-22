
namespace SamerCs.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Auther")]
    [BasedOnRow(typeof(Entities.AutherRow), CheckNames = true)]
    public class AutherForm
    {
        public String Name { get; set; }
    }
}