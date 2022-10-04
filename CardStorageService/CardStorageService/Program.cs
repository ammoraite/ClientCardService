using CardStorageService.Data;
using CardStorageService.Services;
using CardStorageService.Services.Impl;

using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;

using NLog.Web;

namespace CardStorageService
{
    public class Program
    {
        public static void Main ( string[] args )
        {
            #region ServiceBuilder
            var builder = WebApplication.CreateBuilder (args);

            #region ConfigureLoggerService

            builder.Services.AddHttpLogging (logging =>
            {
                logging.LoggingFields=HttpLoggingFields.All|HttpLoggingFields.RequestQuery;
                logging.RequestBodyLogLimit=4096;
                logging.ResponseBodyLogLimit=4096;
                logging.RequestHeaders.Add ("Authorization");
                logging.RequestHeaders.Add ("X-Real-IP");
                logging.RequestHeaders.Add ("X-Forwarded-For");
            });

            builder.Host.ConfigureLogging (logging =>
            {
                logging.ClearProviders ( );
                logging.AddConsole ( );

            }).UseNLog (new NLogAspNetCoreOptions ( ) { RemoveLoggerFactoryFilter=true });

            #endregion

            #region Confugure EF DBContext Service (CardStorageService Database)

            builder.Services.AddDbContext<CardStorageServiceDbContext> (options =>
            {
                options.UseSqlServer (builder.Configuration["DatabaseOptions:ConnectionString"]);
            });

            #endregion

            #region Configure Repositories Services

            builder.Services.AddScoped<ICardRepositoryService, CardRepository> ( );
            builder.Services.AddScoped<IClientRepositoryService, ClientRepository> ( );

            #endregion

            #region AddEndpointsApiExplorer AddControllers AddSwaggerGen
            builder.Services.AddControllers ( );
            builder.Services.AddEndpointsApiExplorer ( );
            builder.Services.AddSwaggerGen ( );
            #endregion


            var app = builder.Build ( );
            #endregion


            if (app.Environment.IsDevelopment ( ))
            {
                app.UseSwagger ( );
                app.UseSwaggerUI ( );
            }

            app.UseAuthorization ( );
            app.UseHttpLogging ( );


            app.MapControllers ( );

            app.Run ( );
        }
    }
}