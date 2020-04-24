using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetvrti_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification Notification = new ConsoleNotification("Domagoj Dragic", "Moj program", "Ovo je moj program", DateTime.Now, Category.INFO, ConsoleColor.Magenta);
            NotificationManager Builder = new NotificationManager();
            Builder.Display(Notification);
        }
    }
}
