using System.IO;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LifeSpot
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapImg();
				endpoints.MapCss();
				endpoints.MapJs();
				endpoints.MapHtml();
			});
		}

		//     public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		//     {
		//         if (env.IsDevelopment())
		//             app.UseDeveloperExceptionPage();

		//         //app.UseStaticFiles();
		//         app.UseRouting();

		//         string footerHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "footer.html"));
		//         string sideBarHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "sideBar.html"));
		//         string sliderHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(),"Views", "Shared", "slider.html"));

		//         app.UseEndpoints(endpoints =>
		//         {
		//             endpoints.MapGet("/", async context =>
		//             {
		//                 var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "index.html");

		//                 var html = new StringBuilder(await File.ReadAllTextAsync(viewPath))
		//                     .Replace("<!--SIDEBAR-->", sideBarHtml)
		//                     .Replace("<!--FOOTER-->", footerHtml);

		//                 await context.Response.WriteAsync(html.ToString());
		//             });

		//             endpoints.MapGet("/testing", async context =>
		//             {
		//                 var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "testing.html");

		//                 var html = new StringBuilder(await File.ReadAllTextAsync(viewPath))
		//                     .Replace("<!--SIDEBAR-->", sideBarHtml)
		//                     .Replace("<!--FOOTER-->", footerHtml);

		//                 await context.Response.WriteAsync(html.ToString());
		//             });

		//             endpoints.MapGet("/Static/CSS/index.css", async context =>
		//             {
		//                 var cssPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "CSS", "index.css");
		//                 var css = await File.ReadAllTextAsync(cssPath);
		//                 await context.Response.WriteAsync(css);
		//             });

		//             endpoints.MapGet("/Static/JS/index.js", async context =>
		//             {
		//                 var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", "index.js");
		//                 var js = await File.ReadAllTextAsync(jsPath);
		//                 await context.Response.WriteAsync(js);
		//             });
		//             endpoints.MapGet("/about", async context =>
		//             {
		//                 var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "about.html");

		//                 var html = new StringBuilder(await File.ReadAllTextAsync(viewPath))
		//                     .Replace("<!--SIDEBAR-->", sideBarHtml)
		//                     .Replace("<!--FOOTER-->", footerHtml)
		//                     .Replace("<!--SLIDER-->", sliderHtml);

		//                 await context.Response.WriteAsync(html.ToString());
		//             });
		//             endpoints.MapGet("/Static/JS/about.js", async context =>
		//             {
		//                 var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", "about.js");
		//                 var js = await File.ReadAllTextAsync(jsPath);
		//                 await context.Response.WriteAsync(js);
		//             });
		//	endpoints.MapGet("/Static/IMG/ny.jpg", async context =>
		//	{
		//		var imgPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "IMG", "ny.jpg");
		//		await context.Response.SendFileAsync(imgPath);
		//	});
		//	endpoints.MapGet("/Static/IMG/london.jpg", async context =>
		//	{
		//		var imgPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "IMG", "london.jpg");
		//		await context.Response.SendFileAsync(imgPath);
		//	});
		//	endpoints.MapGet("/Static/IMG/spb.jpg", async context =>
		//	{
		//		var imgPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "IMG", "spb.jpg");
		//		await context.Response.SendFileAsync(imgPath);
		//	});
		//});
		//     }
	}
}