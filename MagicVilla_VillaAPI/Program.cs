using MagicVilla_VillaAPI;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Filters;
using MagicVilla_VillaAPI.Logging;
using MagicVilla_VillaAPI.Middlewares;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultSQLConnection")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<DataContext>();
builder.Services.AddResponseCaching();
builder.Services.AddScoped<IVillaRepository, VillaRepository>();
builder.Services.AddScoped<IVillaNumberRepository, VillaNumberRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

builder.Services.AddCustomAuthentication(key);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Serilog.Sinks.AspNetCore + Serilog.Sinks.File
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//    .WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

//builder.Host.UseSerilog();

builder.Services.AddControllers(options =>
{
    // options.CacheProfiles.Add("Default30", new CacheProfile() { Duration = 30 });
    options.Filters.Add<CustomExceptionFilter>();
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters()
.ConfigureApiBehaviorOptions(options =>
{
    options.ClientErrorMapping[StatusCodes.Status500InternalServerError] = new ClientErrorData
    {
        Link = "https://www.dotnetmastery.com/500"
    };
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILogging, Logging>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "Magic_VillaV2");
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Magic_VillaV1");
    });
}
// app.UseExceptionHandler("/ErrorHandling/ProcessError");
// app.HandleError(app.Environment.IsDevelopment());
app.UseMiddleware<CustomExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
ApplyMigration();
app.Run();

void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var _dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();

        if (_dataContext.Database.GetPendingMigrations().Count() > 0)
        {
            _dataContext.Database.Migrate();
        }
    }
}
