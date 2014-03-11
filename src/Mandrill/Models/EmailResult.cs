using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Mandrill
{
    public enum EmailResultStatus
    {
        Sent, 
        Queued,
        Rejected,
        Invalid,
        Scheduled
    }

    public class EmailResult
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("reject_reason")]
        public string RejectReason { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EmailResultStatus Status { get; set; }
    }
}