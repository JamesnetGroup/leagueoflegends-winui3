using Leagueoflegends.Support.Local.Models;

using System.Collections.Generic;
namespace Leagueoflegends.Support.Local.Datas;

public interface ISkinsDataLoader
{
    List<Skin> LoadSkins();
    Dictionary<string, List<Skin>> GetSkinsGroupedByName();
}
