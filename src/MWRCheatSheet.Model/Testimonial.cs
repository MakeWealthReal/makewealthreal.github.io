﻿using System.Text.Json.Serialization;

namespace MWRCheatSheet.Model;

public class Testimonial
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("video")]
    public VideoResource Video { get; set; } = default!;

    [JsonPropertyName("highlights")]
    public Highlight[] Highlights { get; set; } = [];
}
