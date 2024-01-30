
Console.WriteLine("Aperte uma tecla pra começar");
Console.ReadKey();

Console.WriteLine("Inicio");

// Tarefa1();
// Tarefa2();
await Tarefa1Async();
Tarefa2Async();

Console.WriteLine("Fim");
Console.ReadLine();

// void Tarefa1()
// {
//     Console.WriteLine("Iniciando tarefa 1");
//     Thread.Sleep(6000);
//     Console.WriteLine("Fim da tarefa 1");
// }

// void Tarefa2()
{
    Console.WriteLine("Iniciando tarefa 1");
    Thread.Sleep(3000);
    Console.WriteLine("Fim da tarefa 1");
}

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
