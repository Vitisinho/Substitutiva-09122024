var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/api/aluno/cadastrar", ([FromBody] Aluno aluno,
    [FromServices] AppDataContext ctx) => cd
{
    ctx.Aluno.Add(aluno);
    for (int i = 0; i < ctx.id.length; i++)
    {
        if (aluno.nome == ctx.nome{i} && aluno.sobrenome == ctx.sobrenome{i}){
        return Results.Erro();
    }else
    {
        ctx.add(aluno);
        ctx.SaveChanges();
        return Results.Created();
    }
}
    
});

app.MapPost("/api/imc/cadastrar/{id}", ([FromBody] Imcs imc,
    [FromServices] AppDataContext ctx) => cd
{
    ctx.imc.Add(imc);
    imc calcImc = calcImc new imc();
    calcImc = (ctx.peso) / ((ctx.altura) ^ 2);
    ctx.add();
    ctx.SaveChanges();
    return Results.Ok();
});

app.Run();
