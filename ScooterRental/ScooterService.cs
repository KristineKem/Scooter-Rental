using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _scooters;

        public ScooterService(List<Scooter> scooters)
        {
            _scooters = scooters;
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            var scooter = new Scooter(id, pricePerMinute);
            _scooters.Add(scooter);
        }

        public Scooter GetScooterById(string scooterId)
        {
            throw new NotImplementedException();
        }

        public IList<Scooter> GetScooters()
        {
            throw new NotImplementedException();
        }

        public void RemoveScooter(string id)
        {
            throw new NotImplementedException();
        }
    }
}
