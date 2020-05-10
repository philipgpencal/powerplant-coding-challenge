﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerPlant.Application.DTO
{
    public class PayloadDTO
    {
        [JsonProperty("load")]
        [Range(1, int.MaxValue, ErrorMessage = "The load value must be bigger than zero")]
        public int Load { get; set; }

        [JsonProperty("fuels")]
        public FuelsDTO Fuels { get; set; }

        [JsonProperty("powerplants")]
        public List<PowerPlantDTO> Powerplants { get; set; }
    }
}
