using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mandrill
{
    public enum InfoResultState
    {
        Sent,
        Bounced,
        Rejected
    }

    public class InfoResult
    {
        [JsonProperty("ts")]
        public int ts { get; set; }
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public InfoResultState state { get; set; }
        //[JsonProperty("state")]
        //public string Status { get; set; }
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        //[JsonProperty("opens")]
        //public int Opens { get; set; }

        //[JsonProperty("clicks")]
        //public int Clicks { get; set; }
    }
}

//{"ts":1386055196,"_id":"b3bd2f40a51d4c92b6713a413b030784","state":"sent","subject":"\u6e2c\u8a66\u5b78\u751f20130806","email":"wangjungfeng@studentsforever.net","tags":[],"opens":0,"clicks":0,"smtp_events":[{"ts":1386055197,"type":"sent","diag":"250 2.0.0 OK s4si529584qcc.92 - gsmtp","source_ip":"205.201.131.131","destination_ip":"173.194.68.26","size":2870}],"resends":[],"_table":"Search","sender":"paul.wang@ischool.com.tw","template":null,"opens_detail":[],"clicks_detail":[]}