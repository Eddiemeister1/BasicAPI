using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicAPI.Controllers
{
    public class AgentsController : ControllerBase
    {
        [HttpGet("/agents")]
        public ActionResult GetAllAgents()
        {
            var responses = new GetAgentsResponse();
            responses.Agents = new()
            {
                new AgentResponseItem { Id = 1, FirstName = "Bob", LastName = "Smith", Email = "bob@aol.com", Phone = "555-1212" },
                new AgentResponseItem { Id = 2, FirstName = "Sue", LastName = "Jones", Email = "sue@aol.com" },
            };
            return Ok(responses);
        }
    }

    public class GetAgentsResponse
    {
        public List<AgentResponseItem> Agents { get; set; } = new List<AgentResponseItem>();
    }

    public class AgentResponseItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;

        public string? Email { get; set; }
    }

}
