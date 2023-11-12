using CompanyReader.Application;
using CompanyReader.Application.Services;
using CompanyReader.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Configuration.AddJsonFile("appsettings.json");

// Configure services
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IProcessService, ProcessService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/api/create", async (IFormFile file, ICompanyService companyService, IProcessService processService) =>
{
    try
    {
        var companyDtos = processService.ProcessCsv(file);

        foreach (var companyDto in companyDtos)
        {
            companyService.CreateRecord(companyDto);
        }

        return Results.Ok("Company Records created successfully!");
    }
    catch (Exception ex)
    {
        throw ex;
    }
})
.WithName("CreateCompanyRecord");
app.MapControllers();
app.Run();

