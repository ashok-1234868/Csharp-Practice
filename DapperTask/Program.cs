using DapperTask.DBConnection;
using DapperTask.Repositary;
using DapperTask.Services;
namespace DapperTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region dependency injection
            builder.Services.AddSingleton<DbContext>();
            builder.Services.AddScoped<AllService>();
            #endregion
            builder.Services.AddAutoMapper(typeof(Program));
            // add repository services
            builder.Services.AddScoped<IStudentRepo, StudentRepo>();

            #region Add CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAngularApp",
                    builder => builder.WithOrigins("http://localhost:4200") // Angular app URL
                                      .AllowAnyHeader()
                                      .AllowAnyMethod());
            });
            
          
            #endregion





            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            // Use CORS policy
            app.UseCors("AllowAngularApp");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
