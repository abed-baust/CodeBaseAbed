namespace CodeBaseAbed
{
    public static class RegisterStartupMiddlewares
    {
        public static WebApplication SetupMiddleware(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //For minimal API Call
            app.ConfigureApi();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
