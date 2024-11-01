using Newtonsoft.Json;
using System.Collections.Generic;

namespace Azure.Migrate.Export.Models
{
    public class UpdateMachinesInGroupBodyJSON
    {
        [JsonProperty("properties")]
        public UpdateMachinesInGroupProperty Properties { get; set; } = new UpdateMachinesInGroupProperty();

        [JsonProperty("eTag")]
        public string ETag { get; set; } = "*";
    }

    public class UpdateMachinesInGroupProperty
    {
        [JsonProperty("machines")]
        public List<string> Machines { get; set; } = new List<string>();

        [JsonProperty("operationType")]
        public string OperationType { get; set; } = "Add";
    }
}