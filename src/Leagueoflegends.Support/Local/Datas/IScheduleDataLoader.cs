﻿using Leagueoflegends.Support.Local.Models;
using System.Collections.Generic;

namespace Leagueoflegends.Support.Local.Datas;

public interface IScheduleDataLoader
{
    List<Schedule> LoadSchedules();
}
