
Console.WriteLine("Aperte uma tecla pra começar");
Console.ReadKey();

Console.WriteLine("Inicio");

var tarefa1 = Tarefa1Async();
var tarefa2 = Tarefa2Async();

await Task.WhenAll(tarefa1, tarefa2);

Console.WriteLine("Fim");
Console.ReadLine();

async Task Tarefa1Async()
{
    Console.WriteLine("Iniciando tarefa 1");
    await Task.Delay(TimeSpan.FromSeconds(6));
    Console.WriteLine("Fim da tarefa 1");
}

async Task Tarefa2Async()
{
    Console.WriteLine("Iniciando tarefa 2");
    await Task.Delay(3000);
    Console.WriteLine("Fim da tarefa 2");
}
