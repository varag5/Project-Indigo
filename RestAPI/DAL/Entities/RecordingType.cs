using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Entities
{
	public enum RecordingType
	{
		StartWalk,
		EndWalk,
		StartWaitingForVehicle,
		BoardingVehicle,
		AlightingVehicle,
		VehicleStops,
		VehicleLeaves,
	}
}
