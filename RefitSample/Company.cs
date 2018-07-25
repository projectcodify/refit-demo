using Newtonsoft.Json;
using System.Collections.Generic;

namespace RefitSample
{
    public class Company
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("CEO")]
        public string Ceo { get; set; }

        [JsonProperty("issueType")]
        public string IssueType { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}
