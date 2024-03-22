using Newtonsoft.Json;

namespace Acr.Dart.FederatedNetwork.Api.Contract
{
    public class FederatedJobAlgorithm
    {

        [JsonProperty("algorithmName")]
        public string AlgorithmName { get; set; }

        [JsonProperty("modelResourceId")]
        public string ModelResourceId { get; set; }

        [JsonProperty("usecaseName")]
        public string UsecaseName { get; set; }

        [JsonProperty("validationProfile")]
        public string ValidationProfile { get; set; }
    }
}
