namespace Ponker.Jams;

public class SongCollection
{
    public string FolderPath;
    public List<SongData> Songs;

    public SongCollection()
    {
        Songs = new List<SongData>();
    }
    
}