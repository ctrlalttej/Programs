using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public interface INotification
    {
        public void SendNotification(string Message);
    }

    public class Notification:INotification
    {
        public void SendNotification(string NotificationMessage)
        {
            Console.WriteLine(NotificationMessage);
        }
    }

    public class NotificationService
    {
        public INotification notification = null;

        public void Notification(INotification notification,string message)
        {
            this.notification = notification;
            this.notification.SendNotification(message);
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Order Placed");
            notification?.SendNotification("sent an email to Customer");
        }
    }


    internal class DependencyPropertyInjection
    {
        public static void Main()
        {
            NotificationService service = new NotificationService();

            //service.Notification(new Notification(),"Hello Tejas, Property Injection is called");
            //service.notification=new Notification();
            service.PlaceOrder();
        }
    }
}
