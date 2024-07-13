using AutoMapper;
using BookStore.Data.dtos;
using BookStore.Data.Models;
using BookStore.Repostitory;
using Microsoft.AspNetCore.Mvc;


namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _mapper.Map<User>(registerDto);
            user = await _userRepository.Register(user);
            return Ok(user);

        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto userDto)
        {
           if(!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userRepository.Login(userDto);
            return Ok(user);
        }

        [HttpGet("istaken")]
        public async Task<IActionResult> IsEmailTaken(string email)
        {
            if (string.IsNullOrEmpty(email))
                return BadRequest(new { message = "Invalid email address!" });

            return Ok(await _userRepository.IsEmailTaken(email));
        }

    }
}
