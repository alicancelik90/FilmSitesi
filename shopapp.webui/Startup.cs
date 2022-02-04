using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using shopapp.business.Abstract;
using shopapp.business.Concrete;
using shopapp.data.Abstract;
using shopapp.data.Concrete;
using shopapp.data.Concrete.EfCore;



namespace MVC_Film_Örnek_Uygulama
{
    public class Startup
    {
       
        
        public void ConfigureServices(IServiceCollection services)
        {
         
           
            services.AddScoped<IFilmRepository,EfCoreFilmRepository>();
            services.AddScoped<IKategoriRepository,EfCoreKategoriRepository>();
            services.AddScoped<IStarRepository,EfCoreStarRepository>();
            services.AddScoped<ICommentRepository,EfCoreCommentRepository>();

            services.AddScoped<IFilmService,FilmManager>();
            services.AddScoped<IKategoriService,KategoriManager>();
            services.AddScoped<IStarService,StarManager>();
            services.AddScoped<ICommentService,CommentManager>();
          

            
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             app.UseStaticFiles(); //wwwroot a ulaşmak için

            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                
                 endpoints.MapControllerRoute
                 (
                  name : "adminstarlist",
                  pattern : "admin/stars",
                  defaults : new{controller = "Admin" ,Action = "Starlist"}            
                  
                  );
                 
                

                  endpoints.MapControllerRoute
                 (
                  name : "adminfilmler",
                  pattern : "admin/filmler",
                  defaults : new{controller = "Admin" ,Action = "FilmListe"}            
                  
                  );
                 
                

                    endpoints.MapControllerRoute
                 (
                  name : "adminfilmekle",
                  pattern : "admin/filmler/ekle",
                  defaults : new{controller = "Admin" ,Action = "FilmEkle"}            
                  
                  );
                     endpoints.MapControllerRoute
                 (
                  name : "adminfilmduzenle",
                  pattern : "admin/filmler/{id?}",
                  defaults : new{controller = "Admin" ,Action = "FilmDuzenle"}            
                  
                  );
                 
  
                  
                      endpoints.MapControllerRoute
                 (
                  name : "adminkategoriler",
                  pattern : "admin/kategoriler",
                  defaults : new{controller = "Admin" ,Action = "KategoriListe"}            
                  
                  );
                        endpoints.MapControllerRoute
                 (
                  name : "adminkategoriekle",
                  pattern : "admin/kategoriler/ekle",
                  defaults : new{controller = "Admin" ,Action = "KategoriEkle"}            
                  
                  );
                     endpoints.MapControllerRoute
                 (
                  name : "adminkategoriduzenle",
                  pattern : "admin/kategoriler/{id?}",
                  defaults : new{controller = "Admin" ,Action = "KategoriDuzenle"}            
                  
                  );
                 
  
               
                  endpoints.MapControllerRoute
                 (
                  name : "ara",
                  pattern : "ara",
                  defaults : new{controller = "filmsitesi" ,Action = "Ara"}            
                  
                  );


                  endpoints.MapControllerRoute
                 (
                  name : "filmdetay",
                  pattern : "{url}",
                  defaults : new{controller = "filmsitesi" ,Action = "detay"}            
                  
                  );

                 endpoints.MapControllerRoute
                 (
                  name : "starabout",
                  pattern : "filmsitesi/startheabout/{id}",
                  defaults : new{controller = "filmsitesi" ,Action = "startheabout"}            
                  
                  );

                endpoints.MapControllerRoute
                 (
                  name : "film listesi",
                  pattern : "film listesi/{kategori?}",
                  defaults : new{controller = "filmsitesi" ,Action ="liste"}            
                  
                  );

               endpoints.MapControllerRoute
               (
                name : "başlangıç",
                pattern : "{controller=Anasayfa}/{action=Ana}/{id?}"
               );
            });
        }
    }
}
