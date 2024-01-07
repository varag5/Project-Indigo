
using System;
using System.Collections.Generic;
using System.Linq;

using Bll.Dtos;
using DAL.Entities;
namespace Bll.Dtos{

public static class DataMapper
{
    public static ItineraryDto ConvertToDTO(this Itinerary itinerary)
    {
        return new ItineraryDto { ID = itinerary.ID, Start = itinerary.Start, End = itinerary.End};
    }

}

}
