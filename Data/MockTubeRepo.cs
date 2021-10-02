using System.Collections.Generic;
using Tube.Models;

namespace Tube.Data
{
    public class MockTubeRepo : ITubeRepo
    {
        public IEnumerable<Station> GetAllStations()
        {
            return new List<Station>
            {
                new Station{Id=0, Name="Ruislip Gardens"},
                new Station{Id=1, Name="Northolt"},
                new Station{Id=2, Name="Battersea Power Station"}
            };
        }

        public Station GetStationById(int id)
        {
            return new Station { Id = 0, Name = "Ruislip Gardens" };
        }
    }
}