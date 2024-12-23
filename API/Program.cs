using API.IOC;
using Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();

//IoC
builder.Services.AddServices();
builder.Services.AddRepositories();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //Roteamento em minúsculo
    app.UseSwagger(c =>
        c.PreSerializeFilters.Add((document, request) =>
        {
            var paths = document.Paths.ToDictionary(item => item.Key.ToLowerInvariant(), item => item.Value);
            document.Paths.Clear();
            foreach (var pathItem in paths)
            {
                document.Paths.Add(pathItem.Key, pathItem.Value);
            }
        })
    );
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
