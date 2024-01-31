
Console.WriteLine("Aperte uma tecla pra começar");
Console.ReadKey();

Console.WriteLine("Inicio");

await Tarefa1Async();
Tarefa2Async();

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
