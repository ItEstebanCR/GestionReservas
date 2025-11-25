using GestionReserva.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. AGREGAR MVC

builder.Services.AddControllersWithViews();


// 2. INYECTAR EL REPOSITORIO EN MEMORIA
builder.Services.AddSingleton<ReservasRepositorio>();

var app = builder.Build();

// 3. HABILITAR ARCHIVOS ESTÁTICOS (wwwroot)

app.UseStaticFiles();


// 4. HABILITAR ROUTING

app.UseRouting();

// 5. RUTA POR DEFECTO

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reservas}/{action=Index}/{id?}"
);

// ---------------------------------------------
app.Run();
 