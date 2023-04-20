using FluentAssertions;

namespace ScooterRental.Tests
{
    

    public class ScooterServiceTests
    {
        private IScooterService _scooterService;
        private List<Scooter> _scooters;

        [SetUp]
        public void Setup()
        {
            _scooters = new List<Scooter>();
            _scooterService = new ScooterService(_scooters);

        }

        [Test]
        public void AddScooter_AddValidScooter_ScooterAdded()
        {
            _scooterService.AddScooter("1", 1m);
            _scooters.Count.Should().Be(1);
        }
    }
}