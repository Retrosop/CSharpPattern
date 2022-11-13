using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaExample.Domain
{
    internal class MassageMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public MassageMembership(decimal price)
        {
            _name = "Massage with beatufil girl membership";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }
        public decimal GetPrice() => _price;

    }
}

