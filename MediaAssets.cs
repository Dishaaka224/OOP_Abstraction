using System;
namespace OOP_Abstraction;

abstract class MediaAsset
{
    public string Title{get; set;}

    protected MediaAsset (string title) => Title = title;

    public abstract void Play();
    public abstract string GetFormat();
    public void ShowTitle() => Console.WriteLine($"Media: {Title}");
}

class AudioAsset : MediaAsset
{
    public AudioAsset(string title) : base(title) { }

    public override void Play() => Console.WriteLine($"Audio played: {Title}");
    public override string GetFormat() => "Audio format: MP3";
}

class VideoAsset(string title) : MediaAsset(title) 
{
    public override void Play() => Console.WriteLine($"Video played: {Title}");
    public override string GetFormat() => "Video format: MP4";
}

class PodcastAsset : MediaAsset
{
    public PodcastAsset(string title) : base(title) { }

    public override void Play() => Console.WriteLine($"Listen Podcast: {Title}");
    public override string GetFormat() => "Podcast format: MP3";
}


