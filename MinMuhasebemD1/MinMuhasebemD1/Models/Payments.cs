using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;



namespace MinMuhasebemD1.Models
{
    public class Payments
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int? CreditCardId { get; set; }
        public double AmountPaid { get; set; }
        public DateTime PayDate { get; set; }
        public String PaymentType { get; set; }

        public Supplier Supplier { get; set; }
        public CreditCards CreditCards { get; set; }
    }
    public enum PayType
    {
        [Description("Nakit")]
        Cash = 0,
        [Description("Kredi Kartı")]
        CreditCard = 1
    }

    


}
