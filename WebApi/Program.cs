using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using WebApi.SalesMarketing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSalesMarketing(builder.Configuration.GetConnectionString("BlazorIdentityConnection")); // perlu diganti connection stringnya

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//  builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "An Example API",
            Version = "v1",
           // Description = "An API to perform restfulApi",
            TermsOfService = new Uri("https://example.com/terms"),
            Contact = new OpenApiContact
            {
                Name = "Sutanto Gasali",
                Email = "sutanto.gasali@gmail.com",
                 Url = new Uri("https://www.linkedin.com/in/sutanto-gasali-299462190"),
            },
            License = new OpenApiLicense
            {
                Name = "example licence",
                //Url = new Uri("https://example.com/license"),
            },
                Description = @"REST services for managing your API ecosystem

                            ## Business Domains and Sub Domains ##
                            Breakdown your business into domains and sub domains in order to better manage your APIs.

                            ## Tags ##
                            Create tags to help you classify your APIs on multiple dimensions or link APIs that form cross-cutting business processes

                            ## API Management ##
                            Manage creation, update and deletion of the APIs in your registry. Classify your APIs by business sub domain and add tags for further classification.",

            });
        // Set the comments path for the Swagger JSON and UI.
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    c.ExampleFilters(); // add this to support examples
});


//builder.Services.AddSwaggerExamplesFromAssemblyOf<Startup>(); // to automatically search all the example from assembly.

builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        //c.DocumentTitle = "Address API - Swagger docs";
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        //c.EnableDeepLinking();
        //c.DefaultModelsExpandDepth(0);
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
