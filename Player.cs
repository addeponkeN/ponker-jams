using LibVLCSharp.Shared;

namespace Ponker.Jams;

public class Player
{
    public LibVLC VLC;
    public MediaPlayer MP;

    private Media _media;

    public Player()
    {
        Core.Initialize();
        
        VLC = new();
        
        string musicFolderPath = @"X:\Museser\PonkerBot\";
        string songName = @"Terraria Music - Ice";
        string fileExt = "mp3";
        
        var finalPath = Path.Combine(@$"{musicFolderPath}", $"{songName}.{fileExt}");

        _media = new Media(VLC, new Uri(finalPath));

        MP = new MediaPlayer(_media);
        
    }

    public void PlaySong(string title)
    {
        MP.Play();
    }
    
}