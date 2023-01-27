using OboCore.Utility;

namespace Ponker.Jams;

public class JamsCore
{
    public List<SongCollection> Collections;

    public JamsCore()
    {
        Collections = new();
    }

    public void LoadCollection(string fullpath)
    {
        var collection = JsonHelper.Load<SongCollection>(fullpath);
    }
}