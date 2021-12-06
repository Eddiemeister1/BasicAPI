using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    public class StatusController : ControllerBase
    {
        // GET /status -> 200
        [HttpGet("/status")]
        public ActionResult<StatusResponse> GetStatus()
        {
            var response = new StatusResponse { Message = "Things are going fine" };
            return Ok(response);
        }
    }

    
    public class StatusResponse
    {
        public string Message { get; set; } = string.Empty;
    }
}
