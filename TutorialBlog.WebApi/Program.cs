using AutoMapper;
using TutorialBlog.DAL.Interfaces;
using TutorialBlog.DAL.Managers;
using TutorialBlog.DAL.Model;
using TutorialBlog.Service.Interfaces;
using TutorialBlog.Service.Services;
using TutorialBlog.WebApi.Controllers;

namespace TutorialBlog.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<IActivityService, ActivityService>();
            builder.Services.AddSingleton<IActivityManager, ActivityManager>();
            builder.Services.AddSingleton<IUserService, UserService>();
            builder.Services.AddSingleton<IUserManager, UserManager>();
            builder.Services.AddSingleton<TutorialBlogContext>();
            builder.Services.AddAutoMapper(typeof(Program));
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}