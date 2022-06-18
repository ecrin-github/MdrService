using System.Net;
using MdrService.Configs;
using MdrService.Extensions;
using MdrService.Middleware;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.KnownProxies.Add(IPAddress.Parse("51.210.99.16"));
});

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc($"{ApiConfigs.ApiVersion}", 
        new OpenApiInfo { Title = "The MDR API Documentation", Version = $"{ApiConfigs.ApiVersion}" });
    c.EnableAnnotations();
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(ApiConfigs.OpenCorsPolicyName, p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});

builder.WebHost.UseUrls("http://localhost:5270");

// Docker setting
// builder.WebHost.UseKestrel(options => {options.Listen(IPAddress.Any, 80);});

var app = builder.Build();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.DocumentTitle = "The MDR API Documentation";
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "The MDR API Documentation (v.1)");
    c.InjectStylesheet("/documentation/swagger-custom/swagger-custom-styles.css");
    c.InjectJavascript("/documentation/swagger-custom/swagger-custom-script.js");
    c.RoutePrefix = "api/rest/documentation";
});

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors(ApiConfigs.OpenCorsPolicyName);

app.MapControllers();

app.Run();