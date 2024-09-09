using Microsoft.EntityFrameworkCore;
using U6_Lab1_WebService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UniversidadContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// GetOne Alumno
app.MapGet("/alumnos/{id}", async (int id, UniversidadContext context) =>
    await context.Alumnos.FindAsync(id) is Alumno alumno
        ? Results.Ok(alumno)
        : Results.NotFound());

app.MapGet("/alumnos", async (UniversidadContext context) =>
    await context.Alumnos.ToListAsync());

app.MapPost("/alumnos", async (Alumno alumno, UniversidadContext context) =>
{
    context.Alumnos.Add(alumno);
    await context.SaveChangesAsync();

    return Results.Created($"/alumnos/{alumno.Id}", alumno);
});

app.MapPut("/alumnos", async (Alumno alumno, UniversidadContext context) =>
{
    Alumno? alumnoAActualizar = await context.Alumnos.FindAsync(alumno.Id);
    if(alumnoAActualizar != null)
    {
        alumnoAActualizar.Nombre = alumno.Nombre;
        alumnoAActualizar.Apellido = alumno.Apellido;
        alumnoAActualizar.Legajo = alumno.Legajo;
        alumnoAActualizar.Direccion = alumno.Direccion;
        await context.SaveChangesAsync();

        return Results.Ok(alumnoAActualizar);
    }
    return Results.NotFound();
});

app.MapDelete("/alumnos/{id}", async (int id, UniversidadContext context) =>
{
    Alumno? alumnoAEliminar = await context.Alumnos.FindAsync(id);
    if (alumnoAEliminar != null)
    {
        context.Alumnos.Remove(alumnoAEliminar);
        await context.SaveChangesAsync();

        return Results.Ok(alumnoAEliminar);
    }
    return Results.NotFound();
});

app.Run();
