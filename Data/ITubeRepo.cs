using System.Collections.Generic;
using Tube.Models;

namespace Tube.Data
{
    public interface ITubeRepo
    {
        bool SaveChanges();
        IEnumerable<Station> GetAllStations();
        Station GetStationById(int id);
        void CreateStation(Station station);
    }
}