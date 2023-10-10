using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana5_3.Models
{
    public class Order
    {
        public string ClientName { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public Order(string clientName, double value, DateTime date)
        {
            ClientName = clientName;
            Value = value;
            Date = date;
        }
    }
}
