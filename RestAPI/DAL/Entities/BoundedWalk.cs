using System;
using System.Collections.Generic;
using System.Linq;
//

//try
namespace DAL.Entities
{
	//Walk between two stops.
	public class BoundedWalk
	{
		public int ID { get; set; }
		public Stop? Start { get; set; }
		public Stop? End { get; set; }
	}
}
