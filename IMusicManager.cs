using CoolApp.Models;
using System.Collections.Generic;

namespace CoolApp
{
    public interface IMusicManager
    {
        List<SongModel> GetAllMusic();
    }
}