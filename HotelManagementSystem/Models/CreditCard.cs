using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class CreditCard
    {
        private string creditCardNumber;
        private string cvc;
        private string issuer;
        private DateTime issueDate;
        private DateTime expiryDate;

        public CreditCard(string creditcardNumber, string cvc, string issuer, DateTime issueDate, DateTime expiryDate)
        {
            this.creditCardNumber = creditcardNumber;
            this.cvc = cvc;
            this.issuer = issuer;
            this.issueDate = issueDate;
            this.expiryDate = expiryDate;
        }

        public string CreditCardNumber { get => creditCardNumber; set => creditCardNumber = value; }
        public string CVC { get => cvc; set => cvc = value; }
        public string Issuer { get => issuer; set => issuer = value; }
        public DateTime IssueDate { get => issueDate; set => issueDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
