using CoolApp.Models;
using System.Collections.Generic;
namespace CoolApp
{
public class MusicManager: IMusicManager
{
    public List<SongModel> GetAllMusic()
    {
        return new List<SongModel>
                {
                    new SongModel { Id = 1, Title = "Interstat Love Song", Artist ="STP",Genre = "Hard Rock" },
                    new SongModel { Id = 2, Title = "Man In The Box", Artist ="Alice In Chains",Genre = "Grunge" },
                    new SongModel { Id = 3, Title = "Blind", Artist="Lifehouse", Genre = "Alternative" },
                    new SongModel { Id = 4, Title = "Hey Jude",Artist ="The Beatles", Genre = "Rock n Roll" }
                };
    }
}
}