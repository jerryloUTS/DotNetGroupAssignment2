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
        private static void AddCredentials()
        {
            NetworkCredential credential = new NetworkCredential(emailAddress, password);
            smptServer.Credentials = credential;
            smptServer.EnableSsl = true;
        }

        public static void SendBookingConfirmation(string receptionistName, string customerName, string customerEmail, RoomBooking roomBooking)
        {
            //adds the credentials
            AddCredentials();
            //generates the mail message.
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(emailAddress, "Hotel Management System");
            mailMessage.To.Add(new MailAddress(customerEmail));
            mailMessage.Subject = "Booking confirmation";
            string messaageStr = "Hi " + customerName + ",\n\nWe have booked your room " + roomBooking.RoomId + " from ";
            messaageStr += roomBooking.CheckInDate + " until " + roomBooking.CheckOutDate + ".";
            messaageStr += "\n\nBest regards,\n\n";
            messaageStr += receptionistName;
            messaageStr += "\nReceptionist from Hotel Management System";

            mailMessage.Body = messaageStr;
            //sends the email
            smptServer.Send(mailMessage);
        }
            
            
    }
}
