using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolystreamAssessment.Models.BodyModels
{
    public class ApplicationBody
    {
        [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }

        [JsonProperty("container")]
        public string container { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }
    }
}
