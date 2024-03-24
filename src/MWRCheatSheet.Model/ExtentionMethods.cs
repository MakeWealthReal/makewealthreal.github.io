﻿namespace MWRCheatSheet.Model;

public static class ExtentionMethods
{
    public static VideoResource? Content(this VideoResource[] videos, Content content)
        => videos.FirstOrDefault(v => v.Content == content);

    public static string MinimalistUrl(this VideoResource video)
        => video.Platform switch
        {
            VideoPlatform.YouTube => Constants.MinimalistYouTubeLink(video.Id),
            VideoPlatform.Vimeo => Constants.MinimalistVimeoLink(video.Id),
            _ => throw new Exception("No video set!")
        };

    public static string EmbeddableUrl(this VideoResource video)
        => video.Platform switch
        {
            VideoPlatform.YouTube => Constants.EmbeddableYouTubeLink(video.Id),
            VideoPlatform.Vimeo => Constants.MinimalistVimeoLink(video.Id),
            _ => throw new Exception("No video set!")
        };
}
