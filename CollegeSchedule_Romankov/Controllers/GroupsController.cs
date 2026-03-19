using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CollegeSchedule_Romankov.DTO;
using CollegeSchedule_Romankov.Data;

namespace CollegeSchedule_Romankov.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GroupsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupDto>>> GetGroups()
        {
            var groups = await _context.StudentGroups
                .Select(g => new GroupDto
                {
                    GroupId = g.GroupId,
                    GroupName = g.GroupName
                })
                .ToListAsync();

            return Ok(groups);
        }
    }
}