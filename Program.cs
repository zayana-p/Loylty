using System.Text;
using AutoMapper;
using FirebaseAdmin;
using FluentValidation;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using TGCLoyaltyApp.Core.Components;
using TGCLoyaltyApp.Core.Components.Abstracts;
using TGCLoyaltyApp.Core.Services;
using TGCLoyaltyApp.Core.ViewModels;
using TGCLoyaltyApp.Entities;
using TGCLoyaltyApp.Web;
using static TGCLoyaltyApp.Core.Components.BlobStorageComponent;
using V = TGCLoyaltyApp.Core.ViewModels;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
const string SECRET = "marcy9d8534b48v951b9287d492b256z";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IValidator<V.Customer>, CustomerValidator>();
builder.Services.AddScoped<IValidator<V.CustomerLoginRequest>, CustomerLoginRequestValidator>();
builder.Services.AddScoped<IValidator<V.GenerateCustomerOTPRequest>, GenerateCustomerOTPRequestValidator>();
builder.Services.AddScoped<IValidator<V.ValidateCustomerOTPRequest>, ValidateCustomerOTPRequestValidator>();
builder.Services.AddScoped<IValidator<V.ChangePasswordCustomerRequest>, ChangePasswordCustomerRequestValidator>();
builder.Services.AddScoped<IValidator<V.ResetPasswordOtpRequest>, ResetPasswordOtpRequestValidator>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IValidator<V.User>, UserValidator>();
builder.Services.AddScoped<IValidator<V.UserLoginRequest>, UserLoginRequestValidator>(); 
builder.Services.AddScoped<IValidator<V.ResetPasswordRequest>, ResetPasswordRequestValidator>();
builder.Services.AddScoped<IValidator<V.ValidateResetPasswordOtpRequest>, ValidateResetPasswordOtpRequestValidator>();
builder.Services.AddScoped<IValidator<V.GetCustomerRequest>, GetCustomerRequestValidator>();
builder.Services.AddScoped<IValidator<V.ChangePasswordUserRequest>, ChangePasswordUserRequestValidator>();
builder.Services.AddScoped<IValidator<V.UpdateUserRequest>, UpdateUserRequestValidator>();
builder.Services.AddScoped<IValidator<V.DeleteUserRequest>, DeleteUserRequestValidator>();
builder.Services.AddScoped<IValidator<V.UpdateMobileNoRequest>, UpdateMobileNoRequestValidator>();
builder.Services.AddScoped<IStoreLocationService, StoreLocationService>();
builder.Services.AddScoped<IValidator<V.StoreLocation>, StoreLocationValidator>();
builder.Services.AddScoped<IValidator<V.GetStoreLocationRequest>, GetStoreLocationRequestValidator>();
builder.Services.AddScoped<IValidator<V.UpdateStoreLocationRequest>, UpdateStoreLocationRequestValidator>();
builder.Services.AddScoped<IStoreService , StoreService>();
builder.Services.AddScoped<IValidator<V.Store>, StoreValidator>();
builder.Services.AddScoped<IValidator<V.UpdateStoreRequest>, UpdateStoreRequestValidator>();
builder.Services.AddScoped<IValidator<V.UpdateCustomerRequest>, UpdateCustomerRequestValidator>();
builder.Services.AddScoped<ISMSComponent, SynaspseSMSComponent>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IValidator<V.Order>, OrderValidator>();
builder.Services.AddScoped<IRewardsService, RewardsService>();
builder.Services.AddScoped<IStorePromotionService, StorePromotionService>();
builder.Services.AddScoped<IValidator<V.GetStorePromotionRequest>, GetStorePromotionRequestValidator>();
builder.Services.AddScoped<IValidator<V.StorePromotion>, StorePromotionValidator>();
builder.Services.AddScoped<IValidator<V.UpdateStorePromotionRequest>, UpdateStorePromotionRequestValidator>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IValidator<V.Ticket>, TicketValidator>();
builder.Services.AddScoped<IValidator<V.EmailOtpRequest>, EmailOtpRequestValidator>();
builder.Services.AddScoped<IEmailService, SmtpEmailComponent>();
builder.Services.AddScoped<IServiceTypesService, ServiceTypesService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IValidator<V.Address>, AddressValidator>();
builder.Services.AddScoped<IAzureStorage, BlobStorageComponent>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IFamilyMemberService, FamilyMemberService>();
builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IPaymentTypeService, PaymentTypeService>();
builder.Services.AddScoped<IInstallerService, InstallerService>();
builder.Services.AddScoped<IValidator<V.NewOrder>, NewOrderValidator>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IPianoMasterService, PianoService>();
builder.Services.AddScoped<IValidator<V.PianoServiceType>, PianoServiceTypeValidator>();
builder.Services.AddScoped<IOutletStoreService, OutletStoreService>();
builder.Services.AddScoped<IValidator<V.OutletStore>, OutletStoreValidator>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddScoped<IValidator<V.ProductType>, ProductTypeValidator>();
builder.Services.AddScoped<IBackOfficeService, BackOfficeService>();
builder.Services.AddScoped<IWarrantyService, WarrantyService>();
builder.Services.AddScoped<IEmiratesService, EmiratesService>();







builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.Configure<BlobStorageSettings>(builder.Configuration.GetSection("BlobStorageSettings"));



builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200",  "https://192.168.100.54:8089", "https://192.168.100.54:8095", "https://loyalty-uat-bo.thomsuninfocare.com"
                                              );
                          policy.AllowAnyHeader().AllowAnyMethod();

                      });
});

//string jsonKey = File.ReadAllText("D:\\Project area\\Loyalty\\tgc.loyaltyapp\\api\\TGCLoyaltyApp.Web\\google-services.json");

//var firebaseApp = FirebaseApp.Create(new AppOptions
//{
//    Credential = GoogleCredential.FromJson(jsonKey),
//});


var firebaseApp = FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tgcloyalty-google-services.json")),
});




builder.Services.AddSingleton(firebaseApp);

var key = Encoding.ASCII.GetBytes(SECRET);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.FromDays(1)
    };
    x.IncludeErrorDetails = true;


});
builder.Services.AddControllers();
builder.Services.AddDbContext<LoyaltyDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("MainConnection");

    options.UseNpgsql(connectionString, b => b.MigrationsAssembly("TGCLoyaltyApp.Web"));


});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen((options) =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

