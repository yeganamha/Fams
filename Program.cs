namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();
            var app = builder.Build();
                app.UseHttpsRedirection();
                 app.UseStaticFiles();
            app.UseRouting();
          app.UseAuthorization();
            app.UseHsts();
            app.UseDefaultFiles();
            app.MapRazorPages();

            app.Run();
        }
    }
}