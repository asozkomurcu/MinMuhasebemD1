using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinMuhasebemD1.Models
{
    public class SupplierAccountMovements
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public double Debt { get; set; }
        public double Peyment { get; set; }

        public Supplier Supplier { get; set; }

    }
}
