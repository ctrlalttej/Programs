using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public interface IEmailService
    {
        public void SendEmail();
    }

    public class EmailService:IEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }
    }


    //Constructor Injection
    //public class OrderService
    //{
    //    IEmailService emailService;
    //    public OrderService(IEmailService emailService)
    //    {
    //        this.emailService = emailService;
    //    }

    //    public void PlaceOrder()
    //    {
    //        Console.WriteLine("Order Placed");
    //        emailService.SendEmail();
    //    }

    //Property Injection
    //public class OrderService
    //{
    //    public IEmailService EmailService;

    //    public void PlaceOrder()
    //    {
    //        Console.WriteLine("Order Placed");
    //        EmailService.SendEmail();
    //    }
    //}

    //Method Injection
    public class OrderService
    {
        public void PlaceOrder(IEmailService emailService)
        {
            Console.WriteLine("Order placed");
            emailService.SendEmail();
        }
    }

    
    internal class Dependency2
    {
        public static void Main()
        {
            OrderService order = new OrderService();
            //order.EmailService = new EmailService();
            order.PlaceOrder(new EmailService());
        }
    }


}
