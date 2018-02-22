using Serenity.Navigation;
using MyPages = SamerCs.Default.Pages;

[assembly: NavigationLink(10001, "Default/Book", typeof(MyPages.BookController), icon: "fa-book")]
[assembly: NavigationLink(10002, "Default/Auther", typeof(MyPages.AutherController), icon: "fa-user")]
