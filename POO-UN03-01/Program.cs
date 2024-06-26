using POO_UN03_01;

Cliente cliente1 = new Cliente(1, "João", 1200);
Cliente cliente2 = new Cliente(2,"Maria",6000); 

Console.WriteLine("Cliente1: " + cliente1.Nome + cliente1.PromoverCliente(6000));
Console.WriteLine("Cliente2: " + cliente2.Nome);
Console.ReadKey();


