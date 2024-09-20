using Leagueoflegends.Support.Local.Models;
using System.Collections.Generic;

namespace Leagueoflegends.Support.Local.Datas;

public interface IChampStatsDataLoader
{
    List<ChampionStats> LoadChampionStats();
    Dictionary<string, List<ChampionStats>> GetStatsByPosition();
}
