using ClassLibrary1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MemberController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            return await _context.Member.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Member>> CreateMember(Member item)
        {
            var member = new Member
            {
                Id = Guid.NewGuid(),
                Name = item.Name,
                Account = item.Account,
                Password = item.Password,
            };
            _context.Member.Add(member);
            await _context.SaveChangesAsync();
            return Ok(member);
        }

  
    }
}
