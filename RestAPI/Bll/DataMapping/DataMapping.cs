
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
        return new ItineraryDto { ID = itinerary.ID, Start = itinerary.Start, End = itinerary.End };
    }

    public static RecordingDto ConvertToDTO(this Recording recording)
    {
        return new RecordingDto { ID = recording.ID, Itinerary = recording.Itinerary.ConvertToDTO() };
    }

    public static RouteDto ConvertToDTO(this Route route)
    {
        return new RouteDto { ID = route.ID, RouteNumber= route.RouteNumber,Provider=route.Provider};
    }


    //public static UserDto ConvertToDTO(this User user)
    //{
        //return new UserDto { ID = user.ID, Username = user.Username, Password = user.Password };
    //}
    //User isn't added to Entities yet



}

}
