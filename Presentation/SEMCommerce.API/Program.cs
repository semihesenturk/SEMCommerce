using SEMCommerce.Persistence;

var builder = WebApplication.CreateBuilder(args);

#region Layer Registrations
builder.Services.AddPersistenceServices();
#endregion

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();