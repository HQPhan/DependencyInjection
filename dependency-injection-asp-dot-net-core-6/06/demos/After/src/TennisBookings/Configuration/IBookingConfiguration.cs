﻿namespace TennisBookings.Configuration
{
	public interface IBookingConfiguration
	{
		int MaxPeakBookingLengthInHours { get; set; }
		int MaxRegularBookingLengthInHours { get; set; }
	}
}