using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DiscountAPI.Context;
using Microsoft.EntityFrameworkCore;
using DiscountAPI.Repository;
using DiscountAPI.Repository.IRepository;
using DiscountAPI.Models;
using DiscountAPI.Models.DTO;

namespace DiscountAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public object ReferenceHandler { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConectionString")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<IItemVoucherRepository, ItemVoucherRepository>();

            services.AddAutoMapper(configuration =>{
                configuration.CreateMap<Product, ProductDTO>();
                configuration.CreateMap<ProductDTO, Product>();
                configuration.CreateMap<Category, CategoryDTO>();
                configuration.CreateMap<CategoryDTO, Category>();
                configuration.CreateMap<Stock, StockDTO>();
                configuration.CreateMap<StockDTO, Stock>();
            }, typeof(Startup)
            );

            services.AddControllers().AddNewtonsoftJson(x =>
                x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
