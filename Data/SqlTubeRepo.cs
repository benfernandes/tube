using System.Collections.Generic;
using System.Linq;
using Tube.Models;

namespace Tube.Data
{
    public class SqlTubeRepo : ITubeRepo
    {
        private readonly TubeContext _context;
        public SqlTubeRepo(TubeContext context)
        {
            _context = context;
        }

        public IEnumerable<Station> GetAllStations()
        {
            return _context.Stations.ToList();
        }

        public Station GetStationById(int id)
        {
            return _context.Stations.FirstOrDefault(station => station.Id == id);
        }
    }
}