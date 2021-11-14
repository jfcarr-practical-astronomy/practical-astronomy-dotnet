using System;
using Xunit;

namespace PALib.Tests;

public class PASun_Tests
{
	private readonly PASun _paSun;

	public PASun_Tests()
	{
		_paSun = new PASun();
	}

	[Fact]
	public void ApproximatePositionOfSun()
	{
		Assert.Equal((8, 23, 33.73, 19, 21, 14.33), _paSun.ApproximatePositionOfSun(0, 0, 0, 27, 7, 2003, false, 0));
	}

	[Fact]
	public void PrecisePositionOfSun()
	{
		Assert.Equal((8, 26, 3.83, 19, 12, 49.72), _paSun.PrecisePositionOfSun(0, 0, 0, 27, 7, 1988, false, 0));
	}

	[Fact]
	public void SunDistanceAndAngularSize()
	{
		Assert.Equal((151920130, 0, 31, 29.93), _paSun.SunDistanceAndAngularSize(0, 0, 0, 27, 7, 1988, false, 0));
	}

	[Fact]
	public void SunriseAndSunset()
	{
		Assert.Equal((6, 5, 17, 45, 94.83, 265.43, "OK"), _paSun.SunriseAndSunset(10, 3, 1986, false, -5, -71.05, 42.37));
	}

	[Fact]
	public void MorningAndEveningTwilight()
	{
		Assert.Equal((3, 17, 20, 37, "OK"), _paSun.MorningAndEveningTwilight(7, 9, 1979, false, 0, 0, 52, PATwilightType.Astronomical));
	}

	[Fact]
	public void EquationOfTime()
	{
		Assert.Equal((6, 31.52), _paSun.EquationOfTime(27, 7, 2010));
	}

	[Fact]
	public void SolarElongation()
	{
		Assert.Equal(24.78, _paSun.SolarElongation(10, 6, 45, 11, 57, 27, 27.8333333, 7, 2010));
	}
}
