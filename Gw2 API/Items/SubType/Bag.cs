﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GW2Miner.Domain
{
    /// <summary>
    /// Serializes a single GW2 API bag item
    /// </summary>
    /// <remarks>
    /// See: https://forum-en.guildwars2.com/forum/community/api/API-Documentation/first#post2028044
    /// and http://wiki.guildwars2.com/wiki/API/item_details
    /// </remarks>
    [JsonObject(MemberSerialization.OptIn)]
    public class gw2apiBagItem
    {
        [JsonProperty("no_sell_or_sort")]
        [JsonConverter(typeof(BoolConverter))]
        public bool NoSellOrSort;

        [JsonProperty("size")]
        public int Size;
    }
}
