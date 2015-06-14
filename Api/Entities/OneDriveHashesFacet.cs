﻿using Newtonsoft.Json;

namespace KoenZomers.OneDrive.Api.Entities
{
    public class OneDriveHashesFacet
    {
        [JsonProperty("sha1Hash")]
        public string Sha1 { get; set; }

        [JsonProperty("crc32Hash")]
        public string Crc32 { get; set; }
    }
}
