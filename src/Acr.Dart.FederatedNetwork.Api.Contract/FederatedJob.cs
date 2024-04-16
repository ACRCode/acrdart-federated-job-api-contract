using Acr.Dart.FederatedNetwork.Api.Contract.Enums;
using Newtonsoft.Json;
using System;

namespace Acr.Dart.FederatedNetwork.Api.Contract
{
    public class FederatedJob
    {
        [JsonProperty("transactionId")]
        public Guid TransactionId { get; set; }

        [JsonProperty("createdTime")]
        public DateTime CreatedTime { get; set; }

        [JsonProperty("jobName")]
        public string JobName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("datasetPublicId")]
        public string DatasetPublicId { get; set; }

        [JsonProperty("status")]
        public FederatedJobStatus Status { get; set; }

        [JsonProperty("algorithm")]
        public FederatedJobAlgorithm Algorithm { get; set; }

    }
}
