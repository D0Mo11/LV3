using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peti_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationBuilder Builder = new NotificationBuilder();
            Builder.SetAuthor("Random Author");
            Builder.SetColor(ConsoleColor.Blue);
            Builder.SetLevel(Category.ALERT);
            Builder.SetText("Random Text");
            Builder.SetTime(DateTime.Now);
            Builder.SetTitle("Random Title");
            ConsoleNotification Notification = Builder.Build();
            Builder.Display(Notification);
        }
    }
}
