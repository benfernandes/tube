using System.Collections.Generic;
using Tube.Models;

namespace Tube.Data
{
    public interface ITubeRepo
    {
        IEnumerable<Station> GetAllStations();
        Station GetStationById(int id);
    }
}