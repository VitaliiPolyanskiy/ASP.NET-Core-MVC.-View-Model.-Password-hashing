using Microsoft.EntityFrameworkCore;
using StoringPassword.Models;

var builder = WebApplication.CreateBuilder(args);

// Усі сесії працюють поверх об'єкта IDistributedCache, 
// ASP.NET Core надає вбудовану реалізацію IDistributedCache
builder.Services.AddDistributedMemoryCache(); // Додаємо IDistributedMemoryCache
builder.Services.AddSession();  // Додаємо сервіси сесії

// Отримуємо рядок підключення з файлу конфігурації
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// Додаємо контекст бази даних як сервіс у застосунок
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connection));

// Додаємо сервіси MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseSession();     // Додаємо middleware-компонент для роботи із сесіями
app.UseStaticFiles(); // Обробляє запити до файлів у папці wwwroot

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();