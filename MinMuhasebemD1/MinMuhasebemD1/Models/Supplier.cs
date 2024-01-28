using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinMuhasebemD1.Models
{
    public class Supplier
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public ICollection<Payments> payments { get; set; }
        public ICollection<SupplierAccountMovements> supplierAccountMovements { get; set; }
    }
}
