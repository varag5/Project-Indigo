﻿using Bll.Dtos;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
	[Route("api/itinerary")]
	[ApiController]
	public class ItineraryController : ControllerBase
	{
		private readonly IItineraryService itineraryService;

		// POST: api/itinerary
		/// <summary>
		/// Creates a new itinerary.
		/// </summary>
		/// <returns></returns>
		[HttpPost]
		public IActionResult CreateNewItinerary([FromBody]ItineraryDto itinerary)
		{
			return Ok("Hello World!");
		}

		//PUT: api/itinerary/{id}
		/// <summary>
		/// Modify an existing itinerary.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpPut("{id}")]
		public IActionResult UpdateItinerary(int id, [FromBody]ItineraryDto itinerary)
		{
			return Ok("Hello World!");
		}

		//GET: api/itinerary/start={start}&end={end}
		/// <summary>
		/// Gets an itinerary between two locations.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		[HttpGet]
		public ActionResult<IEnumerable<ItineraryDto>> GetItinerary(string start = null, string end = null)
		{
			return Ok($"Hello! Start is {start} end is {end}");
		}

		//GET: api/itinerary/user={userId}
		/// <summary>
		/// Gets all itineraries for a user.
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		[HttpGet("{userId}")]
		public ActionResult<IEnumerable<ItineraryDto>> GetItinerary(int userId)
		{
			return Ok($"Hello! User is {userId}");
		}
	}
}
