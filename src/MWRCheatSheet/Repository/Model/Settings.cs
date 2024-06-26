﻿using System.Text.Json.Serialization;
using MWRCheatSheet.Model;

namespace MWRCheatSheet.Repository.Model;

public class Settings
{
    [JsonPropertyName("username")]
    public string Username { get; set; } = default!;

    [JsonPropertyName("fast_start_checklist")]
    public FastStartChecklist FastStartChecklist { get; set; } = new();

    [JsonPropertyName("livestream_platform_preference")]
    public Dictionary<string, LivestreamPlatform> LivestreamPlatformPreference { get; set; } = new()
    {
        { "72day-blitz", LivestreamPlatform.Facebook },
    };
}