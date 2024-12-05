using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SpendWise.Models
{
    internal class Budget
    {
        [PrimarKey, AutoIncrement]
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Limit { get; set; }
        public decimal CurrentUsage { get; set; }
    }
}
