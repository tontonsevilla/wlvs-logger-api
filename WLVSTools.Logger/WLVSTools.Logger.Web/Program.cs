using WLVSTools.Logger.Web.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddDbContext<LoggerDbContext>();

var app = builder.Build();
app.MapDefaultControllerRoute();

app.Run();
