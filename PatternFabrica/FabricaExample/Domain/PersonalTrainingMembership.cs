﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaExample.Domain
{
    internal class PersonalTrainingMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public PersonalTrainingMembership(decimal price)
        {
            _name = "Personal Training membership";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }
        public decimal GetPrice() => _price;

    }
}
