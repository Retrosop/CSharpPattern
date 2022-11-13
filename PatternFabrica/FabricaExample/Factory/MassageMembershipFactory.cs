using FabricaExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaExample.Factory
{
    internal class MassageMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public MassageMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            MassageMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
