﻿using System;

namespace PowerPlant.Domain.Models
{
    public class TurboJetPlant : PowerPlant
    {
        /// <summary>
        /// kerosine (euro per MWh)
        /// </summary>
        private decimal Kerosine { get; }

        public TurboJetPlant(decimal kerosine)
        {
            Kerosine = kerosine;
        }

        public override decimal CalculateEnergyCost()
        {
            return Kerosine / Efficiency;
        }
    }
}
