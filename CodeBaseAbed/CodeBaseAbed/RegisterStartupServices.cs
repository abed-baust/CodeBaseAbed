namespace CodeBaseAbed
{
    public static class RegisterStartupServices
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
            builder.Services.AddSingleton<IUserData, UserData>();
            return builder;
        }
    }
}
