﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("StudyFieldsResponse")]
        public StudyFieldsResponse StudyFieldsResponse { get; set; }
    }

    public partial class StudyFieldsResponse
    {
        [JsonProperty("APIVrs")]
        public string ApiVrs { get; set; }

        [JsonProperty("DataVrs")]
        public string DataVrs { get; set; }

        [JsonProperty("Expression")]
        public string Expression { get; set; }

        [JsonProperty("NStudiesAvail")]
        public long NStudiesAvail { get; set; }

        [JsonProperty("NStudiesFound")]
        public long NStudiesFound { get; set; }

        [JsonProperty("MinRank")]
        public long MinRank { get; set; }

        [JsonProperty("MaxRank")]
        public long MaxRank { get; set; }

        [JsonProperty("NStudiesReturned")]
        public long NStudiesReturned { get; set; }

        [JsonProperty("FieldList")]
        public string[] FieldList { get; set; }

        [JsonProperty("StudyFields")]
        public StudyField[] StudyFields { get; set; }
    }

    public partial class StudyField
    {
        [JsonProperty("Rank")]
        public long Rank { get; set; }

        [JsonProperty("NCTId")]
        public string[] NctId { get; set; }

        [JsonProperty("BriefTitle")]
        public string[] BriefTitle { get; set; }

        [JsonProperty("Condition")]
        public string[] Condition { get; set; }

        [JsonProperty("BriefSummary")]
        public string[] BriefSummary { get; set; }
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

