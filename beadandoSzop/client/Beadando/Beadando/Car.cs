using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beadando
{
    public class Car
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("marka")]
        public string Marka { get; set; }

        [JsonPropertyName("tipus")]
        public string Tipus { get; set; }

        [JsonPropertyName("evjarat")]
        public int Evjarat { get; set; }

        [JsonPropertyName("kivitel")]
        public string Kivitel { get; set; }

        [JsonPropertyName("uzemanyag")]
        public string Uzemanyag { get; set; }

        [JsonPropertyName("ar")]
        public int Ar { get; set; }

    } 
}
