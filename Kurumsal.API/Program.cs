using System.Text;
using Kurumsal.Application.Interfaces;
using Kurumsal.Application.Mapping;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Kurumsal.Infrastructure.Options; // <-- JwtOptions
using Kurumsal.Infrastructure.Services;
using Kurumsal.Infrastructure.Tenancy;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ITenantProvider, HttpTenantProvider>();

// Services + AutoMapper Profilleri
builder.Services.AddScoped<IUlkeService, UlkeService>();
builder.Services.AddAutoMapper(typeof(UlkeProfile).Assembly);

builder.Services.AddScoped<ISehirService, SehirService>();
builder.Services.AddAutoMapper(typeof(SehirProfile).Assembly);

builder.Services.AddScoped<IIlceService, IlceService>();
builder.Services.AddAutoMapper(typeof(IlceProfile).Assembly);

builder.Services.AddScoped<ISektorService, SektorService>();
builder.Services.AddAutoMapper(typeof(SektorProfile).Assembly);

builder.Services.AddScoped<IDovizService, DovizService>();
builder.Services.AddAutoMapper(typeof(DovizProfile).Assembly);

builder.Services.AddScoped<ITenantService, TenantService>();
builder.Services.AddAutoMapper(typeof(TenantProfile).Assembly);

builder.Services.AddScoped<IAppRoleService, AppRoleService>();
builder.Services.AddAutoMapper(typeof(AppRoleProfile).Assembly);

builder.Services.AddScoped<IAppUserService, AppUserService>();
builder.Services.AddAutoMapper(typeof(AppUserProfile).Assembly);

// Auth (Login) servisi
builder.Services.AddScoped<IAuthService, AuthService>();

// Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Kurumsal API", Version = "v1" });
    c.UseAllOfToExtendReferenceSchemas();
    c.DescribeAllParametersInCamelCase();

    c.AddServer(new() { Url = "https://localhost:7264" });
    c.AddServer(new() { Url = "http://localhost:5264" });

    // --- Swagger: Bearer Auth ---
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Bearer {token}"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        { new OpenApiSecurityScheme {
              Reference = new OpenApiReference {
                  Type = ReferenceType.SecurityScheme,
                  Id = "Bearer"
              }
          }, Array.Empty<string>() }
    });
});

// EF Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity (role destekli)
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// --- JWT Ayarları ---
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(JwtOptions.SectionName));
var jwt = builder.Configuration.GetSection(JwtOptions.SectionName).Get<JwtOptions>()
          ?? throw new InvalidOperationException("Jwt options missing in configuration.");

var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(o =>
    {
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = jwt.Issuer,
            ValidateAudience = true,
            ValidAudience = jwt.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization();

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Kurumsal API v1");
        c.DisplayOperationId();
        c.DisplayRequestDuration();
    });
}

// Pipeline
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthentication();   // JWT
app.UseAuthorization();

app.MapControllers();

app.Run();
