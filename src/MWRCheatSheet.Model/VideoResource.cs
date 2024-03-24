﻿using System.Text.Json.Serialization;

namespace MWRCheatSheet.Model;

public class VideoResource
{
    [JsonPropertyName("contentId")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Content Content { get; set; }

    [JsonPropertyName("videoId")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("platform")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public VideoPlatform Platform { get; set; }
}
