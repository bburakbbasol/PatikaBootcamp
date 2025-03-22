using Microsoft.AspNetCore.Mvc;
using Pratik_DI.Services;

namespace Pratik_DI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ClassRoomController : ControllerBase
	{
		private readonly ClassRoom _clasRoom;
		public ClassRoomController(ClassRoom classRoom)
		{
			_clasRoom = classRoom;
		}

		[HttpGet]
		public ActionResult GetTeacherInfo()
		{
			var teacherInfo=_clasRoom.GetTeacherInfo();
			return Ok(teacherInfo);
		}

	}
}
