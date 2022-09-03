using Microsoft.AspNetCore.Mvc;

namespace CodeBaseAbed.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserData _data;

        public UsersController(IUserData data)
        {
            _data = data;
        }

        [HttpGet]
        public async Task<IResult> GetUsers()
        {
            try
            {
                return Results.Ok(await _data.GetUsers());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
