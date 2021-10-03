using System;
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

        public void CreateStation(Station station)
        {
            if (station == null)
            {
                throw new ArgumentNullException(nameof(station));
            }

            _context.Stations.Add(station);
        }

        public IEnumerable<Station> GetAllStations()
        {
            return _context.Stations.ToList();
        }

        public Station GetStationById(int id)
        {
            return _context.Stations.FirstOrDefault(station => station.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}