using DataAccess.Models;

namespace CodeBaseAbed
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/UsersMinimalApi",GetUsers);
            app.MapGet("/UsersMinimalApi/{id}", GetUser);
            app.MapPost("/UsersMinimalApi", InsertUser);
            app.MapPut("/UsersMinimalApi", UpdateUser);
            app.MapDelete("/UsersMinimalApi/{id}", DeleteUser);
        }

        private static async Task<IResult>GetUsers(IUserData data)
        {
            try
            {
                return Results.Ok(await data.GetUsers());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetUser(int id,IUserData data)
        {
            try
            {
                var results = await data.GetUser(id);
                if(results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertUser(UserModel user, IUserData data)
        {
            try
            {
               await data.InserUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateUser(UserModel user, IUserData data)
        {
            try
            {
                await data.UpdateUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteUser(int id, IUserData data)
        {
            try
            {
                await data.DeleteUser(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
