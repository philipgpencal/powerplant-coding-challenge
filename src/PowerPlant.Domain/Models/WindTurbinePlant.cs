﻿using System;

namespace PowerPlant.Domain.Models
{
    public class WindTurbinePlant : PowerPlant
    {
        /// <summary>
        /// wind in percentage
        /// </summary>
        private decimal Wind { get; }

        public WindTurbinePlant(decimal wind)
        {
            Wind = wind;
        }

        public override decimal CalculateEnergyCost()
        {
            throw new NotImplementedException();
        }

        public override decimal ProducePower(int load)
        {
            throw new NotImplementedException();
        }
    }
}
