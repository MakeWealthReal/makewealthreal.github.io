﻿using Blazored.LocalStorage;
using MWRCheatSheet.Repository.Model;

namespace MWRCheatSheet.Repository;

public class Repository
{
    private const string SettingsKey = "settings";

    public async Task<Settings> GetSettingsAsync(ILocalStorageService localStorage)
    {
        Settings? foundSettings = null;

        if (await localStorage.ContainKeyAsync(SettingsKey))
        {
            foundSettings = await localStorage.GetItemAsync<Settings>(SettingsKey);
        }

        return foundSettings ?? new();
    }

    public async Task SaveSettingsAsync(Settings settings, ILocalStorageService localStorage)
    {
        await localStorage.SetItemAsync(SettingsKey, settings);

    }

    public async Task<string?> GetUsernameAsync(ILocalStorageService localStorage, HttpClient http)
    {
        string? foundUsername = null;

        if (await localStorage.ContainKeyAsync(SettingsKey))
        {
            foundUsername = (await localStorage.GetItemAsync<Settings>(SettingsKey))?.Username;

            // validate username
            if (string.IsNullOrWhiteSpace(foundUsername))
            {
                foundUsername = null;
            }
            else
            {
                if (!await Util.IsUsernameValidAsync(foundUsername, http))
                {
                    foundUsername = null;
                }
            }
        }

        return foundUsername;
    }
}