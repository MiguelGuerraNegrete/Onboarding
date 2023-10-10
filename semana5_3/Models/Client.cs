using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana5_3.Models
{
    public class Client
    {
        public string Name { get; set; }
        public Double AvailableBalance{ get; set; }

        public Client(string name, double availableBalance)
        {
            Name = name;
            AvailableBalance = availableBalance;
        }
    }
}
