using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/recording")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Hello World!");
		}
	}
}
