using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    //this is a class that will be used to send automated emails.
    public static class MailManager
    {
        private static readonly string emailAddress = "choclate00@live.com";
        private static readonly string password = "vmgobyureguiixxd";

        private static SmtpClient smptServer = new SmtpClient("smtp-mail.outlook.com", 587);

        //this will send the customer booking confirmation.
        private static void addCredentials()
        {
            NetworkCredential credential = new NetworkCredential(emailAddress, password);
            smptServer.Credentials = credential;
        }

        public static void SendBookingConfirmation(string customerName, string customerEmail, RoomBooking roomBooking)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(emailAddress);
            mailMessage.To.Add(new MailAddress(customerEmail));
            mailMessage.Subject = "Booking confirmation";
            string messaageStr = "Hi " + customerName + ",\n\n You have booked your room " + roomBooking.RoomId + "from ";
            messaageStr += roomBooking.CheckInDate + " until " + roomBooking.CheckOutDate + ".";
            mailMessage.Body = messaageStr;
            //sends the email
            smptServer.Send(mailMessage);
        }
            
            
    }
}
