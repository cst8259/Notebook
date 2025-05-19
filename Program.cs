using Microsoft.EntityFrameworkCore;
using Notebook.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
  options.UseSqlite("Data Source = Notebook.sqlite"));
var app = builder.Build();

app.MapControllers();

app.Run();
