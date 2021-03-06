﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Miner.Domain
{
    /// <summary>
    /// Serializes the top level of the GW2Spidy item listing
    /// </summary>
    /// <remarks>
    /// See: https://github.com/rubensayshi/gw2spidy/wiki/API-v0.9#wiki-full-item-list
    /// </remarks>
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemBuySellListingItem
    {
        [JsonProperty("listings")]
        public int NumberOfListings { get; set; }

        [JsonProperty("quantity")]
        public int NumberAvailable { get; set; }

        [JsonProperty("unit_price")]
        public int PricePerUnit { get; set; }
    }
}
