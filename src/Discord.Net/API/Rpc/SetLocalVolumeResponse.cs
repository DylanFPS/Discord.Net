﻿using Newtonsoft.Json;

namespace Discord.API.Rpc
{
    public class SetLocalVolumeResponse
    {
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}
