﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PowerPlant.Application.DTO
{
    public class PowerSupplyDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("p")]
        public int Power { get; set; }
    }
}
