using Xunit;

namespace PALib.Tests
{
	public class PAPlanet_Tests
	{
		private readonly PAPlanet _paPlanet;

		public PAPlanet_Tests()
		{
			_paPlanet = new PAPlanet();
		}

		[Fact]
		public void ApproximatePositionOfPlanet()
		{
			Assert.Equal((11, 11, 13.8, 6, 21, 25.1), _paPlanet.ApproximatePositionOfPlanet(0, 0, 0, false, 0, 22, 11, 2003, "Jupiter"));
		}

		[Fact]
		public void PrecisePositionOfPlanet()
		{
			Assert.Equal((11, 10, 30.99, 6, 25, 49.46), _paPlanet.PrecisePositionOfPlanet(0, 0, 0, false, 0, 22, 11, 2003, "Jupiter"));
		}
	}
}